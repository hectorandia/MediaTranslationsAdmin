using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;
using Moq;
using MediaAdmin.Abstract;
using MediaAdmin.MediaEntity;
using MediaWebView.Controllers;
using MediaWebView.Models;

namespace MediaUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Can_Create_CustomerEntity()
        {
            ////Arrange
            //Mock<IEFEntityRepository> mock = new Mock<IEFEntityRepository>();
            //mock.Setup(m => m.Customers).Returns(new Customers[] {
            //    new Customers{CustomerID = 1, Name = "Hector", ZIP = "39112", City = "Iquique"},
            //    new Customers{Name = "Carlos", ZIP = "392", City = "Magdeburg"},
            //    new Customers{Name = "Juan", ZIP = "3912", City = "Santiago"},
            //    new Customers{Name = "Louies", ZIP = "3112", City = "Santiago"}
            //});

            ////CustomerController controller = new CustomerController(mock.Object);

            ////Act
            ////IEnumerable<Customers> result = (IEnumerable<Customers>)controller.Repository.Customers;
            //Customers[] customerArray = result.ToArray();

            ////Assert
            //Assert.IsTrue(customerArray.Length == 4);
            //Assert.IsTrue(customerArray[0].Name == "Hector");
            //Assert.AreEqual(customerArray[0].CustomerID, 1);
        }

        [TestMethod]
        public void Can_Create_JobsEntrity()
        {
            ////Arrange
            //Mock<IEFEntityRepository> mock = new Mock<IEFEntityRepository>();
            //mock.Setup(m => m.Jobs).Returns(new Jobs[] {
            //    new Jobs{JobID = 12, },
            //    new Jobs{JobID = 13, },
            //    new Jobs{JobID = 14, },
            //    new Jobs{JobID = 15, }
            //});

            ////JobsController controller = new JobsController(mock.Object);

            ////Act
            //IEnumerable<Jobs> result = (IEnumerable<Jobs>)controller.Repository.Jobs;
            //Jobs[] jobsArray = result.ToArray();

            ////Assert
            //Assert.IsFalse(jobsArray.Length == 5);
        }

        //[TestMethod]
        //public void Can_Paginate()
        //{
        //    //Arrange
        //    Mock<IEFCustomerRepository> mock = new Mock<IEFCustomerRepository>();
        //    mock.Setup(m => m.Customers).Returns(new Customer[] {
        //        new Customer{CustomerID = 12, },
        //        new Customer{CustomerID = 13, },
        //        new Customer{CustomerID = 14, },
        //        new Customer{CustomerID = 15, },
        //        new Customer{ CustomerID = 16, }
        //    });
        //    CustomerController controller = new CustomerController(mock.Object);
        //    controller.PageSize = 3;

        //    //Act
        //    CustomersListViewModel result = (CustomersListViewModel)controller.List(null, 2).Model;
        //    //Assert
        //    Customer[] array = result.Customers.ToArray();
        //    Assert.IsTrue(array.Length == 2);
        //    Assert.AreEqual(array[0].CustomerID, 15);
        //    Assert.AreEqual(array[1].CustomerID, 16);

        //}

        [TestMethod]
        public void Can_Filter_City()
        {
            //Arrange
            Mock<IEFCustomerRepository> mock = new Mock<IEFCustomerRepository>();
            mock.Setup(m => m.Customers).Returns(new Customer[] {
                new Customer{CustomerID = 1, City = "Chile" },
                new Customer{CustomerID = 2, City = "Alemania"},
                new Customer{CustomerID = 3, City = "Bolivia"},
                new Customer{CustomerID = 4, City = "Alemania"},
                new Customer{ CustomerID = 5, City = "Bolivia"}
            });
            //NavController target = new NavController(mock.Object);
            //Act
            //string[] result = ((IEnumerable<string>)target.Menu().Model).ToArray();

            //Assert
            //Assert.AreEqual(result.Length, 3);
            //Assert.AreEqual(result[2], "Chile");
            
        }

        [TestMethod]
        public void Can_Delete_Valid_Customer()
        {
            //Arrange create new Customer
            Customer customer = new Customer { CustomerID = 2, Name = "Test" };

            //Create mock repository
            Mock<IEFCustomerRepository> mock = new Mock<IEFCustomerRepository>();
            mock.Setup(c => c.Customers).Returns(new Customer[]
                {
                    new Customer{ CustomerID = 1, Name = "Luchito"},
                    customer,
                    new Customer{CustomerID = 3, Name = "Titin"}
                });

            AdminCustomerController target = new AdminCustomerController(mock.Object);

            target.Delete(customer.CustomerID);

            //Assert
            mock.Verify(c => c.DeleteCustomer(customer.CustomerID));
        }
    }
}
