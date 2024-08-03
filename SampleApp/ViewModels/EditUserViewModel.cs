using SampleApp.Commands;
using SampleApp.Models;
using SampleApp.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleApp.ViewModels
{
    public class EditUserViewModel : ViewModelBase
    {
        public UserDetailsFormViewModel UserDetailsFormViewModel { get; }

        public EditUserViewModel(User user, ModalNavigationStore modalNavigationStore)
        {
            ICommand submitCommand = new SubmitEditUserCommand(modalNavigationStore);
            ICommand cancelCommand = new CloseModalCommand(modalNavigationStore);
            UserDetailsFormViewModel = new UserDetailsFormViewModel(submitCommand, cancelCommand)
            {
                Username = user.Username,
                IsRegular = user.IsRegular,
                IsEnrolled = user.IsEnrolled
            };
        }
    }
}
