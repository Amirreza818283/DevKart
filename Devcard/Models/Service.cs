using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Devcard.Models
{
    public class Service
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Service(int iD, string name)
        {
            ID = iD;
            Name = name;
        }
    }
}
