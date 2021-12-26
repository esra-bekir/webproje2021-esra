using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace organic.Models
{
    public class Kategori
    {
        public int Id { get; set; }

        [Required]
        [Display(Name ="Kategori Adı")]
        public string Ad { get; set; }

    }
}
