using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace Devcard.Controllers
{
    public class TestController : Controller
    {
        public FileResult Index()
        {
            var FileByte = System.IO.File.ReadAllBytes("wwwroot/123.zip");
            const string filename = "zippy.zip";
            return File(FileByte, MediaTypeNames.Application.Zip, filename);
        }
        public IActionResult fff()
        {
            return new StatusCodeResult(310);
        }
        public IActionResult ddd()
        {
            return Redirect("http://www.atriya.com");
        }

    }
}
