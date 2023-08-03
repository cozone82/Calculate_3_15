using Calculate_3_15.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Calculate_3_15.Controllers
{
    public class HomeController : Controller
    {
    

        

        [HttpGet]
        public IActionResult Index()
        {
            var model = new Calculate();

            return View(model);
        }

        [HttpPost]
        public IActionResult Index(Calculate model)
        {
            //*********TO USE THE COMMENTED CODE YOU MUST COMMENT OUT THE HIGHLIGHTED CODE BELOW AND THE METHODS IN THE MODEL//
            //model.Sum = Convert.ToString("Sum is " + (model.Num1 + model.Num2));
            //model.Product = Convert.ToString("Proudct is " + (model.Num1 * model.Num2));
            //model.Difference = Convert.ToString("Difference is " + (model.Num1 - model.Num2));
            //model.Quotient = Convert.ToString("Quotient is " + (model.Num1 / model.Num2));

            model.Sum = Convert.ToString("Sum is " + (model.SumOfNumbers()));
            model.Product = Convert.ToString("Proudct is " + (model.ProductOfNumbers()));
            model.Difference = Convert.ToString("Difference is " + (model.DifferenceOfNumbers()));
            model.Quotient = Convert.ToString("Quotient is " + (model.QuotientOfNumbers()));
            return View(model);
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