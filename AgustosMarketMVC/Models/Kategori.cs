using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AgustosMarketMVC.Models
{
    public class Kategori
    {
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string KategoriAd { get; set; }

        public List<Urun> Urunler { get; set; }
    }
}
