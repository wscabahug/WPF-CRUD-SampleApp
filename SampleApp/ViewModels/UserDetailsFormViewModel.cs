using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleApp.ViewModels
{
    public class UserDetailsFormViewModel : ViewModelBase
    {
        private string username;

        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
                OnPropertyChanged(nameof(Username));
                OnPropertyChanged(nameof(CanSubmit));
            }
        }

        private bool isRegular;
        public bool IsRegular
        {
            get
            {
                return isRegular;
            }
            set
            {
                isRegular = value;
                OnPropertyChanged(nameof(IsRegular));
            }
        }

        private bool isEnrolled;

        public bool IsEnrolled
        {
            get
            {
                return isEnrolled;
            }
            set
            {
                isEnrolled = value;
                OnPropertyChanged(nameof(IsEnrolled));
            }
        }

        public bool CanSubmit => !string.IsNullOrEmpty(Username);

        public ICommand SubmitCommand { get; }

        public ICommand CancelCommand { get; }

        public UserDetailsFormViewModel(ICommand submitCommand, ICommand cancelCommand)
        {
            SubmitCommand = submitCommand;
            CancelCommand = cancelCommand;
        }
    }
}
