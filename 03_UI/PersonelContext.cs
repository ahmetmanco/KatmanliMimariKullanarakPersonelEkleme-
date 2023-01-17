using _01_EntityLayer;
using _02_DAL.Mapping;
using Microsoft.EntityFrameworkCore;

namespace _03_UI
{
    internal class PersonelContext : DbContext
    {
            public DbSet<Personel> Personeller { get; set; }
            public DbSet<IletisimBilgileri> IletisimBilgileris { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=PersonelEklemeDb;Trusted_Connection=True; encrypt=false;");
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {

                // Personel modelinin içerisindeki property'leri özelleştirmek için Fluent Apı kullanıyoruz ama burada kod kalabalığı yaptığından dolayı ayrı bir class içinde configure ediyoruz
                modelBuilder.ApplyConfiguration(new PersonelMapping());

                modelBuilder.ApplyConfiguration(new IletisimBilgisiMapping());
                base.OnModelCreating(modelBuilder);
            }
        }
    }