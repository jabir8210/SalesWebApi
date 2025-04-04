using Microsoft.AspNetCore.Mvc;
using Moq;
using SalesWebAPI.Controllers;
using SalesWebAPI.Interfaces;
using SalesWebAPI.Models;
using System.Numerics;

namespace SalesAPITestProject
{
    [TestClass]
    public class CustomersControllerTest
    {
        [TestMethod]
        public void GetCustomers_ShouldReturnLists()
        {
            //Arrange
            var mockRepo = new Mock<ICustomerRepository>();
            mockRepo.Setup(repo => repo.GetCustomers()).Returns(new List<Customer>());
            var controller = new CustomersController(mockRepo.Object);

            // Act
            var result = controller.Get();

            // Assert
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
        }
        [TestMethod]
        public void GetCustomers_When_Called_returnsNull()
        {
            // Arrange
            var mockRepo = new Mock<ICustomerRepository>();
            mockRepo.Setup(repo => repo.GetCustomers()).Returns((List<Customer>)null);
            var controller = new CustomersController(mockRepo.Object);
            // Act
            var result = controller.Get();
            // Assert
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));


        }

        [TestMethod]
        public void GetCustomer_WithAnInvalidId_ShouldReturnNull()
        {
            //
        }



        [TestMethod]
        public void GetCustomer_WithAValidId_ShouldReturnCustomer()
        {
           //
        }

    }
}