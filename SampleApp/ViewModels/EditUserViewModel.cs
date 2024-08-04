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
        public Guid UserId { get; }
        public UserDetailsFormViewModel UserDetailsFormViewModel { get; }

        public EditUserViewModel(User user, UserStore userStore, ModalNavigationStore modalNavigationStore)
        {
            UserId = user.Id;

            ICommand submitCommand = new SubmitEditUserCommand(this, userStore, modalNavigationStore);
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
