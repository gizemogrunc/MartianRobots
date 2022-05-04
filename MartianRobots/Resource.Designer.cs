﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MartianRobots {
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
    internal class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MartianRobots.Resource", typeof(Resource).Assembly);
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
        ///   Looks up a localized string similar to Please values between 0 and your grid limits.
        /// </summary>
        internal static string ErrorRobotIndex {
            get {
                return ResourceManager.GetString("ErrorRobotIndex", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unrecognized command format please use  &apos;L&apos; or &apos;R&apos; or &apos;F&apos;.
        /// </summary>
        internal static string UnrecognizedCommand {
            get {
                return ResourceManager.GetString("UnrecognizedCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unrecognized grid size please use integer values between 0 and 50..
        /// </summary>
        internal static string UnrecognizedGridSize {
            get {
                return ResourceManager.GetString("UnrecognizedGridSize", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unrecognized robot direction please use &apos;W&apos; or &apos;E&apos; or &apos;S&apos; or &apos;N&apos;.
        /// </summary>
        internal static string UnrecognizedRobotDirection {
            get {
                return ResourceManager.GetString("UnrecognizedRobotDirection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unrecognized robot index please use integer values between 0 and 50..
        /// </summary>
        internal static string UnrecognizedRobotIndex {
            get {
                return ResourceManager.GetString("UnrecognizedRobotIndex", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exit.
        /// </summary>
        internal static string UserExitCommand {
            get {
                return ResourceManager.GetString("UserExitCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to To Finalize Type Exit.
        /// </summary>
        internal static string UserExitMessage {
            get {
                return ResourceManager.GetString("UserExitMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please write your  {0} st robot moves and Press Enter (e.g. RFRFRFRF) (to finish type Finish).
        /// </summary>
        internal static string UserInputCommand {
            get {
                return ResourceManager.GetString("UserInputCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please write upper-right coordinates of grid size and Press Enter (e.g. 5 3).
        /// </summary>
        internal static string UserInputGrid {
            get {
                return ResourceManager.GetString("UserInputGrid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please write your {0} st robot current situation and direction then Press Enter (e.g. 1 1 E) (to finish type Finish)&quot;.
        /// </summary>
        internal static string UserInputRobot {
            get {
                return ResourceManager.GetString("UserInputRobot", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Finish.
        /// </summary>
        internal static string UserRobotStateFinish {
            get {
                return ResourceManager.GetString("UserRobotStateFinish", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Thank you for your time.
        /// </summary>
        internal static string UserThanks {
            get {
                return ResourceManager.GetString("UserThanks", resourceCulture);
            }
        }
    }
}