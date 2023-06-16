using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Binding
{
    public class Сandidates : INotifyPropertyChanged
    {
        //private int id=0;
        private string name;
        private string birth_date;
        private string education;
        private string language;
        private string computer;
        private string work_experience;
        private string recommendations;

        public Сandidates() { }

        public Сandidates(string nm, string bd, string ed, string lan, string comp, string wex, string recom)
        {
            name = nm; birth_date = bd; education = ed; language = lan;
            computer = comp; work_experience = wex; recommendations = recom;
        }
        //public Сandidates(int id,string nm, string bd, string ed, string lan, string comp, string wex, string recom) 
        //{
        //    this.id = id; name = nm; birth_date = bd; education = ed; language = lan;
        //    computer = comp; work_experience = wex; recommendations = recom;
        //}
        //public int Id
        //{
        //    get { return id; }
        //    set
        //    {
        //        id = value;
        //        OnPropertyChanged("Id");
        //    }
        //}
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        public string BirthDate
        {
            get { return birth_date; }
            set
            {
                birth_date = value;
                OnPropertyChanged("BirthDate");
            }
        }
        public string Education
        {
            get { return education; }
            set
            {
                education = value;
                OnPropertyChanged("Education");
            }
        }
        public string Language
        {
            get { return language; }
            set
            {
                language = value;
                OnPropertyChanged("Language");
            }
        }
        public string Computer
        {
            get { return computer; }
            set
            {
                computer = value;
                OnPropertyChanged("Computer");
            }
        }
        public string WorkExperience
        {
            get { return work_experience; }
            set
            {
                work_experience = value;
                OnPropertyChanged("WorkExperience");
            }
        }
        public string Recommendations
        {
            get { return recommendations; }
            set
            {
                recommendations = value;
                OnPropertyChanged("Recommendations");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}

