using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DependencyInjectionMVC;
using DependencyInjectionMVC.Controllers;
using DependencyInjectionMVC.Models;
using DependencyInjectionRepositories.Entities;
using DependencyInjectionRepositories;
using DependencyInjectionRepositories.Interfaces;
using Moq;

namespace DependencyInjectionMVC.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        public IPeopleRepository GetTestRepository()

        {
            var people = new List<Person>()
            {

                new Person() {FirstName = "John", LastName = "Smith",
                    Rating = 7, StartDate = new DateTime(2000, 10, 1)},
                new Person() {FirstName = "Mary", LastName = "Thomas",
                    Rating = 9, StartDate = new DateTime(1971, 7, 23)},
            };
            var repoMock = new Mock<IPeopleRepository>();
            repoMock.Setup(r => r.GetPeople()).Returns(people);
            return repoMock.Object;

        }

        [TestMethod]
        public void Index()
        {
            // Arrange
            var repository = GetTestRepository();
            HomeController controller = new HomeController(repository);
 
            // Act
            ViewResult result = controller.Index() as ViewResult;
            var model = (IEnumerable <PersonModel>)result.Model;

            // Assert
            Assert.AreEqual(2,model.Count());
        }
    }
}
