using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task9.App.Services;
using Task9.DAL;
using Task9.MTest.Mocks;

namespace Task9.MTest
{
    [TestClass]
    public class CoffeeDataServiceTest
    {
        
        private ICoffeeRepository _repository;

        [TestInitialize]
        public void Init() 
        {
            _repository = new MockRepository();
        }
        [TestMethod]
        public void GetCoffeeDetailTest() 
        {
            var service = new CoffeeDataService(_repository);

            var coffee = service.GetCoffeeDetail(1);
            
            Assert.IsNotNull(coffee);
        }
    }
}
