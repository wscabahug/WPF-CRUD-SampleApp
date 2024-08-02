using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.ViewModels
{
    public class EditUserViewModel : ViewModelBase
    {
        public UserDetailsFormViewModel UserDetailsFormViewModel { get; }

        public EditUserViewModel()
        {
            UserDetailsFormViewModel = new UserDetailsFormViewModel();
        }
    }
}
