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
        private User user;
        public User SelectedUser
        {
            get
            {
                return user;
            }
            set
            { 
                user = value;
                SelectedUserChanged?.Invoke();
            }
        }

        public event Action SelectedUserChanged;
    }
}
