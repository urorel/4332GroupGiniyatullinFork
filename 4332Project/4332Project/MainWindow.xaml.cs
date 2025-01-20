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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _4332Project
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SidorovButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Имя: Игнат\nВозраст: 18 лет");
        }

        private void ShowAuthorInfo_Click(object sender, RoutedEventArgs e)
        {
            var newForm = new Novikov_4332(); //create your new form.
            newForm.Show(); //show the new form
        }
    }
}
