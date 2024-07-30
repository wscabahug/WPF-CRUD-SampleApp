using SampleApp.Stores;
using SampleApp.ViewModels;
using System.Configuration;
using System.Data;
using System.Windows;

namespace SampleApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly SelectedUserStore selectedUserStore;

        public App()
        {
            selectedUserStore = new SelectedUserStore();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new UsersViewModel(selectedUserStore)
            };
            MainWindow.Show();
            base.OnStartup(e);
        }
    }

}
