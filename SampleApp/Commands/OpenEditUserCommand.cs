using SampleApp.Models;
using SampleApp.Stores;
using SampleApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Commands
{
    public class OpenEditUserCommand : CommandBase
    {
        private readonly UserListingItemViewModel userListingItemViewModel;
        private readonly UserStore userStore;
        private readonly ModalNavigationStore modalNavigationStore;

        public OpenEditUserCommand(UserListingItemViewModel userListingItemViewModel, UserStore userStore, ModalNavigationStore modalNavigationStore)
        {
            this.userListingItemViewModel = userListingItemViewModel;
            this.userStore = userStore;
            this.modalNavigationStore = modalNavigationStore;
        }

        public override void Execute(object parameter)
        {
            User user = userListingItemViewModel.User;

            EditUserViewModel editUserViewModel = new EditUserViewModel(user, userStore, modalNavigationStore);
            modalNavigationStore.CurrentViewModel = editUserViewModel;
        }
    }
}
