﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Leviathan.ViewModel.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Leviathan.ViewModel.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to .lsav.
        /// </summary>
        internal static string CharactersExtension {
            get {
                return ResourceManager.GetString("CharactersExtension", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /My Games/Leviathan/saves/.
        /// </summary>
        internal static string CharactersFolder {
            get {
                return ResourceManager.GetString("CharactersFolder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .png.
        /// </summary>
        internal static string ImagesExtension {
            get {
                return ResourceManager.GetString("ImagesExtension", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to pack://application:,,,/Leviathan.View;component/imgs/.
        /// </summary>
        internal static string ImagesFolder {
            get {
                return ResourceManager.GetString("ImagesFolder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to items/.
        /// </summary>
        internal static string ItemsFolder {
            get {
                return ResourceManager.GetString("ItemsFolder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to pack://application:,,,/Leviathan.View;component/imgs/noimage.png.
        /// </summary>
        internal static string NoImage {
            get {
                return ResourceManager.GetString("NoImage", resourceCulture);
            }
        }
    }
}
