﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace organic.Models
{
    public class Urun
    {
        public int Id { get; set; }

        [Required]
        [Display(Name="Ürün Adı")]
        public string Ad { get; set; }
        [Range(1,int.MaxValue)]
        public double Fiyat { get; set; }

        public double Miktar { get; set; }

        public Birim Birim { get; set; }

        public string UretimYeri { get; set; }

        public string Aciklama { get; set; }

        public int? KategoriId { get; set; }
        [ForeignKey("KategoriId")]
        public Kategori Kategori { get; set; }

        public ICollection<Foto> Foto { get; set; }
    }

    public enum Birim
    {
        Adet,
        Kg,
        Litre,
        Kasa
    }
}
