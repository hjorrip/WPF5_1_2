using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF5_1_2.Context;
using WPF5_1_2.Windows;

namespace WPF5_1_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CollectionViewSource view = new CollectionViewSource();

            SharedContext.dbContext.Courses.Include(x => x.Students).Load();
            SharedContext.courses = SharedContext.dbContext.Courses.Local;

            SharedContext.dbContext.CourseTypes.Load();
            SharedContext.courseTypes = SharedContext.dbContext.CourseTypes.Local;

            SharedContext.dbContext.Students.Load();
            SharedContext.students = SharedContext.dbContext.Students.Local;

            view.Source = SharedContext.courses;

            this.DataContext = view;
        }

        private void menu_QuitClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void menu_NewCourseClick(object sender, RoutedEventArgs e)
        {
            NewCourseWindow win = new NewCourseWindow();
            win.ShowDialog();
        }

        private void menu_NewStudentClick(object sender, RoutedEventArgs e)
        {
            NewStudentWindow win = new NewStudentWindow();
            win.ShowDialog();
        }

        private void menu_ChangeCourseClick(object sender, RoutedEventArgs e)
        {
            ChangeCourseWindow win = new ChangeCourseWindow();
            win.ShowDialog();
        }

        private void menu_ChangeStudentClick(object sender, RoutedEventArgs e)
        {
            ChangeStudentWindow win = new ChangeStudentWindow();
            win.ShowDialog();
        }
    }
}
