using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DependencyInjectionMVC.Models;
using DependencyInjectionRepositories;
using DependencyInjectionRepositories.Interfaces;

namespace DependencyInjectionMVC.Controllers
{
    public class HomeController : Controller
    {
        private IPeopleRepository _repository;


        public HomeController(IPeopleRepository repository)
        {
            _repository = repository;
        }


        public ActionResult Index()
        {
            var model = _repository.GetPeople()
                .Select(
                    p => new PersonModel
                    {
                        FirstName = p.FirstName,
                        LastName = p.LastName,
                        StartDate = p.StartDate.ToShortDateString(),
                        Rating = p.Rating
                    });
            return View(model);
        }
    }
}