#pragma checksum "..\..\ExpertsWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "553993AFB977D73D20306A0B4E14152B9B907C6E749239B0A83FB23B62676A4F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using SportClub;
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


namespace SportClub {
    
    
    /// <summary>
    /// ExpertsWindow
    /// </summary>
    public partial class ExpertsWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\ExpertsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddButton;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\ExpertsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchFilterTextBox;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\ExpertsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ExitButton;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\ExpertsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button StartWinButton;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\ExpertsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PrevPage;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\ExpertsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NextPage;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\ExpertsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ExpertsListView;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\ExpertsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem EditItem;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\ExpertsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem DeleteItem;
        
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
            System.Uri resourceLocater = new System.Uri("/SportClub;component/expertswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ExpertsWindow.xaml"
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
            this.AddButton = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\ExpertsWindow.xaml"
            this.AddButton.Click += new System.Windows.RoutedEventHandler(this.AddWindow_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SearchFilterTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 24 "..\..\ExpertsWindow.xaml"
            this.SearchFilterTextBox.KeyUp += new System.Windows.Input.KeyEventHandler(this.SearchFilterTextBox_KeyUp);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ExitButton = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\ExpertsWindow.xaml"
            this.ExitButton.Click += new System.Windows.RoutedEventHandler(this.ExitButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.StartWinButton = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\ExpertsWindow.xaml"
            this.StartWinButton.Click += new System.Windows.RoutedEventHandler(this.StartWinButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.PrevPage = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\ExpertsWindow.xaml"
            this.PrevPage.Click += new System.Windows.RoutedEventHandler(this.PrevPage_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.NextPage = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\ExpertsWindow.xaml"
            this.NextPage.Click += new System.Windows.RoutedEventHandler(this.NextPage_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ExpertsListView = ((System.Windows.Controls.ListView)(target));
            return;
            case 8:
            this.EditItem = ((System.Windows.Controls.MenuItem)(target));
            
            #line 52 "..\..\ExpertsWindow.xaml"
            this.EditItem.Click += new System.Windows.RoutedEventHandler(this.EditItem_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.DeleteItem = ((System.Windows.Controls.MenuItem)(target));
            
            #line 53 "..\..\ExpertsWindow.xaml"
            this.DeleteItem.Click += new System.Windows.RoutedEventHandler(this.DeleteItem_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

