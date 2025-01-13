using System.Configuration;
using System.Data;
using System.Windows;

namespace example_250113
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            Views.MainWindow main = new();
            main.ShowDialog();
        }
    }

}
