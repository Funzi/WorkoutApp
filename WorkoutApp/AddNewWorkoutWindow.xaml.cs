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

namespace WorkoutApp
{
    /// <summary>
    /// Interaction logic for AddNewWorkoutWindow.xaml
    /// </summary>
    public partial class AddNewWorkoutWindow : Window
    {
        public AddNewWorkoutWindow()
        {
            InitializeComponent();
            label3.FontSize = 20;
            this.textBlock1.Text = DateTime.Today.ToString();
        }
        public AddNewWorkoutWindow(DateTime day) : this()
        {
            this.textBlock1.Text = day.Date.ToString();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
