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
    /// Логика взаимодействия для AddEditWindow.xaml
    /// </summary>
    public partial class AddEditWindow : Window
    {
        public Users AllUsers { get; set; }

        public List<AbonementsType> AbonementsTypeSelect { get; set; }

        public List<Experts> ExpertsSelect { get; set; }

        public AddEditWindow(Users users)
        {
            InitializeComponent();
            DataContext = this;
            AllUsers = users;
            AbonementsTypeSelect = Core.DB.AbonementsType.ToList();
            ExpertsSelect = Core.DB.Experts.ToList();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (AllUsers.AbonementsType == null)
                    throw new Exception("Не выбран тип абонемента");

                if (AllUsers.Experts == null)
                    throw new Exception("Не выбран эксперт");

                if (AllUsers.ID == 0)
                    Core.DB.Users.Add(AllUsers);

                Core.DB.SaveChanges();

                DialogResult = true;

                MessageBox.Show($"Сохранено");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
