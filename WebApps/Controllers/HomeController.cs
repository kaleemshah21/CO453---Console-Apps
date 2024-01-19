using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApps.Models;
//creates a reference to the Distance converter
using ConsoleAppProject.App01;


namespace WebApps.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        /*if there is a FromDistance entered, it will then call the 
         * CalculateDistance method and returns the value.
        */
        public IActionResult DistanceConverter(DistanceConverter converter)
        {
            if(converter.FromDistance > 0)
            {
                converter.CalculateDistance();
            }
            return View(converter);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
