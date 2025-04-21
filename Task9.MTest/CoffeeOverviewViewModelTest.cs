using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task9.App.Services;
using Task9.App.ViewModel;
using Task9.Model;
using Task9.MTest.Mocks;

namespace Task9.MTest
{
    [TestClass]
    public class CoffeeOverviewViewModelTest
    {
        private ICoffeeDataService _coffeeDataService;
        private IDialogService _dialogService;

        private CoffeeOverviewViewModel GetViewModel()
        {
            return new CoffeeOverviewViewModel(this._coffeeDataService, this._dialogService);
        }
        [TestInitialize]
        public void Init() 
        {
            _coffeeDataService = new MockCoffeeDataService();
            _dialogService = new MockDialogService();
        }
        [TestMethod]
        public void LoadAllCoffees() 
        {
            ObservableCollection<Coffee> coffees = null;
            var expectedCoffees=_coffeeDataService.GetAllCoffees();

            var viewModel = GetViewModel();
            coffees = viewModel.Coffees;

            CollectionAssert.AreEqual(expectedCoffees, coffees);
        }
    }
}
