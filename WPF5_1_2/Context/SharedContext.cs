using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF5_1_2.Models;

namespace WPF5_1_2.Context
{
    class SharedContext
    {
        public static CourseDBContext dbContext = new CourseDBContext();

        public static ObservableCollection<Course> courses = new ObservableCollection<Course>();
        public static ObservableCollection<CourseType> courseTypes = new ObservableCollection<CourseType>();
        public static ObservableCollection<Student> students = new ObservableCollection<Student>();

    }
}
