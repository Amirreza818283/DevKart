using Devcard.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Diagnostics;


namespace Devcard.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Service> _services = new List<Service>()
        {
          new Service(1,"Bronze"),
          new Service(2,"Silver"),
          new Service(3,"Gold"),
          new Service(4,"Diamond")

        };

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Contact()
        {
            var model = new Contact()
            {
                Services = new SelectList(_services, "ID", "Name")
            };
            return View(model);
        }
        //[HttpPost]
        //public IActionResult Contact(IFormCollection form)
        //{
        //    var email = form["email"];
        //    return Json(Ok());
        //}
        [HttpPost]
        public IActionResult Contact(Contact model)
        {
            model.Services = new SelectList(_services, "ID", "Name");
            if (!ModelState.IsValid)
            {
                ViewBag.error = "اطلاعات وارد شده صحیح نیست";
                return View(model);
            }
            ModelState.Clear();
            model = new Contact
            {
                Services = new SelectList(_services, "ID", "Name")
            };
         
             ViewBag.success = "ثبت شد";
             return View();
        }
           
    

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
