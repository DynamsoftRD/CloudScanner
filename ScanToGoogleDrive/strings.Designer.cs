﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ScanToCloud {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ScanToCloud.strings", typeof(strings).Assembly);
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
        ///   Looks up a localized string similar to Scan Document To Google Drive.
        /// </summary>
        internal static string app_title {
            get {
                return ResourceManager.GetString("app_title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Upload to Google Drive.
        /// </summary>
        internal static string button_upload {
            get {
                return ResourceManager.GetString("button_upload", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please enter file name!.
        /// </summary>
        internal static string msg_no_file_title {
            get {
                return ResourceManager.GetString("msg_no_file_title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please scan an image!.
        /// </summary>
        internal static string msg_no_image {
            get {
                return ResourceManager.GetString("msg_no_image", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Start to upload....
        /// </summary>
        internal static string msg_start_upload {
            get {
                return ResourceManager.GetString("msg_start_upload", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Uploading finished!.
        /// </summary>
        internal static string msg_uploading_finished {
            get {
                return ResourceManager.GetString("msg_uploading_finished", resourceCulture);
            }
        }
    }
}
