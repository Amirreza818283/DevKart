using Devcard.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;


namespace Devcard.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Contact()
        {
            var model = new Contact();
            return View(model);
        }
        //[HttpPost]
        //public IActionResult Contact(IFormCollection form)
        //{
        //    var email = form["email"];
        //    return Json(Ok());
        //}
        [HttpPost]
        public IActionResult Contact(Contact form)
        {
            Console.WriteLine(form.ToString());
            return Json(Ok());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
