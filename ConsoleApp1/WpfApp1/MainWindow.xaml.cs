using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
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
using ConsoleApp1;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Controller c = new Controller();
        public MainWindow()
        {
            InitializeComponent();
            Save.Visibility = Visibility.Hidden;
            Save_entry.Visibility = Visibility.Hidden;
        }
        private void Lancer_Programme(object sender, RoutedEventArgs e)
        {
            c.source = Source.Text;
            c.Label = Save_entry.Text;

            if (Yes.IsChecked == true)
            {
                c.CountWord(true);
                c.CountChar(true);
            }
            else
            {
                c.CountWord(false);
                c.CountChar(false);
            }

            resultWatch.Text = c.varResult;

            
        }

        private void Yes_Checked(object sender, RoutedEventArgs e)
        {
            No.IsChecked = false;
            if (Yes.IsChecked == true)
            {
                Save.Visibility = Visibility.Visible;
                Save_entry.Visibility = Visibility.Visible;
            }
        }

        private void No_Checked(object sender, RoutedEventArgs e)
        {
            Yes.IsChecked = false;
            if (No.IsChecked == true)
            {
                Save.Visibility = Visibility.Hidden;
                Save_entry.Visibility = Visibility.Hidden;
            }
        }
        private void Source_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void Save_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
