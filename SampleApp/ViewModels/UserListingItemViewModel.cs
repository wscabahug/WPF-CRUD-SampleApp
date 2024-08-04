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
    public class UserListingItemViewModel : ViewModelBase
    {
        public User User { get; private set; }

        public string Username => User.Username;
        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }


        public UserListingItemViewModel(User user, UserStore userStore, ModalNavigationStore modalNavigationStore)
        {
            User = user;
            
            EditCommand = new OpenEditUserCommand(this, userStore, modalNavigationStore);
        }

        public void Update(User user)
        {
            User = user;

            OnPropertyChanged(nameof(User));
        }
    }
}
