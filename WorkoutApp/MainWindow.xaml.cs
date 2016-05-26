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
using WorkoutApp.Converters;


namespace WorkoutApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AddNewWorkoutWindow workoutWindow;
        public MainWindow()
        {
            InitializeComponent();

            List<string> months = new List<string> { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            monthComboBox.ItemsSource = months;
            
            for (int i = -10; i < 10; i++)
            {
                yearComboBox.Items.Add(DateTime.Today.AddYears(i).Year);
            }

            monthComboBox.SelectedItem = months.FirstOrDefault(w => w == DateTime.Today.ToString("MMMM"));
            yearComboBox.SelectedItem = DateTime.Today.Year;

            monthComboBox.SelectionChanged += (o, e) => RefreshCalendar();
            yearComboBox.SelectionChanged += (o, e) => RefreshCalendar();

            var path = System.AppDomain.CurrentDomain.BaseDirectory;
            int x = 5;
           
        }

        private void RefreshCalendar()
        {
            if (yearComboBox.SelectedItem == null) return;
            if (monthComboBox.SelectedItem == null) return;

            int year = (int)yearComboBox.SelectedItem;

            int month = monthComboBox.SelectedIndex + 1;

            DateTime targetDate = new DateTime(year, month, 1);
                      
            
        }

        private void MenuItemExit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ClickCalendar(object sender, MouseButtonEventArgs e)
        {
            if (workoutWindow != null)
            {
                workoutWindow.Close();
            }
            var param = sender as WorkoutApp.MyCalendar;
            var Day = param.CurrentDay.Date;
            workoutWindow = new AddNewWorkoutWindow(Day);
            workoutWindow.Show();
        }

        private void nextYearButton_Click(object sender, RoutedEventArgs e)
        {
            yearComboBox.SelectedIndex++;
            RefreshCalendar();
        }

        private void previousYearButton_Click(object sender, RoutedEventArgs e)
        {
            yearComboBox.SelectedIndex--;
            RefreshCalendar();
        }
        private void nextMonthButton_Click(object sender, RoutedEventArgs e)
        {
            monthComboBox.SelectedIndex++;
            RefreshCalendar();
        }
        
        private void previousMonthButton_Click(object sender, RoutedEventArgs e)
        {
            monthComboBox.SelectedIndex--;
            RefreshCalendar();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Escape)
            {
                Application.Current.Shutdown();
            }
        }
    }
}
