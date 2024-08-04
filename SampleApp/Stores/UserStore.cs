using SampleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Stores
{
    public class UserStore
    {
        public event Action<User> UserAdded;
        public event Action<User> UserEdited;

        public async Task Add(User user)
        {
            UserAdded?.Invoke(user);
        }

        public async Task Edit(User user)
        {
            UserEdited?.Invoke(user);
        }
    }
}
