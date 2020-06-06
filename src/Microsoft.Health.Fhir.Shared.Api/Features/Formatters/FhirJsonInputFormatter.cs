﻿// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System;
using System.Buffers;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using EnsureThat;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Health.Fhir.Api.Features.ContentTypes;
using Microsoft.Health.Fhir.Core.Extensions;
using Microsoft.Health.Fhir.Core.Features;
using Microsoft.Health.Fhir.Core.Models;
using Microsoft.Health.Fhir.Core.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using JsonSerializer = System.Text.Json.JsonSerializer;
using Task = System.Threading.Tasks.Task;

namespace Microsoft.Health.Fhir.Api.Features.Formatters
{
    internal class FhirJsonInputFormatter : TextInputFormatter
    {
        private readonly FhirJsonParser _parser;
        private readonly IArrayPool<char> _charPool;

        public FhirJsonInputFormatter(FhirJsonParser parser, ArrayPool<char> charPool)
        {
            EnsureArg.IsNotNull(parser, nameof(parser));
            EnsureArg.IsNotNull(charPool, nameof(charPool));

            _parser = parser;
            _charPool = new JsonArrayPool(charPool);

            SupportedEncodings.Add(UTF8EncodingWithoutBOM);
            SupportedEncodings.Add(UTF16EncodingLittleEndian);
            SupportedMediaTypes.Add(KnownContentTypes.JsonContentType);
            SupportedMediaTypes.Add(KnownMediaTypeHeaderValues.ApplicationJson);
            SupportedMediaTypes.Add(KnownMediaTypeHeaderValues.TextJson);
            SupportedMediaTypes.Add(KnownMediaTypeHeaderValues.ApplicationAnyJsonSyntax);
        }

        protected override bool CanReadType(Type type)
        {
            EnsureArg.IsNotNull(type, nameof(type));

            return typeof(ResourceElement).IsAssignableFrom(type);
        }

        /// <inheritdoc />
        /// <remarks>
        /// Reference implementation: https://github.com/aspnet/Mvc/blob/dev/src/Microsoft.AspNetCore.Mvc.Formatters.Json/JsonInputFormatter.cs
        /// Parsing from a stream: https://github.com/ewoutkramer/fhir-net-api/blob/master/src/Hl7.Fhir.Support/Utility/SerializationUtil.cs#L134
        /// </remarks>
        public override async Task<InputFormatterResult> ReadRequestBodyAsync(InputFormatterContext context, Encoding encoding)
        {
            EnsureArg.IsNotNull(context, nameof(context));
            EnsureArg.IsNotNull(encoding, nameof(encoding));

            var request = context.HttpContext.Request;

            using (var streamReader = context.ReaderFactory(request.Body, encoding))
            using (var jsonReader = new JsonTextReader(streamReader))
            {
                Exception delayedException = null;
                ResourceElement model = null;

                jsonReader.DateParseHandling = DateParseHandling.None;
                jsonReader.FloatParseHandling = FloatParseHandling.Decimal;
                jsonReader.ArrayPool = _charPool;
                jsonReader.CloseInput = false;

                try
                {
                    var obj = await JsonDocument.ParseAsync(request.Body, cancellationToken: context.HttpContext.RequestAborted);
                    model = FhirJsonTextNode.Create(obj).ToResourceElement(ModelInfoProvider.Instance);

                    // var obj = (JObject)await JObject.ReadFromAsync(jsonReader, context.HttpContext.RequestAborted);
                    // model = FhirJsonNode.Create(obj, null, settings: DefaultParserSettings.JsonParserSettings).ToResourceElement(ModelInfoProvider.Instance);
                }
                catch (Exception ex)
                {
                    delayedException = ex;
                }

                // Some nonempty inputs might deserialize as null, for example whitespace,
                // or the JSON-encoded value "null". The upstream BodyModelBinder needs to
                // be notified that we don't regard this as a real input so it can register
                // a model binding error.
                // https://github.com/aspnet/Mvc/blob/ce66e953045d3c3c52bd6c2bd9d5385fb52eccdc/src/Microsoft.AspNetCore.Mvc.Formatters.Json/JsonInputFormatter.cs#L221
                if (model == null && delayedException == null && !context.TreatEmptyInputAsDefaultValue)
                {
                    return await Task.FromResult(InputFormatterResult.NoValue());
                }

                if (model != null)
                {
                    return await Task.FromResult(InputFormatterResult.Success(model));
                }

                if (delayedException != null)
                {
                    // Avoid using the exception's message, since the exception thrown in the HL7 FHIR core library has an incorrect message.
                    var errorMessage = Api.Resources.ParsingError;

                    // Add model state information to return to the client
                    context.ModelState.TryAddModelError(string.Empty, errorMessage);
                }

                return await Task.FromResult(InputFormatterResult.Failure());
            }
        }
    }
}
