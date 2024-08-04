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
    public class SubmitEditUserCommand : AsyncCommandBase
    {
        private readonly EditUserViewModel editUserViewModel;
        private readonly UserStore userStore;
        private readonly ModalNavigationStore modalNavigationStore;

        public SubmitEditUserCommand(EditUserViewModel editUserViewModel, UserStore userStore, ModalNavigationStore modalNavigationStore)
        {
            this.editUserViewModel = editUserViewModel;
            this.userStore = userStore;
            this.modalNavigationStore = modalNavigationStore;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            UserDetailsFormViewModel formViewModel = editUserViewModel.UserDetailsFormViewModel;

            User user = new User(editUserViewModel.UserId, formViewModel.Username, formViewModel.IsRegular, formViewModel.IsEnrolled);

            try
            {
                await userStore.Edit(user);

                modalNavigationStore.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
