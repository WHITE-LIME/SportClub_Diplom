#pragma checksum "..\..\UsersWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F151AE379CE63593AB5B3B96329F7584A5F1E75FA7A2D95D7B34CE94ADC70CA3"
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
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\UsersWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddButton;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\UsersWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox AbonementsTypeListComboBox;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\UsersWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchFilterTextBox;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\UsersWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ExitButton;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\UsersWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button StartWinButton;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\UsersWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PrevPage;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\UsersWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NextPage;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\UsersWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView UsersListView;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\UsersWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem EditItem;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\UsersWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem ReportItem;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\UsersWindow.xaml"
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
            System.Uri resourceLocater = new System.Uri("/SportClub;component/userswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UsersWindow.xaml"
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
            
            #line 23 "..\..\UsersWindow.xaml"
            this.AddButton.Click += new System.Windows.RoutedEventHandler(this.AddWindow_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.AbonementsTypeListComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 30 "..\..\UsersWindow.xaml"
            this.AbonementsTypeListComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.AbonementsTypeList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 39 "..\..\UsersWindow.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.RadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 40 "..\..\UsersWindow.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.RadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.SearchFilterTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 42 "..\..\UsersWindow.xaml"
            this.SearchFilterTextBox.KeyUp += new System.Windows.Input.KeyEventHandler(this.SearchFilterTextBox_KeyUp);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ExitButton = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\UsersWindow.xaml"
            this.ExitButton.Click += new System.Windows.RoutedEventHandler(this.ExitButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.StartWinButton = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\UsersWindow.xaml"
            this.StartWinButton.Click += new System.Windows.RoutedEventHandler(this.StartWinButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.PrevPage = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\UsersWindow.xaml"
            this.PrevPage.Click += new System.Windows.RoutedEventHandler(this.PrevPage_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.NextPage = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\UsersWindow.xaml"
            this.NextPage.Click += new System.Windows.RoutedEventHandler(this.NextPage_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.UsersListView = ((System.Windows.Controls.ListView)(target));
            return;
            case 11:
            this.EditItem = ((System.Windows.Controls.MenuItem)(target));
            
            #line 70 "..\..\UsersWindow.xaml"
            this.EditItem.Click += new System.Windows.RoutedEventHandler(this.EditItem_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.ReportItem = ((System.Windows.Controls.MenuItem)(target));
            
            #line 71 "..\..\UsersWindow.xaml"
            this.ReportItem.Click += new System.Windows.RoutedEventHandler(this.ReportItem_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.DeleteItem = ((System.Windows.Controls.MenuItem)(target));
            
            #line 72 "..\..\UsersWindow.xaml"
            this.DeleteItem.Click += new System.Windows.RoutedEventHandler(this.DeleteItem_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

