﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "54E44AA460B6E2ABF83633630A940CD1A26515799318F95CF570DF2F463706C1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Diagnostics;
using System.IO.Ports;
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
using Utilities_Tool;
using Xceed.Wpf.Toolkit;
using Xceed.Wpf.Toolkit.Chromes;
using Xceed.Wpf.Toolkit.Converters;
using Xceed.Wpf.Toolkit.Core;
using Xceed.Wpf.Toolkit.Core.Converters;
using Xceed.Wpf.Toolkit.Core.Input;
using Xceed.Wpf.Toolkit.Core.Media;
using Xceed.Wpf.Toolkit.Core.Utilities;
using Xceed.Wpf.Toolkit.Mag.Converters;
using Xceed.Wpf.Toolkit.Panels;
using Xceed.Wpf.Toolkit.Primitives;
using Xceed.Wpf.Toolkit.PropertyGrid;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;
using Xceed.Wpf.Toolkit.PropertyGrid.Commands;
using Xceed.Wpf.Toolkit.PropertyGrid.Converters;
using Xceed.Wpf.Toolkit.PropertyGrid.Editors;
using Xceed.Wpf.Toolkit.Zoombox;


namespace Utilities_Tool {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Grid_Form;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btConnect;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Title_Form;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbSerialPort;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbBaudrate;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbParity;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbStopBit;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.IntegerUpDown numACSII;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btAdd_ACSII;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btAdd_STX;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btAdd_ETX;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btClear;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDataSend;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btSend;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDataReceived;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btSR1000_ON;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btSR1000_OFF;
        
        #line default
        #line hidden
        
        
        #line 126 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btSR1000_Focus;
        
        #line default
        #line hidden
        
        
        #line 138 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton ckbUsing_Plus725;
        
        #line default
        #line hidden
        
        
        #line 139 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lbUse_Plus725;
        
        #line default
        #line hidden
        
        
        #line 160 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse Signal_IN_0;
        
        #line default
        #line hidden
        
        
        #line 168 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse Signal_IN_1;
        
        #line default
        #line hidden
        
        
        #line 176 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse Signal_IN_2;
        
        #line default
        #line hidden
        
        
        #line 184 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse Signal_IN_3;
        
        #line default
        #line hidden
        
        
        #line 192 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse Signal_IN_4;
        
        #line default
        #line hidden
        
        
        #line 200 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse Signal_IN_5;
        
        #line default
        #line hidden
        
        
        #line 218 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ckbW0;
        
        #line default
        #line hidden
        
        
        #line 227 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ckbW1;
        
        #line default
        #line hidden
        
        
        #line 236 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ckbW2;
        
        #line default
        #line hidden
        
        
        #line 245 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ckbW3;
        
        #line default
        #line hidden
        
        
        #line 254 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ckbW_Off;
        
        #line default
        #line hidden
        
        
        #line 259 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton ckb_timer_Plus725;
        
        #line default
        #line hidden
        
        
        #line 260 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.IntegerUpDown numTimer;
        
