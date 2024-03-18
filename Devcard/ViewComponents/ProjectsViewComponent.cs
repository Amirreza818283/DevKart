using Devcard.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace Devcard.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<Project>
            {
                new Project(1,"تاکسی","اپلیکیشن سفارش انلاین تاکسی","project-1.jpg","Atriya"),
                new Project(2,"زودفود","اپلیکیشن سفارش انلاین غذا","project-2.jpg","Zoodfood"),
                new Project(3,"فضاپیما","اپلیکیشن سفارش انلاین سفینه","project-3.jpg","Nasa"),
                new Project(4,"آموزشا","اپلیکیشن تماشای انلاین آموزش","project-4.jpg","Amoozesha"),
            };
            return View("_Projects",projects);
        }
    }
}
