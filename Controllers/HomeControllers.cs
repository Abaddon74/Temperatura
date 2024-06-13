using System;
using System.Web.Mvc;
using Temperatura.Models;

namespace Temperatura.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // POST: Home/Convert
        [HttpPost]
        public ActionResult Convert(double celsius)
        {
            double fahrenheit = TemperatureConverter.CelsiusToFahrenheit(celsius);
            ViewBag.Fahrenheit = fahrenheit;
            return RedirectToAction("Index");
        }
    }
}
