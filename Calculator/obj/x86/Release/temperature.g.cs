﻿#pragma checksum "C:\Users\hp\Documents\GitHub\Calculator\Calculator\temperature.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F6D837E32E4B872531B6BBED5C92013D2D59CBC12AA20F9DE7198BBF8F2EB2C2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App1
{
    partial class temperature : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // temperature.xaml line 25
                {
                    this.output = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3: // temperature.xaml line 20
                {
                    this.convselect = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.convselect).SelectionChanged += this.ConverterChanged;
                }
                break;
            case 4: // temperature.xaml line 16
                {
                    this.input = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.input).BeforeTextChanging += this.TextBox_OnBeforeTextChanging;
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.input).TextChanging += this.TextBox_OnTextChanging;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
