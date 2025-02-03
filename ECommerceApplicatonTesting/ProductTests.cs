using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerceApplication;
using NUnit.Framework;

namespace ECommerceApplicatonTesting
{
    public class ProductTests
    {
        [Test]
        public void ProductID_ValidValue_SetsCorrectly()
        {
            // arrange
            int prodID = 500;
            string prodName = "Laptop";
            decimal itemPrice = 1200;
            int stockAmount = 50;

            // act
            var product = new Product(prodID, prodName, itemPrice, stockAmount);

            // assert
            Assert.That(product.ProdID, Is.EqualTo(prodID));
        }
    }
}
