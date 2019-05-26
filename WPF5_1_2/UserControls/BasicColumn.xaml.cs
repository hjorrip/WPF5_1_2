using LiveCharts;
using LiveCharts.Wpf;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF5_1_2.UserControls
{
    /// <summary>
    /// Interaction logic for BasicColumn.xaml
    /// </summary>
    public partial class BasicColumn : UserControl
    {

        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> Formatter { get; set; }

        public BasicColumn()
        {

            InitializeComponent();

            SeriesCollection = new SeriesCollection
            {

            };

            Formatter = value => value.ToString("N");

            DataContext = this;


        }
    }
}
