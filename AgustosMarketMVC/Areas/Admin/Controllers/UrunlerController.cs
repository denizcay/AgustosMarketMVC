using AgustosMarketMVC.Models;
using AgustosMarketMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgustosMarketMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UrunlerController : Controller
    {
        private readonly UygulamaDbContext _context;

        public UrunlerController(UygulamaDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Urunler.ToList());
        }

        public IActionResult Yeni()
        {
            ViewBag.Kategoriler = _context.Kategoriler.Select(k => new SelectListItem()
            {
                Text = k.KategoriAd,
                Value = k.Id.ToString()
            }).ToList();
            return View();
        }
        [HttpPost]
        public IActionResult Yeni(Urun urun)
        {
            if (ModelState.IsValid)
            {
                _context.Add(urun);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Duzenle(int uid)
        {
            HomeViewModel vm = new HomeViewModel();
            vm.SeciliUrun = _context.Urunler.Where(x => x.Id == uid).First();
            vm.SKategoriler =_context.Kategoriler.Select(x => new SelectListItem()
            {
                Text = x.KategoriAd,
                Value = x.Id.ToString()
            }).ToList();
            vm.Urunler = _context.Urunler.ToList();
            return View(vm);
        }
        [HttpPost]
        public IActionResult Duzenle(HomeViewModel hvm)
        {
            if (!ModelState.IsValid)
                return View();

            _context.Update(hvm.SeciliUrun);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
       

    }
}
