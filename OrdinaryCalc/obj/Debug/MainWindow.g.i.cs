﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6C064FA0084BD094923DA41F2E3EE60718D62D1539E7C14F157B0BF81A980EAD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using OrdinaryCalc;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace OrdinaryCalc {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid ToolBar;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Minimaze;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image CloseMW;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CountTextBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/OrdinaryCalc;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ToolBar = ((System.Windows.Controls.Grid)(target));
            
            #line 30 "..\..\MainWindow.xaml"
            this.ToolBar.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ToolBar_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Minimaze = ((System.Windows.Controls.Image)(target));
            
            #line 35 "..\..\MainWindow.xaml"
            this.Minimaze.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Minimaze_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.CloseMW = ((System.Windows.Controls.Image)(target));
            
            #line 48 "..\..\MainWindow.xaml"
            this.CloseMW.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Close_MouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.CountTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 79 "..\..\MainWindow.xaml"
            this.CountTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 94 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_ClickClear);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 100 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_change);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 106 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_percentage);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 112 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_divide);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 123 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_7);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 128 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_8);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 133 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_9);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 138 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_multiply);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 150 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_4);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 155 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_5);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 160 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_6);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 165 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_subtract);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 177 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 18:
            
            #line 182 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 19:
            
            #line 187 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_3);
            
            #line default
            #line hidden
            return;
            case 20:
            
            #line 192 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_add);
            
            #line default
            #line hidden
            return;
            case 21:
            
            #line 204 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_0);
            
            #line default
            #line hidden
            return;
            case 22:
            
            #line 209 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_comma);
            
            #line default
            #line hidden
            return;
            case 23:
            
            #line 214 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_equal);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

