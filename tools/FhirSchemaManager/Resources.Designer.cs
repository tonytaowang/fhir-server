﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FhirSchemaManager {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("FhirSchemaManager.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Applies the specified SQL schema update to the supplied connection string for the given FHIR server..
        /// </summary>
        internal static string ApplyCommandDescription {
            get {
                return ResourceManager.GetString("ApplyCommandDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Returns the available SQL schema versions for the given FHIR server..
        /// </summary>
        internal static string AvailableCommandDescription {
            get {
                return ResourceManager.GetString("AvailableCommandDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There are no available versions..
        /// </summary>
        internal static string AvailableVersionsDefaultErrorMessage {
            get {
                return ResourceManager.GetString("AvailableVersionsDefaultErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The compatible versions information is not available..
        /// </summary>
        internal static string CompatibilityDefaultErrorMessage {
            get {
                return ResourceManager.GetString("CompatibilityDefaultErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The connection string of the SQL server to apply the schema update..
        /// </summary>
        internal static string ConnectionStringOptionDescription {
            get {
                return ResourceManager.GetString("ConnectionStringOptionDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You must include a connection string..
        /// </summary>
        internal static string ConnectionStringRequiredValidation {
            get {
                return ResourceManager.GetString("ConnectionStringRequiredValidation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Returns the current SQL schema version(s) from the given FHIR server..
        /// </summary>
        internal static string CurrentCommandDescription {
            get {
                return ResourceManager.GetString("CurrentCommandDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The current version information is not available due to HttpStatusCode {0}..
        /// </summary>
        internal static string CurrentDefaultErrorDescription {
            get {
                return ResourceManager.GetString("CurrentDefaultErrorDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The root URL of the FHIR server to connect to..
        /// </summary>
        internal static string FhirServerOptionDescription {
            get {
                return ResourceManager.GetString("FhirServerOptionDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You must include a FHIR server..
        /// </summary>
        internal static string FhirServerRequiredValidation {
            get {
                return ResourceManager.GetString("FhirServerRequiredValidation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The schema migration is run without validating the schema verison..
        /// </summary>
        internal static string ForceOptionDescription {
            get {
                return ResourceManager.GetString("ForceOptionDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure to apply command with force option? To discontinue, please enter No..
        /// </summary>
        internal static string ForceWarning {
            get {
                return ResourceManager.GetString("ForceWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No connection could be made to the target machine..
        /// </summary>
        internal static string HttpRequestExceptionMessage {
            get {
                return ResourceManager.GetString("HttpRequestExceptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The schema version {0} cannot be applied because all the instances are not running the previous version..
        /// </summary>
        internal static string InvalidVersionMessage {
            get {
                return ResourceManager.GetString("InvalidVersionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The versions between current version and latest available version to apply..
        /// </summary>
        internal static string LatestOptionDescription {
            get {
                return ResourceManager.GetString("LatestOptionDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You must include only one of the option from [version, next, latest]..
        /// </summary>
        internal static string MutuallyExclusiveValidation {
            get {
                return ResourceManager.GetString("MutuallyExclusiveValidation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The next version to apply..
        /// </summary>
        internal static string NextOptionDescritpion {
            get {
                return ResourceManager.GetString("NextOptionDescritpion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Script execution has failed due to {0}..
        /// </summary>
        internal static string QueryExecutionErrorMessage {
            get {
                return ResourceManager.GetString("QueryExecutionErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Request has failed due to {0} is inactive..
        /// </summary>
        internal static string RequestFailedMessage {
            get {
                return ResourceManager.GetString("RequestFailedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Schema Migration is completed successfully for the version {0}..
        /// </summary>
        internal static string SchemaMigrationSuccessMessage {
            get {
                return ResourceManager.GetString("SchemaMigrationSuccessMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The script is not found for the given version..
        /// </summary>
        internal static string ScriptNotFound {
            get {
                return ResourceManager.GetString("ScriptNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The schema version {0} is not compatbile..
        /// </summary>
        internal static string VersionIncompatibilityMessage {
            get {
                return ResourceManager.GetString("VersionIncompatibilityMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The versions between current version and specified version to apply..
        /// </summary>
        internal static string VersionOptionDescription {
            get {
                return ResourceManager.GetString("VersionOptionDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Waiting for a minute to ensure server side polling is completed....
        /// </summary>
        internal static string WaitMessage {
            get {
                return ResourceManager.GetString("WaitMessage", resourceCulture);
            }
        }
    }
}
