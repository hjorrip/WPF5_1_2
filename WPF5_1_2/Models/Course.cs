using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF5_1_2.Models
{
    class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CourseType CourseType { get; set; }
        public ObservableCollection<Student> Students { get; set; }


        public Course()
        {
            this.Students = new ObservableCollection<Student>();
        }

    }
}
