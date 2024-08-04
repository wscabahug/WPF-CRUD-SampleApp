using SampleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Stores
{
    public class SelectedUserStore
    {
        private readonly UserStore userStore;

        private User selectedUser;
        public User SelectedUser
        {
            get
            {
                return selectedUser;
            }
            set
            { 
                selectedUser = value;
                SelectedUserChanged?.Invoke();
            }
        }

        public event Action SelectedUserChanged;

        public SelectedUserStore(UserStore userStore)
        {
            this.userStore = userStore;

            this.userStore.UserEdited += UserStore_UserEdited;
        }

        private void UserStore_UserEdited(User user)
        {
            if(user.Id == selectedUser?.Id)
            {
                SelectedUser = user;
            }
        }
    }
}
