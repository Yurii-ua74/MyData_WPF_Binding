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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Binding
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {       
        //Window1 window1 = new Window1();
        public MainWindow()
        {
            InitializeComponent();
        }      

        private void btn1_Click_1(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();          
                //this.Hide();
                window1.Show();          
        }
    }
}
