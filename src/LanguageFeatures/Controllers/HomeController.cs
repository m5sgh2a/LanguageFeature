using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanguageFeatures.Model;
using Microsoft.AspNetCore.Mvc;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public string Index(int input)
        {
            return string.Format("Index with parameter {0}", input);
        }

        public string Baum()
        {
            return "Baum";
        }

        public ViewResult AutoProperty()
        {
            Product product = new Product()
            {
                Name = "Hayek"
            };

            return View("Result", (object)string.Format("Product name: {0}", product.Name));
        }
    }
}
