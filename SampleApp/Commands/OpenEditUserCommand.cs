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
        private readonly User user;
        private readonly ModalNavigationStore modalNavigationStore;

        public OpenEditUserCommand(User user, ModalNavigationStore modalNavigationStore)
        {
            this.user = user;
            this.modalNavigationStore = modalNavigationStore;
        }

        public override void Execute(object parameter)
        {
            EditUserViewModel editUserViewModel = new EditUserViewModel(user, modalNavigationStore);
            modalNavigationStore.CurrentViewModel = editUserViewModel;
        }
    }
}
