using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Soapure.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();//modify the HelloWorldController class to use Razor view files
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        public IActionResult Welcome(string name, int numTimes = 1)//changing the Welcome method to add a Message and NumTimes value to the ViewData dictionary
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
