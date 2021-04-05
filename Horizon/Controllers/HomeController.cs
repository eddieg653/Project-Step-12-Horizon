using Horizon.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Horizon.Controllers
{
    public class HomeController : Controller
    {
        //C  r e a t e
        //R e a d
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Search()
        {
            return View();
        }
        public IActionResult MyCart()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }




        public IActionResult Details(int id = 0)
        {

            Product BlackJoggers = new Product();
            BlackJoggers.Id = id;
            BlackJoggers.ProductName = "Black Joggers";
            BlackJoggers.SupplierId = 2;
            BlackJoggers.CategoryId = 2;
            BlackJoggers.Price = 45.00;
            BlackJoggers.Gender = "Male";

            return View(BlackJoggers);
        }

        // U p d a t e 

        // D e l e t e
    }
}
