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
    public class SubmitAddUserCommand : AsyncCommandBase
    {
        private readonly AddUserViewModel addUserViewModel;
        private readonly UserStore userStore;
        private readonly ModalNavigationStore modalNavigationStore;

        public SubmitAddUserCommand(AddUserViewModel addUserViewModel, UserStore userStore, ModalNavigationStore modalNavigationStore)
        {
            this.addUserViewModel = addUserViewModel;
            this.userStore = userStore;
            this.modalNavigationStore = modalNavigationStore;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            UserDetailsFormViewModel formViewModel = addUserViewModel.UserDetailsFormViewModel;

            User user = new User(Guid.NewGuid(), formViewModel.Username, formViewModel.IsRegular, formViewModel.IsEnrolled);

            try
            {
                await userStore.Add(user);

                modalNavigationStore.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
