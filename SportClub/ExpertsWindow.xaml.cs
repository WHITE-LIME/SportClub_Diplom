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
    /// Логика взаимодействия для ExpertsWindow.xaml
    /// </summary>
    public partial class Experts
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
    public partial class ExpertsWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private IEnumerable<Experts> _ExpertsList;

        public IEnumerable<Experts> ExpertsList
        {
            get
            {
                var Result = _ExpertsList;

                if (SearchFilter != "")
                    Result = Result.Where(ai => ai.Expert.IndexOf(SearchFilter, StringComparison.OrdinalIgnoreCase) >= 0);

                return Result.Skip((CurrentPage - 1) * 6).Take(6);
            }
            set
            {
                _ExpertsList = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("ExpertsList"));
                }
            }
        }

        public ExpertsWindow()
        {
            InitializeComponent();
            DataContext = this;
            ExpertsList = Core.DB.Experts.ToArray();
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
                    if ((_ExpertsList.Count() % 6) == 0)
                    {
                        if (value <= _ExpertsList.Count() / 6)
                        {
                            _CurrentPage = value;
                            Invalidate();
                        }
                    }
                    else
                    {
                        if (value <= (_ExpertsList.Count() / 6) + 1)
                        {
                            _CurrentPage = value;
                            Invalidate();
                        }
                    }
                }
            }
        }

        private int _ExpertsListValue = 0;
        public int ExpertsListValue
        {
            get
            {
                return _ExpertsListValue;
            }
            set
            {
                _ExpertsListValue = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("ExpertsList"));
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
                    PropertyChanged(this, new PropertyChangedEventArgs("ExpertsList"));
                }
            }
        }

        private void Invalidate()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ExpertsList"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPage"));
        }

        private void AddWindow_Click(object sender, RoutedEventArgs e)
        {
            var addWin = new AddEditExpertWindow(new Experts());
            if (addWin.ShowDialog() == true)
            {
                ExpertsList = Core.DB.Experts.ToArray();
            }
        }

        private void EditItem_Click(object sender, RoutedEventArgs e)
        {
            var editWin = new AddEditExpertWindow(ExpertsListView.SelectedItem as Experts);
            if (editWin.ShowDialog() == true)
            {
                ExpertsList = Core.DB.Experts.ToArray();
            }
        }

        private void DeleteItem_Click(object sender, RoutedEventArgs e)
        {
            var deleteExpert = ExpertsListView.SelectedItem as Experts;
            try
            {
                Core.DB.Experts.Remove(deleteExpert);
                Core.DB.SaveChanges();

                MessageBox.Show($"Удалено");

                ExpertsList = Core.DB.Experts.ToArray();

                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("ExpertsList"));
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