using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task9.Model;

namespace Task9.DAL
{
    public class CoffeeRepository : ICoffeeRepository
    {
        private static List<Coffee> coffees;

        public CoffeeRepository()
        {
            if (coffees == null)
                LoadCoffees();
        }

        public Coffee GetCoffee()
        {
            return coffees.FirstOrDefault();
        }

        public List<Coffee> GetCoffees()
        {
            return coffees;
        }

        public Coffee GetCoffeeById(int id)
        {
            return coffees.FirstOrDefault(c => c.CoffeeId == id);
        }

        public void DeleteCoffee(Coffee coffee)
        {
            coffees.Remove(coffee);
        }

        public void UpdateCoffee(Coffee coffee)
        {
            var coffeeToUpdate = coffees.FirstOrDefault(c => c.CoffeeId == coffee.CoffeeId);
            if (coffeeToUpdate != null)
            {
                coffeeToUpdate.CoffeeName = coffee.CoffeeName;
                coffeeToUpdate.Description = coffee.Description;
                coffeeToUpdate.ImageId = coffee.ImageId;
                coffeeToUpdate.AmountInStock = coffee.AmountInStock;
                coffeeToUpdate.InStock = coffee.InStock;
                coffeeToUpdate.FirstAddedToStockDate = coffee.FirstAddedToStockDate;
                coffeeToUpdate.OriginCountry = coffee.OriginCountry;
                coffeeToUpdate.Price = coffee.Price;
            }
        }

        private void LoadCoffees()
        {
            coffees = new List<Coffee>()
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
new Coffee()
{
    CoffeeId = 2,
    CoffeeName = "Колесо мотоциклетное D.I.D DirtStar",
    Description = "Заднее колесо 18x2.15 с ободом из алюминиевого сплава, подходит для эндуро и кроссовых мотоциклов.",
    ImageId = 2,
    AmountInStock = 8,
    InStock = true,
    FirstAddedToStockDate = new DateTime(2023, 11, 20),
    OriginCountry = Country.Германия,
    Price = 28900
},
new Coffee()
{
    CoffeeId = 3,
    CoffeeName = "Амортизатор задний Öhlins TTX",
    Description = "Газомасляный амортизатор с регулировкой преднатяга и отбоя, ход 300мм, для спортивных мотоциклов.",
    ImageId = 3,
    AmountInStock = 5,
    InStock = true,
    FirstAddedToStockDate = new DateTime(2024, 1, 10),
    OriginCountry = Country.Швеция,
    Price = 67500
},
new Coffee()
{
    CoffeeId = 4,
    CoffeeName = "Двигатель Honda CBR600RR",
    Description = "4-цилиндровый 600cc двигатель с системой PGM-FI, мощность 118 л.с. Полностью исправен, б/у.",
    ImageId = 4,
    AmountInStock = 3,
    InStock = true,
    FirstAddedToStockDate = new DateTime(2023, 9, 5),
    OriginCountry = Country.Япония,
    Price = 145000
},
new Coffee()
{
    CoffeeId = 5,
    CoffeeName = "Глушитель Akrapovic Slip-On",
    Description = "Титан-карбоновый глушитель для Yamaha R1 (2015-2019), сертифицирован EURO 4, вес 2.4кг.",
    ImageId = 5,
    AmountInStock = 7,
    InStock = true,
    FirstAddedToStockDate = new DateTime(2024, 2, 28),
    OriginCountry = Country.Словения,
    Price = 58900
}

        };
        }
    }
}
