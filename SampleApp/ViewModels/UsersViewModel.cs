using SampleApp.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleApp.ViewModels
{
    public class UsersViewModel : ViewModelBase
    {
        public UserListingViewModel UserListingViewModel { get; }
        public UserDetailsViewModel UserDetailsViewModel { get; }

        public ICommand AddUsersCommand { get; }

        public UsersViewModel(SelectedUserStore selectedUserStore)
        {
            UserListingViewModel = new UserListingViewModel(selectedUserStore);
            UserDetailsViewModel = new UserDetailsViewModel(selectedUserStore);
        }
    }
}
