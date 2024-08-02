using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.ViewModels
{
    public class AddUserViewModel : ViewModelBase
    {
        public UserDetailsFormViewModel UserDetailsFormViewModel { get; }

        public AddUserViewModel()
        { 
            UserDetailsFormViewModel = new UserDetailsFormViewModel();
        }
    }
}
