﻿#pragma checksum "..\..\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E329EAD709EBB8A430273F777E43871C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
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


namespace Lab4_2 {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas MainGrid;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle redRect;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle blueRect;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle greenRect;
        
        #line default
        #line hidden
        
        
        #line 217 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image norrbotten;
        
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
            System.Uri resourceLocater = new System.Uri("/Lab4_2;component/mainwindow.xaml", System.UriKind.Relative);
            
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
            
            #line 7 "..\..\MainWindow.xaml"
            ((Lab4_2.MainWindow)(target)).ManipulationStarting += new System.EventHandler<System.Windows.Input.ManipulationStartingEventArgs>(this.Window_ManipulationStarting);
            
            #line default
            #line hidden
            
            #line 8 "..\..\MainWindow.xaml"
            ((Lab4_2.MainWindow)(target)).ManipulationDelta += new System.EventHandler<System.Windows.Input.ManipulationDeltaEventArgs>(this.Window_ManipulationDelta);
            
            #line default
            #line hidden
            
            #line 9 "..\..\MainWindow.xaml"
            ((Lab4_2.MainWindow)(target)).ManipulationInertiaStarting += new System.EventHandler<System.Windows.Input.ManipulationInertiaStartingEventArgs>(this.Window_InertiaStarting);
            
            #line default
            #line hidden
            return;
            case 2:
            this.MainGrid = ((System.Windows.Controls.Canvas)(target));
            return;
            case 3:
            this.redRect = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 4:
            this.blueRect = ((System.Windows.Shapes.Rectangle)(target));
            
            #line 24 "..\..\MainWindow.xaml"
            this.blueRect.TouchDown += new System.EventHandler<System.Windows.Input.TouchEventArgs>(this.Rectangle_TouchDown);
            
            #line default
            #line hidden
            
            #line 24 "..\..\MainWindow.xaml"
            this.blueRect.TouchMove += new System.EventHandler<System.Windows.Input.TouchEventArgs>(this.Rectangle_TouchMove);
            
            #line default
            #line hidden
            
            #line 24 "..\..\MainWindow.xaml"
            this.blueRect.TouchUp += new System.EventHandler<System.Windows.Input.TouchEventArgs>(this.Rectangle_TouchUp);
            
            #line default
            #line hidden
            return;
            case 5:
            this.greenRect = ((System.Windows.Shapes.Rectangle)(target));
            
            #line 25 "..\..\MainWindow.xaml"
            this.greenRect.TouchDown += new System.EventHandler<System.Windows.Input.TouchEventArgs>(this.Rectangle_TouchDown);
            
            #line default
            #line hidden
            
            #line 25 "..\..\MainWindow.xaml"
            this.greenRect.TouchMove += new System.EventHandler<System.Windows.Input.TouchEventArgs>(this.Rectangle_TouchMove);
            
            #line default
            #line hidden
            
            #line 25 "..\..\MainWindow.xaml"
            this.greenRect.TouchUp += new System.EventHandler<System.Windows.Input.TouchEventArgs>(this.Rectangle_TouchUp);
            
            #line default
            #line hidden
            return;
            case 6:
            this.norrbotten = ((System.Windows.Controls.Image)(target));
            
            #line 217 "..\..\MainWindow.xaml"
            this.norrbotten.TouchDown += new System.EventHandler<System.Windows.Input.TouchEventArgs>(this.Rectangle_TouchDown);
            
            #line default
            #line hidden
            
            #line 217 "..\..\MainWindow.xaml"
            this.norrbotten.TouchMove += new System.EventHandler<System.Windows.Input.TouchEventArgs>(this.Rectangle_TouchMove);
            
            #line default
            #line hidden
            
            #line 217 "..\..\MainWindow.xaml"
            this.norrbotten.TouchUp += new System.EventHandler<System.Windows.Input.TouchEventArgs>(this.Rectangle_TouchUp);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

