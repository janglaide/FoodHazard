using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace FoodHazardAnalysis.Web.Models
{
    public class ApplicationUser: IdentityUser
    {
        public ApplicationUser()
        {

        }

        public double Weight { get; set; }
        public double Height { get; set; }
        public int Age { get; set; }
    }
}