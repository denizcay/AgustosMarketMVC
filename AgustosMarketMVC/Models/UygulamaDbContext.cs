using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgustosMarketMVC.Models
{
    public class UygulamaDbContext : DbContext
    {
        public UygulamaDbContext(DbContextOptions<UygulamaDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Kategori>().HasData(
                new Kategori(){Id = 1, KategoriAd = "Temizlik"},
                new Kategori(){Id = 2, KategoriAd = "Meyve/Sebze"});

            modelBuilder.Entity<Urun>().HasData(
                new Urun() { Id = 1, UrunAd = "Deterjan", BirimFiyat = 19.90m, KategoriId=1},
                new Urun() { Id = 2, UrunAd = "Sabun", BirimFiyat = 9.90m, KategoriId = 1 },                    
                new Urun() { Id = 3, UrunAd = "Temizlik Bezi", BirimFiyat = 9.90m, KategoriId = 1 },
                new Urun() { Id = 4, UrunAd = "Elma", BirimFiyat = 6.90m, KategoriId = 2 },
                new Urun() { Id = 5, UrunAd = "Karpuz", BirimFiyat = 5.00m, KategoriId = 2 },
                new Urun() { Id = 6, UrunAd = "Çilek", BirimFiyat = 15.40m, KategoriId = 2 }
                );
            }
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
    }
}
