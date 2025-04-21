using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task9.Model;

namespace Task9.DAL
{
    public interface ICoffeeRepository
    {
        Coffee GetCoffee();
        List<Coffee> GetCoffees();
        Coffee GetCoffeeById(int id);
        void DeleteCoffee(Coffee coffee);
        void UpdateCoffee(Coffee coffee);
    }
}
