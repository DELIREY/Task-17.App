using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Task_17.App.Messages;
using Task_17.App.Services;
using Task_17.App.Utility;
using Task17.Model;

namespace Task_17.App.ViewModel
{
    public class CoffeeOverviewViewModel : INotifyPropertyChanged
    {
        public ICoffeeDataService _coffeeDataService;
        private IDialogService _dialogService;

        private ObservableCollection<Coffee> _coffees;
        public ObservableCollection<Coffee> Coffees
        {
            get => _coffees;
            set
            {
                _coffees = value;
                RaisePropertyChanged();
            }
        }
        private Coffee _selectedCoffee;

        private Coffee SelectedCoffee
        {
            get => _selectedCoffee;
            set
            {
                _selectedCoffee = value;
                RaisePropertyChanged();
            }
        }
        public ICommand EditCommand { get; set; }

        private void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public CoffeeOverviewViewModel(ICoffeeDataService coffeeDataService, IDialogService dialogService)
        {
            _coffeeDataService = coffeeDataService;
            _dialogService = dialogService;

            LoadData();

            LoadCommands();

            Messenger.Default.Register<UpdateListMessage>(this, OnUpdateListMessageRecevied);
        }

        private void LoadCommands()
        {
            EditCommand = new CustomCommand(EditCoffee, CanEditCoffee);
        }

        private void OnUpdatelistMessageReceived(UpdateListMessage obj)
        {
            LoadData();
            _dialogService.CloseDetailDialog();
        }


    }

}
