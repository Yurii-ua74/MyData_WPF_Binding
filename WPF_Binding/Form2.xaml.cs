using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace WPF_Binding
{
    /// <summary>
    /// Логика взаимодействия для Form2.xaml
    /// </summary>
    public partial class Form2 : Window
    {
        int type;
        Window1 wn1 = new Window1();
        Сandidates prsn = new Сandidates();
        public Form2()
        {
            InitializeComponent();
            Persons.AddInfo();
            DataContext = prsn;
        }

        private void cbx1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {         
            lbx1.Items.Clear();
            type = cbx1.SelectedIndex;
            switch(type)
            {
                case 0: 
                    {
                        foreach (var temp in Persons.candiList)                        
                            lbx1.Items.Add(temp.Name);                        
                        break; 
                    }
                case 1: 
                    {
                        foreach (var temp in Persons.candiList)                                
                            lbx1.Items.Add(temp.Education);                        
                        break; 
                    }  
                case 2: 
                    {
                        foreach (var temp in Persons.candiList)                        
                            lbx1.Items.Add(temp.WorkExperience);                                               
                        break; 
                    }
            }          
        }

        private void lbx1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int ind = lbx1.SelectedIndex;
            if (ind >= 0)
            {
                switch (type)
                {
                    case 0:
                        {
                            var selectPeople = from p in Persons.candiList
                                               where p.Name == lbx1.Items[ind]
                                               select p;
                            foreach (Сandidates persn in selectPeople)
                            {
                                prsn.Name = persn.Name; prsn.BirthDate = persn.BirthDate; prsn.Education = persn.Education; prsn.Language = persn.Language;
                                prsn.Computer = persn.Computer; prsn.WorkExperience = persn.WorkExperience; prsn.Recommendations = persn.Recommendations;
                            }
                            break;
                        }
                    case 1:
                        {
                            var selectPeople = from p in Persons.candiList
                                               where p.Education == lbx1.Items[ind]
                                               select p;
                            foreach (Сandidates persn in selectPeople)
                            {
                                prsn.Name = persn.Name; prsn.BirthDate = persn.BirthDate; prsn.Education = persn.Education; prsn.Language = persn.Language;
                                prsn.Computer = persn.Computer; prsn.WorkExperience = persn.WorkExperience; prsn.Recommendations = persn.Recommendations;
                            }
                            break;
                        }
                    case 2:
                        {
                            var selectPeople = from p in Persons.candiList
                                               where p.WorkExperience == lbx1.Items[ind]
                                               select p;
                            foreach (Сandidates persn in selectPeople)
                            {
                                prsn.Name = persn.Name; prsn.BirthDate = persn.BirthDate; prsn.Education = persn.Education; prsn.Language = persn.Language;
                                prsn.Computer = persn.Computer; prsn.WorkExperience = persn.WorkExperience; prsn.Recommendations = persn.Recommendations;
                            }
                            break;
                        }
                }
            }            
        }        
    }
}
