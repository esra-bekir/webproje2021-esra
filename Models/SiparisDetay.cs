using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace organic.Models
{
    public class SiparisDetay
    {
        public int Id { get; set; }

        public int? UrunId { get; set; }
        [ForeignKey("UrunId")]
        public Urun Urun { get; set; }

        public int? SiparisId { get; set; }
        [ForeignKey("SiparisId")]
        public Siparis Siparis { get; set; }

        public double Miktar { get; set; }

        public double Fiyat { get; set; }
        [NotMapped]
        public double Ucret
        {
            get
            {
                return Miktar * Fiyat;
            }
        }
    }
}
