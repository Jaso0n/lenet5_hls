﻿#pragma checksum "C:\Users\woobes\documents\visual studio 2017\Projects\LeNet5 Test\LeNet5 Test\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CC36E60C66CC437AC032CF9DDDF92318"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LeNet5_Test
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
                    this.topView = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 2:
                {
                    global::Windows.UI.Xaml.Controls.Button element2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 11 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element2).Click += this.OnOpenImageButtonClicked;
                    #line default
                }
                break;
            case 3:
                {
                    this.imageView = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 4:
                {
                    this.rect = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                    #line 16 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Shapes.Rectangle)this.rect).PointerMoved += this.OnRectPointerMoved;
                    #line default
                }
                break;
            case 5:
                {
                    this.img_cropped = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 6:
                {
                    this.grayImage = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 7:
                {
                    this.explanationText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8:
                {
                    this.resultText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9:
                {
                    this.percentText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10:
                {
                    this.tbIP = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 11:
                {
                    this.tbPort = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 12:
                {
                    this.ConnectButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 27 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.ConnectButton).Click += this.OnConnectButtonClicked;
                    #line default
                }
                break;
            case 13:
                {
                    global::Windows.UI.Xaml.Controls.Button element13 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 28 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element13).Click += this.OnTerminateButtonClicked;
                    #line default
                }
                break;
            case 14:
                {
                    this.img_total = (global::Windows.UI.Xaml.Controls.Image)(target);
                    #line 13 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Image)this.img_total).PointerMoved += this.OnImagePointerMoved;
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

