using SampleApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Stores
{
    public class ModalNavigationStore
    {
        private ViewModelBase currentViewModel;
        public ViewModelBase CurrentViewModel
        {
            get
            {
                return currentViewModel;
            }
            set
            {
                currentViewModel = value;
                CurrentViewModelChanged?.Invoke();
            }
        }

        public bool IsOpen => CurrentViewModel != null;

        public event Action CurrentViewModelChanged;

        public void Close()
        {
            CurrentViewModel = null;
        }
    }
}
