using AgustosMarketMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgustosMarketMVC.ViewModels
{
    public class HomeViewModel
    {
        public int? SeciliKategoriId { get; set; }
        public int? SeciliUrunId { get; set; }
        public List<Kategori> Kategoriler { get; set; }
        public List<Urun> Urunler { get; set; }
        public Urun SeciliUrun { get; set; }
        public List<SelectListItem> SKategoriler { get; set; }
    }
}
