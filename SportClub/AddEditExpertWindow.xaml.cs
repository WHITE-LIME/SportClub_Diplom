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
    /// Логика взаимодействия для AddEditExpertWindow.xaml
    /// </summary>
    public partial class AddEditExpertWindow : Window
    {
        public Experts AllExperts { get; set; }
        public AddEditExpertWindow(Experts experts)
        {
            InitializeComponent();
            DataContext = this;
            AllExperts = experts;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (AllExperts.Expert == null)
                    throw new Exception("Не введено ФИО эксперта");

                if (AllExperts.ID == 0)
                    Core.DB.Experts.Add(AllExperts);

                Core.DB.SaveChanges();

                DialogResult = true;

                MessageBox.Show($"Сохранено");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
