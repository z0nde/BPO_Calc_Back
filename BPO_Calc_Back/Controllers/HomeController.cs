using BPO_Calc_Back.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BPO_Calc_Back.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
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

        [HttpPost]
        public IActionResult Sum(CalcViewModel calc)
        {
            if(calc.Calculate == "Sum")
                ViewData["Result"] = calc.Value1 + calc.Value2;
            return View();
        }

        [HttpPost]
        public IActionResult Sub(CalcViewModel calc)
        {
            if (calc.Calculate == "Sub")
                ViewData["Result"] = calc.Value1 - calc.Value2;
            return View();
        }

        [HttpPost]
        public IActionResult Mult(CalcViewModel calc)
        {
            if (calc.Calculate == "Mult")
                ViewData["Result"] = calc.Value1 * calc.Value2;
            return View();
        }

        [HttpPost]
        public IActionResult Div(CalcViewModel calc)
        {
            if (calc.Calculate == "Div")
                ViewData["Result"] = calc.Value1 / calc.Value2;
            return View();
        }

        [HttpPost]
        public IActionResult Pow(CalcViewModel calc)
        {
            if (calc.Calculate == "Pow")
                ViewData["Result"] = Math.Pow(calc.Value1, calc.Value2);
            return View();
        }
    }
}