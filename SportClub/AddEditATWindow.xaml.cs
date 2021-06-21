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
    /// Логика взаимодействия для AddEditATWindow.xaml
    /// </summary>
    public partial class AddEditATWindow : Window
    {
        public AbonementsType AllAbonementsType { get; set; }
        public AddEditATWindow(AbonementsType abonementsType)
        {
            InitializeComponent();
            DataContext = this;
            AllAbonementsType = abonementsType;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (AllAbonementsType.Abonement == null)
                    throw new Exception("Не выбран тип абонемента");

                if (AllAbonementsType.ID == 0)
                    Core.DB.AbonementsType.Add(AllAbonementsType);

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
            this.Close();
        }
    }
}
