using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AgustosMarketMVC.Models
{
    public class Urun
    {
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string UrunAd { get; set; }
        public decimal BirimFiyat { get; set; }
        public int KategoriId { get; set; }
        public Kategori Kategori { get; set; }
    }
}
