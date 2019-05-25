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
    /// Interaction logic for NewStudentWindow.xaml
    /// </summary>
    public partial class NewStudentWindow : Window
    {

        Student s;

        public NewStudentWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SharedContext.dbContext.Students.Add(s);
            SharedContext.dbContext.SaveChanges();
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            s = new Student();

            this.DataContext = s;

            lbAllCourses.DataContext = SharedContext.courses;

        }

        private void LbAllCourses_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            s.Courses.Add((Course)lbAllCourses.SelectedItem);
        }

        private void menu_RCDeleteClick(object sender, RoutedEventArgs e)
        {
            s.Courses.Remove((Course)lbCourses.SelectedItem);
        }
    }
}
