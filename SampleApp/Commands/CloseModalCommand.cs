using SampleApp.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Commands
{
    public class CloseModalCommand : CommandBase
    {
        private readonly ModalNavigationStore modalNavigationStore;

        public CloseModalCommand(ModalNavigationStore modalNavigationStore)
        {
            this.modalNavigationStore = modalNavigationStore;
        }

        public override void Execute(object parameter)
        {
            modalNavigationStore.Close();
        }
    }
}
