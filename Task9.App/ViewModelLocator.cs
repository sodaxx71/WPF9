using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task9.App.Services;
using Task9.App.ViewModel;
using Task9.DAL;

namespace Task9.App
{
    public class ViewModelLocator
    {
        private static IDialogService _dialogServices = new DialogService();
        private static ICoffeeDataService _coffeeDataService = new CoffeeDataService(new CoffeeRepository());
        private static CoffeeOverviewViewModel _coffeeOverviewViewModel = new CoffeeOverviewViewModel(_coffeeDataService, _dialogServices);
        private static CoffeeDetailViewModel _coffeeDetailViewModel = new CoffeeDetailViewModel(_coffeeDataService, _dialogServices);

        public static CoffeeDetailViewModel CoffeeDetailViewModel
        {
            get => _coffeeDetailViewModel;
        }

        public static CoffeeOverviewViewModel CoffeeOverviewViewModel
        {
            get => _coffeeOverviewViewModel;
        }
    }
}
