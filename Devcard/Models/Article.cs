using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Devcard.Models
{
    public class Article
    {
        public long ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        public Article(long iD, string title, string description, string image)
        {
            ID = iD;
            Title = title;
            Description = description;
            Image = image;
        }
    }
}
