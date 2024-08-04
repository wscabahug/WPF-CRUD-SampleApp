using SampleApp.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly ModalNavigationStore modalNavigationStore;
        
        public ViewModelBase CurrentModalViewModel => modalNavigationStore.CurrentViewModel;
        public bool IsModalOpen => modalNavigationStore.IsOpen;
        public UsersViewModel UsersViewModel { get; }

        public MainViewModel(ModalNavigationStore modalNavigationStore, UsersViewModel usersViewModel)
        {
            this.modalNavigationStore = modalNavigationStore;
            UsersViewModel = usersViewModel;

            modalNavigationStore.CurrentViewModelChanged += ModalNavigationStore_CurrentViewModelChanged;
        }

        protected override void Dispose()
        {
            modalNavigationStore.CurrentViewModelChanged -= ModalNavigationStore_CurrentViewModelChanged;
            
            base.Dispose();
        }

        private void ModalNavigationStore_CurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentModalViewModel));
            OnPropertyChanged(nameof(IsModalOpen));
        }
    }
}
