using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace organic.Models
{
    public class Foto
    {
        public int Id { get; set; }

        public string FotoAd { get; set; }

        public int? UrunId { get; set; }
        [ForeignKey("UrunId")]
        public Urun Urun {get; set; }
    }
}
