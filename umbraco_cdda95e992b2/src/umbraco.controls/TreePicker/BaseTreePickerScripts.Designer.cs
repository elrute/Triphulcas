﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.544
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace umbraco.uicontrols.TreePicker {
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
    internal class BaseTreePickerScripts {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal BaseTreePickerScripts() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("umbraco.uicontrols.TreePicker.BaseTreePickerScripts", typeof(BaseTreePickerScripts).Assembly);
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
        ///   Looks up a localized string similar to /// &lt;reference path=&quot;/umbraco_client/Application/NamespaceManager.js&quot; /&gt;
        ///
        ///Umbraco.Sys.registerNamespace(&quot;Umbraco.Controls&quot;);
        ///
        ///(function($) {
        ///    Umbraco.Controls.TreePicker = function(clientId, label, itemIdValueClientID, itemTitleClientID, itemPickerUrl, width, height, showHeader, umbracoPath) {
        ///        var obj = {
        ///            _itemPickerUrl: itemPickerUrl,
        ///            _webServiceUrl: umbracoPath + &quot;/webservices/legacyAjaxCalls.asmx/GetNodeName&quot;,
        ///            _label: label,
        ///            _width: wid [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string BaseTreePicker {
            get {
                return ResourceManager.GetString("BaseTreePicker", resourceCulture);
            }
        }
    }
}
