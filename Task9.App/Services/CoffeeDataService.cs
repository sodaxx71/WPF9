using System;
using System.Collections.Generic;
using Task9.DAL;
using Task9.Model;



namespace Task9.App.Services
{
    public class CoffeeDataService : ICoffeeDataService
    {
        ICoffeeRepository _repository;

        public CoffeeDataService(ICoffeeRepository repository)
        {
            _repository = repository;
        }

        public Coffee GetCoffeeDetail(int coffeeId)
        {
            return _repository.GetCoffeeById(coffeeId);
        }

        public List<Coffee> GetAllCoffees()
        {
            return _repository.GetCoffees();
        }
        public void DeleteCoffee(Coffee coffee)
        {
            _repository.DeleteCoffee(coffee);
        }
         public void UpdateCoffee(Coffee coffee)
        {
            _repository.UpdateCoffee(coffee);
        }
    }
}
