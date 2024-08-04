using SampleApp.Stores;
using SampleApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Commands
{
    public class OpenAddUserCommand : CommandBase
    {
        private readonly UserStore userStore;
        private readonly ModalNavigationStore modalNavigationStore;

        public OpenAddUserCommand(UserStore userStore, ModalNavigationStore modalNavigationStore)
        {
            this.userStore = userStore;
            this.modalNavigationStore = modalNavigationStore;
        }

        public override void Execute(object parameter)
        {
            AddUserViewModel addUserViewModel = new AddUserViewModel(userStore, modalNavigationStore);
            modalNavigationStore.CurrentViewModel = addUserViewModel;
        }
    }
}
