using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Devcard.Models
{
    public class Contact
    {
        [Required(ErrorMessage ="یچیزی")]
        public string Name { get; set; }

        [Required(ErrorMessage = "یچیزی")]
        [EmailAddress]
        public string Email { get; set; }
        public string Message { get; set; }
        public string Service { get; set; }
    }
}
