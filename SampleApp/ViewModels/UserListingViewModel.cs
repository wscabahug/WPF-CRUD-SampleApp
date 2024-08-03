using SampleApp.Commands;
using SampleApp.Models;
using SampleApp.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

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

        public UserListingViewModel(SelectedUserStore selectedUserStore, ModalNavigationStore modalNavigationStore)
        {
            userListingItemViewModels = new ObservableCollection<UserListingItemViewModel>();

            AddUser(new User("UserA", true, false), modalNavigationStore);
            AddUser(new User("UserB", false, true), modalNavigationStore);
            AddUser(new User("UserC", true, true), modalNavigationStore);
            this.selectedUserStore = selectedUserStore;
        }

        private void AddUser(User user, ModalNavigationStore modalNavigationStore)
        {
            ICommand editCommand = new OpenEditUserCommand(user, modalNavigationStore);
            userListingItemViewModels.Add(new UserListingItemViewModel(user, editCommand));
        }
    }
}
