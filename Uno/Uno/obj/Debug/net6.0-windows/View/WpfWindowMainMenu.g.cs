﻿#pragma checksum "..\..\..\..\View\WpfWindowMainMenu.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36CCE0D17FBD7211F662C3FDC628C8D97870040A"
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
using Uno;


namespace Uno {
    
    
    /// <summary>
    /// WpfWindowMainMenu
    /// </summary>
    public partial class WpfWindowMainMenu : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\..\..\View\WpfWindowMainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonNewGame;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\View\WpfWindowMainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonLoadGame;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\View\WpfWindowMainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonSaveGame;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\View\WpfWindowMainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonCurrentGame;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\View\WpfWindowMainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imageUnoBack;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\View\WpfWindowMainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonNewTournament;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\View\WpfWindowMainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonLoadTournament;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\View\WpfWindowMainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonSaveTournament;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\View\WpfWindowMainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonExitGame;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Uno;component/view/wpfwindowmainmenu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\WpfWindowMainMenu.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 7 "..\..\..\..\View\WpfWindowMainMenu.xaml"
            ((Uno.WpfWindowMainMenu)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.DataWindow_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ButtonNewGame = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\..\View\WpfWindowMainMenu.xaml"
            this.ButtonNewGame.Click += new System.Windows.RoutedEventHandler(this.ButtonNewGame_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ButtonLoadGame = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\..\View\WpfWindowMainMenu.xaml"
            this.ButtonLoadGame.Click += new System.Windows.RoutedEventHandler(this.ButtonLoadGame_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ButtonSaveGame = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\..\View\WpfWindowMainMenu.xaml"
            this.ButtonSaveGame.Click += new System.Windows.RoutedEventHandler(this.ButtonSaveGame_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ButtonCurrentGame = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\..\View\WpfWindowMainMenu.xaml"
            this.ButtonCurrentGame.Click += new System.Windows.RoutedEventHandler(this.ButtonCurrentGame_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.imageUnoBack = ((System.Windows.Controls.Image)(target));
            return;
            case 7:
            this.ButtonNewTournament = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\..\View\WpfWindowMainMenu.xaml"
            this.ButtonNewTournament.Click += new System.Windows.RoutedEventHandler(this.ButtonNewTournament_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ButtonLoadTournament = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\..\View\WpfWindowMainMenu.xaml"
            this.ButtonLoadTournament.Click += new System.Windows.RoutedEventHandler(this.ButtonLoadTournament_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ButtonSaveTournament = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\..\View\WpfWindowMainMenu.xaml"
            this.ButtonSaveTournament.Click += new System.Windows.RoutedEventHandler(this.ButtonSaveTournament_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.ButtonExitGame = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\..\View\WpfWindowMainMenu.xaml"
            this.ButtonExitGame.Click += new System.Windows.RoutedEventHandler(this.ButtonExitGame_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
