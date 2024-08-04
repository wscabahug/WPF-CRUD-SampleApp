using SampleApp.Models;
using SampleApp.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.ViewModels
{
    public class UserDetailsViewModel : ViewModelBase
    {
        private readonly SelectedUserStore selectedUserStore;

        private User SelectedUser => selectedUserStore.SelectedUser;
        public bool HasSelectedUser => SelectedUser != null;
        public string Username => SelectedUser?.Username ?? "Unknown";
        public string IsRegularDisplay => (SelectedUser?.IsRegular ?? false) ? "Yes" : "No";
        public string IsEnrolledDisplay => (SelectedUser?.IsEnrolled ?? false) ? "Yes" : "No";

        public UserDetailsViewModel(SelectedUserStore selectedUserStore) 
        {
            this.selectedUserStore = selectedUserStore;

            this.selectedUserStore.SelectedUserChanged += SelectedUserStore_SelectedUserChanged;
        }

        protected override void Dispose()
        {
            selectedUserStore.SelectedUserChanged -= SelectedUserStore_SelectedUserChanged;

            base.Dispose();
        }

        private void SelectedUserStore_SelectedUserChanged()
        {
            OnPropertyChanged(nameof(HasSelectedUser));
            OnPropertyChanged(nameof(Username));
            OnPropertyChanged(nameof(IsRegularDisplay));
            OnPropertyChanged(nameof(IsEnrolledDisplay));
        }
    }
}
