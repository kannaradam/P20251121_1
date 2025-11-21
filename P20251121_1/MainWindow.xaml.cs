using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace P20251121_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void New_window(object sender, RoutedEventArgs e)
        {
            FileStream f = new FileStream("proba.txt", FileMode.Create);
            f.Close();
        }
        private void Open_window(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog();
        }
        private void Save_dialog(object sender, RoutedEventArgs e)
        {
           SaveFileDialog dialog = new SaveFileDialog();
            dialog.ShowDialog();
        }
    }
}
