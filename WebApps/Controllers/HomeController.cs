using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApps.Models;
//creates a reference to the Distance converter
using ConsoleAppProject.App01;
using ConsoleAppProject.App02;


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
        [HttpGet]
        public IActionResult BMI()
        {
            return View();
        }
        [HttpPost]
        public IActionResult BMI(BMI bmiCalculator)
        {
            if (bmiCalculator.Metres > 1.40)
            {
                bmiCalculator.GetMetricBMI();
            }
            else if(bmiCalculator.Feet > 4 && bmiCalculator.Stones > 6)
            {
                bmiCalculator.GetImperialBMI();
            }
            else
            {
                ViewBag.Error = "You have entered values too small for any adult";
                return View();
            }
            double bmiIndex = bmiCalculator.Bmi;
            return RedirectToAction("HealthMessage", new { bmiIndex });
        }
        public IActionResult HealthMessage(double bmiIndex)
        {
            return View(bmiIndex);
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
