﻿// <auto-generated />
using AgustosMarketMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AgustosMarketMVC.Migrations
{
    [DbContext(typeof(UygulamaDbContext))]
    partial class UygulamaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AgustosMarketMVC.Models.Kategori", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KategoriAd")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Kategoriler");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            KategoriAd = "Temizlik"
                        },
                        new
                        {
                            Id = 2,
                            KategoriAd = "Meyve/Sebze"
                        });
                });

            modelBuilder.Entity("AgustosMarketMVC.Models.Urun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("BirimFiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.Property<string>("UrunAd")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("KategoriId");

                    b.ToTable("Urunler");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirimFiyat = 19.90m,
                            KategoriId = 1,
                            UrunAd = "Deterjan"
                        },
                        new
                        {
                            Id = 2,
                            BirimFiyat = 9.90m,
                            KategoriId = 1,
                            UrunAd = "Sabun"
                        },
                        new
                        {
                            Id = 3,
                            BirimFiyat = 9.90m,
                            KategoriId = 1,
                            UrunAd = "Temizlik Bezi"
                        },
                        new
                        {
                            Id = 4,
                            BirimFiyat = 6.90m,
                            KategoriId = 2,
                            UrunAd = "Elma"
                        },
                        new
                        {
                            Id = 5,
                            BirimFiyat = 5.00m,
                            KategoriId = 2,
                            UrunAd = "Karpuz"
                        },
                        new
                        {
                            Id = 6,
                            BirimFiyat = 15.40m,
                            KategoriId = 2,
                            UrunAd = "Çilek"
                        });
                });

            modelBuilder.Entity("AgustosMarketMVC.Models.Urun", b =>
                {
                    b.HasOne("AgustosMarketMVC.Models.Kategori", "Kategori")
                        .WithMany("Urunler")
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("AgustosMarketMVC.Models.Kategori", b =>
                {
                    b.Navigation("Urunler");
                });
#pragma warning restore 612, 618
        }
    }
}
