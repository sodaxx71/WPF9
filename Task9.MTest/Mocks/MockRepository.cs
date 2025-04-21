using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task9.DAL;
using Task9.Model;

namespace Task9.MTest.Mocks
{
    public class MockRepository : ICoffeeRepository
    {
        private List<Coffee> _coffees;
        public MockRepository()
        {
            _coffees = LoadMockCoffees();
        }
        private List<Coffee> LoadMockCoffees()
        {
            return new List<Coffee>() 
            {
               new Coffee()
{
    CoffeeId = 1,
    CoffeeName = "Руль мотоциклетный Renthal Ultra Low",
    Description = "Спортивный руль из алюминиевого сплава с пониженной посадкой, диаметр 22мм, ширина 780мм.",
    ImageId = 1,
    AmountInStock = 15,
    InStock = true,
    FirstAddedToStockDate = new DateTime(2024, 3, 15),
    OriginCountry = Country.Япония,
    Price = 12500
},

            };
        }
        public void DeleteCoffee(Coffee coffee)
        {
            throw new NotImplementedException();
        }
        public void UpdateCoffee(Coffee coffee)
        {
            throw new NotImplementedException();
        }
        public Coffee GetACofee()
        {
            throw new NotImplementedException();
        }
        public Coffee GetCoffeeById(int coffeeId)
        {
            return _coffees.Where(c => c.CoffeeId == coffeeId).FirstOrDefault();
        }
        public List<Coffee> GetCoffees()
        {
            return _coffees;
        }

        public Coffee GetCoffee()
        {
            throw new NotImplementedException();
        }
    }
}
