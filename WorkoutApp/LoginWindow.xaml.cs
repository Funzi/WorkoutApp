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
using System.IO;

namespace WorkoutApp
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        string[] users;
        
        public LoginWindow()
        {
            InitializeComponent();
            users = File.ReadAllLines("users.txt");
        }

        private void ExitButtonClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void LoginButtonClick(object sender, RoutedEventArgs e)
        {
            foreach (var user in users)
            {
                if(user == textBox.Text.ToLower())
                {
                    MainWindow wnd = new MainWindow();
                    this.Close();
                    // load window with data for current user
                    wnd.Show();
                }
            }

        }
    }
}
