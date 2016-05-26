using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace WorkoutApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class Application : System.Windows.Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            //LoginWindow login = new LoginWindow();
            //// Create the startup window

            //login.Show();
            MainWindow wnd = new MainWindow();
            wnd.Show();
        }
    }
}
