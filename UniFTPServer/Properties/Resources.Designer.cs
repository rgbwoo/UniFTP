﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18444
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace UniFTPServer.Properties {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
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
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("UniFTPServer.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   使用此强类型资源类，为所有资源查找
        ///   重写当前线程的 CurrentUICulture 属性。
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
        ///   查找类似 &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt;
        ///&lt;log4net&gt;
        ///  &lt;appender name=&quot;BufferingForwardingAppender&quot; type=&quot;log4net.Appender.BufferingForwardingAppender&quot; &gt;
        ///    &lt;bufferSize value=&quot;2&quot;/&gt;
        ///    &lt;appender-ref ref=&quot;Console&quot; /&gt;
        ///    &lt;appender-ref ref=&quot;RollingFileAppender&quot; /&gt;
        ///    &lt;appender-ref ref=&quot;ErrorFileAppender&quot; /&gt;
        ///  &lt;/appender&gt;
        ///
        ///  &lt;appender name=&quot;Console&quot; type=&quot;log4net.Appender.ConsoleAppender&quot;&gt;
        ///    &lt;filter type=&quot;log4net.Filter.LevelRangeFilter&quot;&gt;
        ///      &lt;levelMin value=&quot;FATAL&quot; /&gt;
        ///      &lt;levelMax value=&quot;FAT [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string LogConfig {
            get {
                return ResourceManager.GetString("LogConfig", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap Pause {
            get {
                object obj = ResourceManager.GetObject("Pause", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap Start {
            get {
                object obj = ResourceManager.GetObject("Start", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap Stop {
            get {
                object obj = ResourceManager.GetObject("Stop", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}
