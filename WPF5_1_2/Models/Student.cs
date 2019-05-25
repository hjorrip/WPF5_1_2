using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF5_1_2.Models
{
    class Student : INotifyPropertyChanged
    {
        public DateTime DateOfBirth { get; set; }
        public ObservableCollection<Course> Courses { get; set; }

        public Student()
        {
            this.DateOfBirth = DateTime.Now;
            this.Courses = new ObservableCollection<Course>();
        }

        public int Id { get; set; }

        private string _firstName;
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
                NotifyPropertyChanged("FullName");
                NotifyPropertyChanged("FirstName");

            }
        }



        private string _lastName;


        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
                NotifyPropertyChanged("FullName");
                NotifyPropertyChanged("LastName");

            }
        }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }



        private void NotifyPropertyChanged(string PropertyName)

        {

            if (PropertyChanged != null)

            {

                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));

            }

        }

        public event PropertyChangedEventHandler PropertyChanged;


    }
}
