
using _932101.Nasution.Rafly.lab11.Models;
using lab11.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;



namespace _932101.Nasution.Rafly.lab11.Controllers
{
    public class HomeController : Controller
    {
        private Random r = new Random();
        public int num1;
        public int num2;
        public string add;
        public string sub;
        public string mult;
        public string div;

        public HomeController()
        {
            num1 = r.Next(0, 11);
            num2 = r.Next(0, 11);
            add = $"{num1} + {num2} = {num1 + num2}";
            sub = $"{num1} - {num2} = {num1 - num2}";
            mult = $"{num1} * {num2} = {num1 * num2}";
            if (num2 == 0)
            {
                div = $"{num1} / {num2} = infinity";
            }
            else if (num2 > num1)
            {
                div = $"{num1} / {num2} = 0";
            }
            else
            {   

                div = $"{num1} / {num2} = {Math.Round((double)num1 / num2, 2)}";
            }
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ModelCalc()
        {
            var calcModel = new Calculate(num1, num2, add, sub, mult, div);
            return View(calcModel);
        }

        public IActionResult ViewDataCalc()
        {
            ViewData["num1"] = num1;
            ViewData["num2"] = num2;
            ViewData["add"] = add;
            ViewData["sub"] = sub;
            ViewData["mult"] = mult;
            ViewData["div"] = div;
            return View();
        }

        public IActionResult ViewBagCalc()
        {
            ViewBag.num1 = num1;
            ViewBag.num2 = num2;
            ViewBag.add = add;
            ViewBag.sub = sub;
            ViewBag.mult = mult;
            ViewBag.div = div;
            return View();
        }

        public IActionResult ServiceInjCalc()
        {
            return View(this);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}