﻿#pragma checksum "C:\Users\Admin\Documents\Visual Studio 2017\Projects\WebApplication1\Client\View\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3C85F06DD40479D99C54DE10021225D3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.View
{
    partial class MainPage : 
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
                    this.MainSplitView = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 2:
                {
                    this.HamburgerButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 15 "..\..\..\View\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.HamburgerButton).Click += this.HamburgerButton_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.BtnParameters = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 4:
                {
                    this.BtnAccount = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 5:
                {
                    this.BtnMovies = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 6:
                {
                    this.BtnHome = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 7:
                {
                    this.BtnPrevious = (global::Windows.UI.Xaml.Controls.Button)(target);
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

