using AgustosMarketMVC.Models;
using AgustosMarketMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AgustosMarketMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UygulamaDbContext _context;

        public HomeController(ILogger<HomeController> logger, UygulamaDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index(int? kid)
        {
            HomeViewModel vm = new HomeViewModel();
            vm.SeciliKategoriId = kid;
            vm.Kategoriler = _context.Kategoriler.ToList();
            IQueryable<Urun> urunler = _context.Urunler;
            if (kid != null)
                urunler = urunler.Where(x => x.KategoriId == kid);
            vm.Urunler = urunler.ToList();
            //if (kid == null)
            //{
            //    vm.Urunler = _context.Urunler.ToList();
            //}
            //else
            //{
            //    vm.Urunler = _context.Urunler.Where(x => x.KategoriId == kid).ToList();
            //}
            return View(vm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
