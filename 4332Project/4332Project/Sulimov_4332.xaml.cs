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

namespace _4332Project
{
    /// <summary>
    /// Логика взаимодействия для Sulimov_4332.xaml
    /// </summary>
    public partial class Sulimov_4332 : Window
    {
        public Sulimov_4332()
        {
            InitializeComponent();
        }
        private void SulimovButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Имя: Арсений\nВозраст: 18 лет");
        }

        private void ShowAuthorInfo_Click(object sender, RoutedEventArgs e)
        {
            var newForm = new Sulimov_4332(); 
            newForm.Show(); 
        }

    }
}
