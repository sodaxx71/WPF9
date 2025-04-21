using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task9.App.Services;
using Task9.Model;

namespace Task9.MTest.Mocks
{
    public class MockCoffeeDataService : ICoffeeDataService
    {
        private MockRepository _repository= new MockRepository();
        public void DeleteCoffee(Coffee coffee) 
        {

        }
        public List<Coffee> GetAllCoffees() 
        {
            return _repository.GetCoffees();
        }

        public Coffee GetCoffeeDetail(int coffeeId)
        {
            Coffee coffee = _repository.GetCoffeeById(coffeeId);
            return coffee;
        }

        public void SaveCoffee(Coffee selectedCoffee)
        {
            
        }

        public void UpdateCoffee(Coffee coffee) 
        {

        }
    }
}
