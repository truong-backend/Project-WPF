﻿#pragma checksum "..\..\..\..\UI\WindowHocVien.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D3489A0115C0E5241DBD8CEC6376978CA41A3E9C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using buoi3.MyModels;
using buoi3.UI;


namespace buoi3.UI {
    
    
    /// <summary>
    /// WindowHocVien
    /// </summary>
    public partial class WindowHocVien : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\..\UI\WindowHocVien.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Input.CommandBinding them;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\UI\WindowHocVien.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Input.CommandBinding xoa;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\UI\WindowHocVien.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Input.CommandBinding sua;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\UI\WindowHocVien.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridHocVien;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\UI\WindowHocVien.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmMalop;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\..\UI\WindowHocVien.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgHocVien;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/buoi3;V1.0.0.0;component/ui/windowhocvien.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\UI\WindowHocVien.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 9 "..\..\..\..\UI\WindowHocVien.xaml"
            ((buoi3.UI.WindowHocVien)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.them = ((System.Windows.Input.CommandBinding)(target));
            
            #line 12 "..\..\..\..\UI\WindowHocVien.xaml"
            this.them.Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.them_Executed);
            
            #line default
            #line hidden
            
            #line 12 "..\..\..\..\UI\WindowHocVien.xaml"
            this.them.CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.them_CanExecute);
            
            #line default
            #line hidden
            return;
            case 3:
            this.xoa = ((System.Windows.Input.CommandBinding)(target));
            
            #line 13 "..\..\..\..\UI\WindowHocVien.xaml"
            this.xoa.Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.xoa_Executed);
            
            #line default
            #line hidden
            
            #line 13 "..\..\..\..\UI\WindowHocVien.xaml"
            this.xoa.CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.xoa_CanExecute);
            
            #line default
            #line hidden
            return;
            case 4:
            this.sua = ((System.Windows.Input.CommandBinding)(target));
            
            #line 14 "..\..\..\..\UI\WindowHocVien.xaml"
            this.sua.Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.sua_Executed);
            
            #line default
            #line hidden
            
            #line 14 "..\..\..\..\UI\WindowHocVien.xaml"
            this.sua.CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.sua_CanExecute);
            
            #line default
            #line hidden
            return;
            case 5:
            this.gridHocVien = ((System.Windows.Controls.Grid)(target));
            return;
            case 6:
            this.cmMalop = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.dgHocVien = ((System.Windows.Controls.DataGrid)(target));
            
            #line 66 "..\..\..\..\UI\WindowHocVien.xaml"
            this.dgHocVien.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dgHocVien_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

