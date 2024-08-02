using SampleApp.Models;
using SampleApp.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.ViewModels
{
    public class UserListingViewModel : ViewModelBase
    {
        private readonly ObservableCollection<UserListingItemViewModel> userListingItemViewModels;
        private readonly SelectedUserStore selectedUserStore;

        public IEnumerable<UserListingItemViewModel> UserListingItemViewModels => userListingItemViewModels;

        private UserListingItemViewModel selectedUserListingItemViewModel;
        public UserListingItemViewModel SelectedUserListingItemViewModel
        {
            get
            {
                return selectedUserListingItemViewModel;
            }
            set
            {
                selectedUserListingItemViewModel = value;
                OnPropertyChanged(nameof(SelectedUserListingItemViewModel));

                selectedUserStore.SelectedUser = selectedUserListingItemViewModel?.User;
            }
        }

        public UserListingViewModel(SelectedUserStore selectedUserStore)
        {
            userListingItemViewModels = new ObservableCollection<UserListingItemViewModel>();

            userListingItemViewModels.Add(new UserListingItemViewModel(new User("UserA", true, false)));
            userListingItemViewModels.Add(new UserListingItemViewModel(new User("UserB", false, true)));
            userListingItemViewModels.Add(new UserListingItemViewModel(new User("UserC", true, true)));
            this.selectedUserStore = selectedUserStore;
        }
    }
}
