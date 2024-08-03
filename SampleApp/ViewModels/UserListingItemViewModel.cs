using SampleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleApp.ViewModels
{
    public class UserListingItemViewModel : ViewModelBase
    {
        public User User { get; }

        public string Username => User.Username;
        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }

        public UserListingItemViewModel(User user, ICommand editCommand)
        {
            EditCommand = editCommand;
            User = user;
        }
    }
}
