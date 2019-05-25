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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPF5_1_2.Context;
using WPF5_1_2.Models;

namespace WPF5_1_2.Windows
{
    /// <summary>
    /// Interaction logic for ChangeStudentWindow.xaml
    /// </summary>
    public partial class ChangeStudentWindow : Window
    {

        Student temp;

        public ChangeStudentWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            temp = new Student();
            this.DataContext = temp;
            cbStudents.DataContext = SharedContext.students;


            lbAllCourses.DataContext = SharedContext.courses;


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Student selectedStudent = (Student)cbStudents.SelectedItem;

            selectedStudent.FirstName = temp.FirstName;
            selectedStudent.LastName = temp.LastName;
            selectedStudent.DateOfBirth = temp.DateOfBirth;
            selectedStudent.Courses.Clear();

            foreach (Course c in temp.Courses)
            {
                selectedStudent.Courses.Add(c);
            }

            SharedContext.dbContext.SaveChanges();
            this.Close();

        }

        private void CbStudents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Student selectedStudent = new Student();

            selectedStudent = (Student)cbStudents.SelectedItem;


            temp.FirstName = selectedStudent.FirstName;
            temp.LastName = selectedStudent.LastName;
            temp.DateOfBirth = selectedStudent.DateOfBirth;

            temp.Courses.Clear();

            foreach (Course s in selectedStudent.Courses)
            {
                temp.Courses.Add(s);
            }




        }

        private void LbAllCourses_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            temp.Courses.Add((Course)lbAllCourses.SelectedItem);
        }

        private void menu_RCRemoveCourseClick(object sender, RoutedEventArgs e)
        {
            temp.Courses.Remove((Course)lbCurrentCourses.SelectedItem);
        }
    }
}
