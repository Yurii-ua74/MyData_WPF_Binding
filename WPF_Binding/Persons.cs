using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WPF_Binding
{
    public class Persons : ObservableCollection<Сandidates>
    {
        public static List<Сandidates> candiList = new List<Сandidates>();
       
        public Persons()
        {           
            Add(new Сandidates( "Дурімар Болотник", "18,03,2004", "Вища Пінгвінячий логопед", "English Beginner", "Так", "До року", "Ні"));
            Add(new Сandidates( "Снандулия Весняшка", "21,01,2001", "Вища Дресирувальник", "Arab Intermediante", "Так", "від 1 до 3 років", "Так"));
            Add(new Сandidates( "Акакій Чалапкін", "21,01,2001", "Три класи два коридори", "Tagalog Proficiency", "Ні", "більше 5 років", "Ні"));
        }
        public static void AddInfo()
        {
            candiList.Add(new Сandidates(/*candiList.Count,*/ "Дурімар Болотник", "18,03,2004", "Вища Пінгвінячий логопед", "English Beginner", "Так", "До року", "Ні"));
            candiList.Add(new Сandidates(/*candiList.Count,*/ "Скандулия Весняшка", "21,01,2001", "Вища Дресирувальник", "Arab Intermediante", "Так", "від 1 до 3 років", "Так"));
            candiList.Add(new Сandidates(/*candiList.Count,*/ "Акакій Чалапкін", "21,01,2001", "Три класи два коридори", "Tagalog Proficiency", "Ні", "більше 5 років", "Ні"));
        }
    }
}
