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
using System.Windows.Shapes;

namespace SportClub
{
    /// <summary>
    /// Логика взаимодействия для AbonementsTypeWindow.xaml
    /// </summary>
    public partial class AbonementsTypeWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private IEnumerable<AbonementsType> _AbonementsTypeList;

        public IEnumerable<AbonementsType> AbonementsTypeList
        {
            get
            {
                var Result = _AbonementsTypeList;

                if (SearchFilter != "")
                    Result = Result.Where(ai => ai.Abonement.IndexOf(SearchFilter, StringComparison.OrdinalIgnoreCase) >= 0);

                return Result.Skip((CurrentPage - 1) * 12).Take(12);
            }
            set
            {
                _AbonementsTypeList = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("AbonementsTypeList"));
                }
            }
        }

        public AbonementsTypeWindow()
        {
            InitializeComponent();
            DataContext = this;
            AbonementsTypeList = Core.DB.AbonementsType.ToArray();
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
                    if ((_AbonementsTypeList.Count() % 12) == 0)
                    {
                        if (value <= _AbonementsTypeList.Count() / 12)
                        {
                            _CurrentPage = value;
                            Invalidate();
                        }
                    }
                    else
                    {
                        if (value <= (_AbonementsTypeList.Count() / 12) + 1)
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
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("AbonementsTypeList"));
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
                    PropertyChanged(this, new PropertyChangedEventArgs("AbonementsTypeList"));
                }
            }
        }

        private void Invalidate()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AbonementsTypeList"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPage"));
        }

        private void AddWindow_Click(object sender, RoutedEventArgs e)
        {
            var addWin = new AddEditATWindow(new AbonementsType());
            if (addWin.ShowDialog() == true)
            {
                AbonementsTypeList = Core.DB.AbonementsType.ToArray();
            }
        }

        private void EditItem_Click(object sender, RoutedEventArgs e)
        {
            var editWin = new AddEditATWindow(AbonementsTypeListView.SelectedItem as AbonementsType);
            if (editWin.ShowDialog() == true)
            {
                AbonementsTypeList = Core.DB.AbonementsType.ToArray();
            }
        }

        private void DeleteItem_Click(object sender, RoutedEventArgs e)
        {
            var deleteAbonement = AbonementsTypeListView.SelectedItem as AbonementsType;
            try
            {
                Core.DB.AbonementsType.Remove(deleteAbonement);
                Core.DB.SaveChanges();

                MessageBox.Show($"Удалено");

                AbonementsTypeList = Core.DB.AbonementsType.ToArray();

                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("AbonementsTypeList"));
                }
            }
            catch { }
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
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

        private void StartWinButton_Click(object sender, RoutedEventArgs e)
        {
            var startWin = new StartWindow();
            startWin.Show();

            Close();
        }
    }
}