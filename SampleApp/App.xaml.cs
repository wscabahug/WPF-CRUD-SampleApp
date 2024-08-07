﻿using SampleApp.Stores;
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
        private readonly ModalNavigationStore modalNavigationStore;
        private readonly UserStore userStore;
        private readonly SelectedUserStore selectedUserStore;

        public App()
        {
            modalNavigationStore = new ModalNavigationStore();
            userStore = new UserStore();
            selectedUserStore = new SelectedUserStore(userStore);
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            UsersViewModel usersViewModel = new UsersViewModel(userStore, selectedUserStore, modalNavigationStore);
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(modalNavigationStore, usersViewModel)
            };
            MainWindow.Show();
            base.OnStartup(e);
        }
    }

}
