﻿#pragma checksum "C:\Users\marco\Desktop\LearnGuide\Homework\PRG\StudentApp\StudentApp\Login.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "EE51587E200BFBED18A51DE4D743E533"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentApp
{
    partial class Login : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Login.xaml line 14
                {
                    this.Mobile = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 3: // Login.xaml line 36
                {
                    this.GridView = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 4: // Login.xaml line 48
                {
                    this.loginStack = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 5: // Login.xaml line 49
                {
                    this.Username = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6: // Login.xaml line 50
                {
                    this.Password = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7: // Login.xaml line 51
                {
                    this.loginClick = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.loginClick).Click += this.Button_Click;
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

