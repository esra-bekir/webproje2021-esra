using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace organic.Models
{
    public class Kampanya
    {
        public int Id { get; set; }

        public string Ad { get; set; }  //IND25, KARGO

        public DateTime Baslangic { get; set; } //23.11

        public DateTime Bitis { get; set; }//25.11

        public double IndirimOran { get; set; }//100

        public double MinimumDeger { get; set; }//500




    }
}
