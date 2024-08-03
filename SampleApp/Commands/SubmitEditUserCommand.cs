using SampleApp.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Commands
{
    public class SubmitEditUserCommand : AsyncCommandBase
    {
        private readonly ModalNavigationStore modalNavigationStore;

        public SubmitEditUserCommand(ModalNavigationStore modalNavigationStore)
        {
            this.modalNavigationStore = modalNavigationStore;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            // Update User in database

            modalNavigationStore.Close();
        }
    }
}
