using Microsoft.VisualStudio.TestTools.UnitTesting;
using CRM_BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_BL.Model.Tests
{
    [TestClass()]
    public class CashDeskTests
    {
        [TestMethod()]
        public void CashDeskTest()
        {
            // arrange
            var customer1 = new Customer()
            {
                Name = "testuser1",
                Id = 1
            };

            var customer2 = new Customer()
            {
                Name = "customer2",
                Id = 2
            };

            var seller = new Seller()
            {
                Name = "sellername",
                Id = 1
            };

            var product1 = new Product()
            {
                Id = 1,
                Name = "pr1",
                Price = 100,
                Count = 10
            };
            var product2 = new Product()
            {
                Id = 2,
                Name = "prod2",
                Price = 200,
                Count = 20
            };

            var cart1 = new Cart(customer1)
            {
                product1,
                product1,
                product2
            };

            var cart2 = new Cart(customer2)
            {
                product1,
                product2,
                product2
            };

            var cashdesk = new CashDesk(1, seller, null)
            {
                IsModel = true,
                MaxQueueLenght = 10
            };
            cashdesk.Enqueue(cart1);
            cashdesk.Enqueue(cart2);

            var cart1ExpectedResult = 400;
            var cart2ExpectedResult = 500;

            // act
            var cart1ActualResult = cashdesk.Dequeue();
            var cart2ActualResult = cashdesk.Dequeue();

            // assert
            Assert.AreEqual(cart1ExpectedResult, cart1ActualResult);
            Assert.AreEqual(cart2ExpectedResult, cart2ActualResult);
            Assert.AreEqual(7, product1.Count);
            Assert.AreEqual(17, product2.Count);
        }
    }
}