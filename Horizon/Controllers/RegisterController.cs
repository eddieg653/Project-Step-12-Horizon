using Horizon.Models;
using Microsoft.AspNetCore.Mvc;

namespace Horizon.Controllers
{
    public class RegisterController : Controller
    {
        // Methods

        // C r e a t e
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Register NewUser)
        {
            return RedirectToAction("Details", NewUser);
        }
        public IActionResult Details(Register NewUser)
        {
            return View(NewUser);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Register e = new Register();
            e.Id = id;
            e.Name = "Eddie";
            e.Address = null;
            e.City = null;
            e.Region = null;
            e.Zip = null;
            e.Country = null;
            e.Phone = null;
            e.Email = null;
            e.Password = null;
            return View(e);
        }
        [HttpPost]
        public IActionResult Edit(Register e)
        {
            return RedirectToAction("Details", e);
        }

        // R e a d

        // U p d a t e

        // D e l e t e
    }
}
