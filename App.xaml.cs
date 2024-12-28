using System.Configuration;
using System.Data;
using System.Windows;

namespace chasetag_scoreboard
{
    public partial class App : Application
    {
        public SharedViewModel ViewModel { get; } = new SharedViewModel();

        protected override void OnStartup(StartupEventArgs e)
        {
            var mainWindow = new MainWindow();
            mainWindow.DataContext = ViewModel;
            mainWindow.Show();

            var secondWindow = new SecondWindow();
            secondWindow.DataContext = ViewModel;
            secondWindow.Show();
        }
    }
}
