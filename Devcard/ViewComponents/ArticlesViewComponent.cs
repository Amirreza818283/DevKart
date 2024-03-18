using Devcard.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Devcard.ViewComponents
{
    public class ArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var article = new List<Article>
            {
                new Article(1,"سی شارپ چیست","سی شارپ یک زبان فوق العادست که...","blog-post-thumb-card-1.jpg"),
                new Article(2,"پایتون چیست","پایتون یک زبان فوق العادست که...","blog-post-thumb-card-2.jpg"),
                new Article(3,"پی اچ پی چیست","پی ایچ پی یک زبان فوق العادست که...","blog-post-thumb-card-3.jpg"),
            };
            return View("_Articles",article);
        }
    }
}
