﻿#pragma checksum "..\..\..\..\View\WpfWindowFinalScore.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "271ACC5E2CC3AD7C7F5CEA1AFA1DC0A44D70853D"
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
using Uno.View;


namespace Uno.View {
    
    
    /// <summary>
    /// WpfWindowFinalScore
    /// </summary>
    public partial class WpfWindowFinalScore : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\..\View\WpfWindowFinalScore.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelPlayerName;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\View\WpfWindowFinalScore.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelScore;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\View\WpfWindowFinalScore.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonMainMenu;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\View\WpfWindowFinalScore.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonTournament;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Uno;component/view/wpfwindowfinalscore.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\WpfWindowFinalScore.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.labelPlayerName = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.labelScore = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.buttonMainMenu = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\..\View\WpfWindowFinalScore.xaml"
            this.buttonMainMenu.Click += new System.Windows.RoutedEventHandler(this.buttonMainMenu_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.buttonTournament = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\..\View\WpfWindowFinalScore.xaml"
            this.buttonTournament.Click += new System.Windows.RoutedEventHandler(this.buttonTournament_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

