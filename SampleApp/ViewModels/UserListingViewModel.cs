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
        private readonly UserStore userStore;
        private readonly SelectedUserStore selectedUserStore;
        private readonly ModalNavigationStore modalNavigationStore;
        private readonly ObservableCollection<UserListingItemViewModel> userListingItemViewModels;

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

        public UserListingViewModel(UserStore userStore, SelectedUserStore selectedUserStore, ModalNavigationStore modalNavigationStore)
        {
            this.userStore = userStore;
            this.selectedUserStore = selectedUserStore;
            this.modalNavigationStore = modalNavigationStore;
            userListingItemViewModels = new ObservableCollection<UserListingItemViewModel>();

            this.userStore.UserAdded += UserStore_UserAdded;
            this.userStore.UserEdited += UserStore_UserEdited;
        }

        protected override void Dispose()
        {
            userStore.UserAdded -= UserStore_UserAdded;
            userStore.UserEdited -= UserStore_UserEdited;
            base.Dispose();
        }

        private void UserStore_UserAdded(User user)
        {
            AddUser(user);
        }

        private void UserStore_UserEdited(User user)
        {
            UserListingItemViewModel userListingItemViewModel = userListingItemViewModels.FirstOrDefault(x => x.User.Id == user.Id);

            if (userListingItemViewModel != null)
            {
                userListingItemViewModel.Update(user);
            }
        }

        private void AddUser(User user)
        {
            UserListingItemViewModel itemViewModel = new UserListingItemViewModel(user, userStore, modalNavigationStore);
            userListingItemViewModels.Add(itemViewModel);
        }
    }
}
