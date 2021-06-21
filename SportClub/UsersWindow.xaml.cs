using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SportClub
{

    public partial class Users
    {
        public Uri PhotoView
        {
            get
            {
                var PhotoName = Environment.CurrentDirectory + Photo ?? "";
                return System.IO.File.Exists(PhotoName) ? new Uri(PhotoName) : new Uri("pack://application:,,,/img/NoPhoto.png");
            }
        }
    }

    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private IEnumerable<Users> _UsersList;

        public IEnumerable<Users> UsersList
        {
            get
            {
                var Result = _UsersList;

                if (_AbonementsTypeListValue > 0)
                    Result = Result.Where(ai => ai.AbonementID == _AbonementsTypeListValue);

                if (SearchFilter != "")
                    Result = Result.Where(ai => ai.FullName.IndexOf(SearchFilter, StringComparison.OrdinalIgnoreCase) >= 0);

                if (SortList) Result = Result.OrderBy(ai => ai.PriceOfAbonement);
                else Result = Result.OrderByDescending(ai => ai.PriceOfAbonement);

                return Result.Skip((CurrentPage - 1) * 6).Take(6);
            }
            set
            {
                _UsersList = value;
                if(PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("UsersList"));
                }
            }
        }

        public List<AbonementsType> AbonementsTypeList { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            UsersList = Core.DB.Users.ToArray();
            AbonementsTypeList = Core.DB.AbonementsType.ToList();
            AbonementsTypeList.Insert(0, new AbonementsType { Abonement = "Все типы абонементов" });
        }

        private int _CurrentPage;
        public int CurrentPage
        {
            get
            {
                return _CurrentPage;
            }
            set
            {
                if (value > 0)
                {
                    if ((_UsersList.Count() % 6) == 0)
                    {
                        if (value <= _UsersList.Count() / 6)
                        {
                            _CurrentPage = value;
                            Invalidate();
                        }
                    }
                    else
                    {
                        if(value <= (_UsersList.Count() / 6 ) + 1 )
                        {
                            _CurrentPage = value;
                            Invalidate();
                        }
                    }
                }
            }
        }

        private int _AbonementsTypeListValue = 0;
        public int AbonementsTypeListValue
        {
            get
            {
                return _AbonementsTypeListValue;
            }
            set
            {
                _AbonementsTypeListValue = value;
                if(PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("UsersList"));
                }
            }
        }

        private bool _SortList = true;
        public bool SortList
        {
            get
            {
                return _SortList;
            }
            set
            {
                _SortList = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("UsersList"));
                }
            }
        }

        private string _SearchFilter = "";
        public string SearchFilter
        {
            get
            {
                return _SearchFilter;
            }
            set
            {
                _SearchFilter = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("UsersList"));
                }
            }
        }

        private void Invalidate()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("UsersList"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPage"));
        }

        private void AddWindow_Click(object sender, RoutedEventArgs e)
        {
            var addWin = new AddEditWindow(new Users());
            if(addWin.ShowDialog() == true)
            {
                UsersList = Core.DB.Users.ToArray();
            }
        }

        private void EditItem_Click(object sender, RoutedEventArgs e)
        {
            var editWin = new AddEditWindow(UsersListView.SelectedItem as Users);
            if(editWin.ShowDialog() == true)
            {
                UsersList = Core.DB.Users.ToArray();
            }
        }

        private void DeleteItem_Click(object sender, RoutedEventArgs e)
        {
            var deleteUser = UsersListView.SelectedItem as Users;
            try
            {
                Core.DB.Users.Remove(deleteUser);
                Core.DB.SaveChanges();

                MessageBox.Show($"Удалено");

                UsersList = Core.DB.Users.ToArray();

                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("ProductList"));
                }
            }
            catch { }
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            SortList = (sender as RadioButton).Tag.ToString() == "1";
        }

        private void SearchFilterTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            SearchFilter = SearchFilterTextBox.Text;
            Invalidate();
        }
        private void PrevPage_Click(object sender, RoutedEventArgs e)
        {
            CurrentPage--;
        }

        private void NextPage_Click(object sender, RoutedEventArgs e)
        {
            CurrentPage++;
        }

        private void AbonementsTypeList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            AbonementsTypeListValue = (AbonementsTypeListComboBox.SelectedItem as AbonementsType).ID;
        }

        private void ReportItem_Click(object sender, RoutedEventArgs e)
        {
            var reportWin = new ReportWindow(UsersListView.SelectedItem as Users);
            if (reportWin.ShowDialog() == true)
            {
                UsersList = Core.DB.Users.ToArray();
            }
        }
        private void StartWinButton_Click(object sender, RoutedEventArgs e)
        {
            var startWin = new StartWindow();
            startWin.Show();

            Close();
        }
    }
}