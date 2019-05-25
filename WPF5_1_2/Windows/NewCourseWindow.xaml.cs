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
    /// Interaction logic for NewCourseWindow.xaml
    /// </summary>
    public partial class NewCourseWindow : Window
    {

        Course c;

        public NewCourseWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            c = new Course();
            this.DataContext = c;

            cbCourseTypes.DataContext = SharedContext.courseTypes;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            c.CourseType = (CourseType)cbCourseTypes.SelectedItem;
            SharedContext.dbContext.Courses.Add(c);
            SharedContext.dbContext.SaveChanges();
            this.Close();
        }
    }
}
