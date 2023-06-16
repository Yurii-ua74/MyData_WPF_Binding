using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF_Binding
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        MainWindow mw = new MainWindow();
        public Window1()
        {
            InitializeComponent();
        }

        private void cb1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cb1.SelectedIndex != 3) 
            cb2.Visibility= Visibility.Visible;
        }

        private void checkBox1_Checked(object sender, RoutedEventArgs e)
        {
            cmBoxLang.Visibility= Visibility.Visible;
            cmBoxLangLevel.Visibility = Visibility.Visible;
        }

        private void checkBox1_Unchecked(object sender, RoutedEventArgs e)
        {
            cmBoxLang.Visibility = Visibility.Hidden;
            cmBoxLangLevel.Visibility = Visibility.Hidden;
        }

        private void dpic1_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            tblock1.Text = "";
            tblock1.Text = tbl1.Text;
            tblock1.Text += " ";            
            string data = string.Format("{0:dd-MM-yyyy}", dpic1.SelectedDate);
            tblock1.Text += $"{data} р.н.";         
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            Form2 window2 = new Form2();
            //this.Hide();
            window2.Show();
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            tbl1.Text = "";
            tbl1.Focus();
            dpic1.Text = "";
            cb1.Text = "";
            cb2.Text = ""; cb2.Visibility= Visibility.Hidden;
            checkBox1.IsChecked = false;
            cmBoxLang.Text = cmBoxLangLevel.Text = "";
            rb1.IsChecked = rb2.IsChecked = false;
            rb3.IsChecked = rb4.IsChecked = false;
            cbx1.Text = "";
            tblock1.Text = "";
        }

        private void tbl1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbl1.Text != "")
            {
                if (!Regex.Match(tbl1.Text, "^[А-Яа-яёЁЇїІіЄєҐґ' ]+$").Success)
                {
                    tbl1.Background = Brushes.Red;
                    MessageBoxResult res = MessageBox.Show("Невірний формат вводу ПІБ !", "ERROR", MessageBoxButton.OK);
                    if (res == MessageBoxResult.OK) tbl1.Background = Brushes.White;                  
                }
            }                   
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            string comp = "";
            string recom = "";
            if(rb1.IsChecked == true) comp = "Так";
            else comp = "Ні";
            if(rb3.IsChecked == true) recom = "Так";
            else recom = "Ні";            
            Persons.candiList.Add (new Сandidates(/*Persons.candiList.Count,*/ tbl1.Text, dpic1.Text, cb1.Text + cb2.Text, cmBoxLang.Text + cmBoxLangLevel.Text, comp, cbx1.Text, recom));
            MessageBox.Show("Кандидата зареєстровано");
        }

        public void Edit(string nm)
        {
            tbl1.Text = nm;
            dpic1.Text = "";
            cb1.Text = "";
            cb2.Text = ""; cb2.Visibility = Visibility.Hidden;
            checkBox1.IsChecked = false;
            cmBoxLang.Text = cmBoxLangLevel.Text = "";
            rb1.IsChecked = rb2.IsChecked = false;
            rb3.IsChecked = rb4.IsChecked = false;
            cbx1.Text = "";
            tblock1.Text = "";
        }
    }
}
