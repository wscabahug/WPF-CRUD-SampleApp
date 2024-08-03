using SampleApp.Commands;
using SampleApp.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleApp.ViewModels
{
    public class AddUserViewModel : ViewModelBase
    {
        public UserDetailsFormViewModel UserDetailsFormViewModel { get; }

        public AddUserViewModel(ModalNavigationStore modalNavigationStore)
        {
            ICommand submitCommand = new SubmitAddUserCommand(modalNavigationStore);
            ICommand cancelCommand = new CloseModalCommand(modalNavigationStore);
            UserDetailsFormViewModel = new UserDetailsFormViewModel(submitCommand, cancelCommand);
        }
    }
}
