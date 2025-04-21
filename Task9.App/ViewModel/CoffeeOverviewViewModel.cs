using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Task9.App.Extensions;
using Task9.App.Messages;
using Task9.App.Services;
using Task9.App.Utility;
using Task9.Model;

namespace Task9.App.ViewModel
{
    public class CoffeeOverviewViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ICoffeeDataService _coffeeDataService;
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
        private bool _controlsEnabled = true;
        public bool ControlsEnabled
        {
            get => _controlsEnabled;
            set
            {
                _controlsEnabled = value;
                RaisePropertyChanged();
            }
        }


        private Coffee _selectedCoffee;

        public Coffee SelectedCoffee
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
        public CoffeeOverviewViewModel(ICoffeeDataService coffeeDataService, IDialogService dialofService)
        {
            _coffeeDataService = coffeeDataService;
            _dialogService = dialofService;
            LoadData();
            LoadCommands();
            Messenger.Default.Register<UpdateListMessage>(this, OnUpdateListMessageReceived);

        }
        public void LoadCommands()
        {
            EditCommand = new CustomCommand(EditCoffee, CanEditCoffee);
        }
        public void OnUpdateListMessageReceived(UpdateListMessage obj) 
        {
            LoadData();
            LoadCommands();
            ControlsEnabled = true;
            _dialogService.CloseDetailDialog();
        }
        private void EditCoffee(object obj) 
        {
            ControlsEnabled = false; 
            Messenger.Default.Send<Coffee>(_selectedCoffee);
            _dialogService.ShowDetailDialog();
        }
        private bool CanEditCoffee(object obj) 
        {
            if (SelectedCoffee != null)
                return true;
            return false;
        }
        private void LoadData() 
        {
            var coffees = _coffeeDataService.GetAllCoffees();
            Coffees = new ObservableCollection<Coffee>(coffees);
            RaisePropertyChanged(nameof(Coffees));
        }
    }
}
