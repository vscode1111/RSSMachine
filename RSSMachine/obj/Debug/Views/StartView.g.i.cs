﻿#pragma checksum "..\..\..\Views\StartView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "355088904485CD4789FB47B5180533F8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using RSSMachine;
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


namespace RSSMachine {
    
    
    /// <summary>
    /// StartView
    /// </summary>
    public partial class StartView : RSSMachine.ViewBase, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\Views\StartView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid myGrid;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Views\StartView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement GIF;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Views\StartView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal RSSMachine.UpdateControl updGIF;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Views\StartView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnStart;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Views\StartView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnStop;
        
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
            System.Uri resourceLocater = new System.Uri("/RSSMachine;component/views/startview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\StartView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.myGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.GIF = ((System.Windows.Controls.MediaElement)(target));
            
            #line 17 "..\..\..\Views\StartView.xaml"
            this.GIF.MediaEnded += new System.Windows.RoutedEventHandler(this.GIF_MediaEnded);
            
            #line default
            #line hidden
            
            #line 17 "..\..\..\Views\StartView.xaml"
            this.GIF.MediaOpened += new System.Windows.RoutedEventHandler(this.GIF_MediaOpened);
            
            #line default
            #line hidden
            return;
            case 3:
            this.updGIF = ((RSSMachine.UpdateControl)(target));
            return;
            case 4:
            this.btnStart = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\Views\StartView.xaml"
            this.btnStart.Click += new System.Windows.RoutedEventHandler(this.btnStart_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnStop = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\Views\StartView.xaml"
            this.btnStop.Click += new System.Windows.RoutedEventHandler(this.btnStop_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

