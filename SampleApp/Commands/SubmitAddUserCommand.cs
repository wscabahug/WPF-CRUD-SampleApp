using SampleApp.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Commands
{
    public class SubmitAddUserCommand : AsyncCommandBase
    {
        private readonly ModalNavigationStore modalNavigationStore;

        public SubmitAddUserCommand(ModalNavigationStore modalNavigationStore)
        {
            this.modalNavigationStore = modalNavigationStore;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            // Add User to database

            modalNavigationStore.Close();
        }
    }
}
