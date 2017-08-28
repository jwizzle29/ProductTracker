using ProductTracker.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ProductTracker
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private ApplicationVM _ApplicationVM;
        private void ApplicationStartup(object sender, StartupEventArgs e)
        {
            _ApplicationVM = Resources["ApplicationVM"] as ApplicationVM;

            if(_ApplicationVM != null)
            {
                _ApplicationVM.Startup();
                MainWindow mainWindow = new MainWindow();
                this.MainWindow = mainWindow;
                this.MainWindow.Title = "";
                this.MainWindow.Show();
            }            
        }
    }
}
