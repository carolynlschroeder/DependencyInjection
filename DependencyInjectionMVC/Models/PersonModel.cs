using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DependencyInjectionMVC.Models
{
    public class PersonModel
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Start Date")]
        public string StartDate { get; set; }
        public int Rating { get; set; }
    }
}