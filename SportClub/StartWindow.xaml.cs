using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для StartWindow.xaml
    /// </summary>
    public partial class StartWindow : Window
    {
        public StartWindow()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void UsersButton_Click(object sender, RoutedEventArgs e)
        {
            var usersWin = new MainWindow();
            usersWin.Show();

            Close();
        }

        private void AbonementsButton_Click(object sender, RoutedEventArgs e)
        {
            var abonementsWin = new AbonementsTypeWindow();
            abonementsWin.Show();

            Close();
        }

        private void ExpertsButton_Click(object sender, RoutedEventArgs e)
        {
            var expertsWin = new ExpertsWindow();
            expertsWin.Show();

            Close();
        }
    }
}