        #line default
        #line hidden
        
        
        #line 271 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btExtend_Grid;
        
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
            System.Uri resourceLocater = new System.Uri("/Utilities Tool;component/mainwindow.xaml", System.UriKind.Relative);
            
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
            this.Grid_Form = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            
            #line 28 "..\..\MainWindow.xaml"
            ((MaterialDesignThemes.Wpf.PackIcon)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Border_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 29 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Image)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.Closed_Form);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 30 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Image)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.Minized_Form);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btConnect = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\MainWindow.xaml"
            this.btConnect.Click += new System.Windows.RoutedEventHandler(this.btConnect_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 32 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Border_MouseDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Title_Form = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.cbSerialPort = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.cbBaudrate = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 10:
            this.cbParity = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 11:
            this.cbStopBit = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 12:
            this.numACSII = ((Xceed.Wpf.Toolkit.IntegerUpDown)(target));
            return;
            case 13:
            this.btAdd_ACSII = ((System.Windows.Controls.Button)(target));
            
            #line 84 "..\..\MainWindow.xaml"
            this.btAdd_ACSII.Click += new System.Windows.RoutedEventHandler(this.btAdd_ACSII_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.btAdd_STX = ((System.Windows.Controls.Button)(target));
            
            #line 85 "..\..\MainWindow.xaml"
            this.btAdd_STX.Click += new System.Windows.RoutedEventHandler(this.btAdd_STX_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            this.btAdd_ETX = ((System.Windows.Controls.Button)(target));
            
            #line 86 "..\..\MainWindow.xaml"
            this.btAdd_ETX.Click += new System.Windows.RoutedEventHandler(this.btAdd_ETX_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            this.btClear = ((System.Windows.Controls.Button)(target));
            
            #line 87 "..\..\MainWindow.xaml"
            this.btClear.Click += new System.Windows.RoutedEventHandler(this.btClear_Click);
            
            #line default
            #line hidden
            return;
            case 17:
            this.txtDataSend = ((System.Windows.Controls.TextBox)(target));
            
            #line 92 "..\..\MainWindow.xaml"
            this.txtDataSend.KeyDown += new System.Windows.Input.KeyEventHandler(this.txtDataSend_KeyDown);
            
            #line default
            #line hidden
            return;
            case 18:
            this.btSend = ((System.Windows.Controls.Button)(target));
            
            #line 93 "..\..\MainWindow.xaml"
            this.btSend.Click += new System.Windows.RoutedEventHandler(this.btSend_Click);
            
            #line default
            #line hidden
            return;
            case 19:
            this.txtDataReceived = ((System.Windows.Controls.TextBox)(target));
            return;
            case 20:
            this.btSR1000_ON = ((System.Windows.Controls.Button)(target));
            
            #line 124 "..\..\MainWindow.xaml"
            this.btSR1000_ON.Click += new System.Windows.RoutedEventHandler(this.btSR1000_ON_Click);
            
            #line default
            #line hidden
            return;
            case 21:
            this.btSR1000_OFF = ((System.Windows.Controls.Button)(target));
            
            #line 125 "..\..\MainWindow.xaml"
            this.btSR1000_OFF.Click += new System.Windows.RoutedEventHandler(this.btSR1000_OFF_Click);
            
            #line default
            #line hidden
            return;
            case 22:
            this.btSR1000_Focus = ((System.Windows.Controls.Button)(target));
            
            #line 126 "..\..\MainWindow.xaml"
            this.btSR1000_Focus.Click += new System.Windows.RoutedEventHandler(this.btSR1000_Focus_Click);
            
            #line default
            #line hidden
            return;
            case 23:
            this.ckbUsing_Plus725 = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 138 "..\..\MainWindow.xaml"
            this.ckbUsing_Plus725.Checked += new System.Windows.RoutedEventHandler(this.ckbUsing_Plus725_CheckChanged);
            
            #line default
            #line hidden
            
            #line 138 "..\..\MainWindow.xaml"
            this.ckbUsing_Plus725.Unchecked += new System.Windows.RoutedEventHandler(this.ckbUsing_Plus725_CheckChanged);
            
            #line default
            #line hidden
            return;
            case 24:
            this.lbUse_Plus725 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 25:
            this.Signal_IN_0 = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 26:
            this.Signal_IN_1 = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 27:
            this.Signal_IN_2 = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 28:
            this.Signal_IN_3 = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 29:
            this.Signal_IN_4 = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 30:
            this.Signal_IN_5 = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 31:
            this.ckbW0 = ((System.Windows.Controls.CheckBox)(target));
            
            #line 218 "..\..\MainWindow.xaml"
            this.ckbW0.Checked += new System.Windows.RoutedEventHandler(this.ckbW0_CheckChanged);
            
            #line default
            #line hidden
            
            #line 218 "..\..\MainWindow.xaml"
            this.ckbW0.Unchecked += new System.Windows.RoutedEventHandler(this.ckbW0_CheckChanged);
            
            #line default
            #line hidden
            return;
            case 32:
            this.ckbW1 = ((System.Windows.Controls.CheckBox)(target));
            
            #line 227 "..\..\MainWindow.xaml"
            this.ckbW1.Checked += new System.Windows.RoutedEventHandler(this.ckbW1_CheckChange);
            
            #line default
            #line hidden
            
            #line 227 "..\..\MainWindow.xaml"
            this.ckbW1.Unchecked += new System.Windows.RoutedEventHandler(this.ckbW1_CheckChange);
            
            #line default
            #line hidden
            return;
            case 33:
            this.ckbW2 = ((System.Windows.Controls.CheckBox)(target));
            
            #line 236 "..\..\MainWindow.xaml"
            this.ckbW2.Checked += new System.Windows.RoutedEventHandler(this.ckbW2_CheckChanged);
            
            #line default
            #line hidden
            
            #line 236 "..\..\MainWindow.xaml"
            this.ckbW2.Unchecked += new System.Windows.RoutedEventHandler(this.ckbW2_CheckChanged);
            
            #line default
            #line hidden
            return;
            case 34:
            this.ckbW3 = ((System.Windows.Controls.CheckBox)(target));
            
            #line 245 "..\..\MainWindow.xaml"
            this.ckbW3.Checked += new System.Windows.RoutedEventHandler(this.ckbW3_CheckChanged);
            
            #line default
            #line hidden
            
            #line 245 "..\..\MainWindow.xaml"
            this.ckbW3.Unchecked += new System.Windows.RoutedEventHandler(this.ckbW3_CheckChanged);
            
            #line default
            #line hidden
            return;
            case 35:
            this.ckbW_Off = ((System.Windows.Controls.CheckBox)(target));
            
            #line 254 "..\..\MainWindow.xaml"
            this.ckbW_Off.Checked += new System.Windows.RoutedEventHandler(this.ckbW_Off_CheckChanged);
            
            #line default
            #line hidden
            
            #line 254 "..\..\MainWindow.xaml"
            this.ckbW_Off.Unchecked += new System.Windows.RoutedEventHandler(this.ckbW_Off_CheckChanged);
            
            #line default
            #line hidden
            return;
            case 36:
            this.ckb_timer_Plus725 = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 259 "..\..\MainWindow.xaml"
            this.ckb_timer_Plus725.Click += new System.Windows.RoutedEventHandler(this.ckb_timer_Plus725_Click);
            
            #line default
            #line hidden
            return;
            case 37:
            this.numTimer = ((Xceed.Wpf.Toolkit.IntegerUpDown)(target));
            return;
            case 38:
            this.btExtend_Grid = ((System.Windows.Controls.Button)(target));
            
            #line 271 "..\..\MainWindow.xaml"
            this.btExtend_Grid.Click += new System.Windows.RoutedEventHandler(this.btExtend_Grid_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
