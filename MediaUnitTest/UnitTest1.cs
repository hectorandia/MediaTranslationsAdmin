using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;
using Moq;
using MediaAdmin.Abstract;
using MediaAdmin.MediaEntity;
using MediaView.Controller;

namespace MediaUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Can_Create_CustomerEntity()
        {
            //Arrange
            Mock<IEFEntityRepository> mock = new Mock<IEFEntityRepository>();
            mock.Setup(m => m.Customers).Returns(new Customers[] {
                new Customers{CustomerID = 1, Name = "Hector", ZIP = "39112", City = "Iquique"},
                new Customers{Name = "Carlos", ZIP = "392", City = "Magdeburg"},
                new Customers{Name = "Juan", ZIP = "3912", City = "Santiago"},
                new Customers{Name = "Louies", ZIP = "3112", City = "Santiago"}
            });

            CustomerController controller = new CustomerController(mock.Object);

            //Act
            IEnumerable<Customers> result = (IEnumerable<Customers>)controller.Repository.Customers;
            Customers[] customerArray = result.ToArray();

            //Assert
            Assert.IsTrue(customerArray.Length == 4);
            Assert.IsTrue(customerArray[0].Name == "Hector");
            Assert.AreEqual(customerArray[0].CustomerID, 1);
        }

        [TestMethod]
        public void Can_Create_JobsEntrity()
        {
            //Arrange
            Mock<IEFEntityRepository> mock = new Mock<IEFEntityRepository>();
            mock.Setup(m => m.Jobs).Returns(new Jobs[] {
                new Jobs{JobID = 12, },
                new Jobs{JobID = 13, },
                new Jobs{JobID = 14, },
                new Jobs{JobID = 15, }
            });

            JobsController controller = new JobsController(mock.Object);

            //Act
            IEnumerable<Jobs> result = (IEnumerable<Jobs>)controller.Repository.Jobs;
            Jobs[] jobsArray = result.ToArray();

            //Assert
            Assert.IsFalse(jobsArray.Length == 5);
        }
    }
}
