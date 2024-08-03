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
        private readonly ModalNavigationStore modalNavigationStore;

        public OpenAddUserCommand(ModalNavigationStore modalNavigationStore)
        {
            this.modalNavigationStore = modalNavigationStore;
        }

        public override void Execute(object parameter)
        {
            AddUserViewModel addUserViewModel = new AddUserViewModel(modalNavigationStore);
            modalNavigationStore.CurrentViewModel = addUserViewModel;
        }
    }
}
