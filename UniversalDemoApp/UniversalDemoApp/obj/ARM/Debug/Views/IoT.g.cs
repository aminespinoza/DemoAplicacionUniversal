﻿#pragma checksum "C:\Users\amines\documents\visual studio 2015\Projects\UniversalDemoApp\UniversalDemoApp\Views\IoT.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "141A12619F0FE23CB8FBC9B8DD0B0B1C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UniversalDemoApp.Views
{
    partial class IoT : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.btnBack = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 14 "..\..\..\Views\IoT.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnBack).Click += this.btnBack_Click;
                    #line default
                }
                break;
            case 2:
                {
                    this.btnLedsSecuence = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 15 "..\..\..\Views\IoT.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnLedsSecuence).Click += this.btnLedsSecuence_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

