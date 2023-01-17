using _01_EntityLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_DAL.Mapping
{
    public class PersonelMapping : IEntityTypeConfiguration<Personel>
    {
        public void Configure(EntityTypeBuilder<Personel> builder)
        {
            //fLuent Apı ile personel classını özelleştiriyoruz
            builder.ToTable("Personeller"); // veri tabanında bu isimde görünsün
            builder.HasKey(x => x.PersonelId); // primary keyi tanımladık

            builder.Property(x => x.Isim)
                .IsRequired().HasMaxLength(30);// isim zorunlu olsun istedik- 30 karakter

            builder.Property(x => x.Soyisim)
                .IsRequired().HasMaxLength(30);// isim zorunlu olsun istedik- 30 karakter

            builder.Property(x => x.TCKimlikNo)
                .IsRequired().HasMaxLength(11).HasColumnType("char");//  zorunlu olsun istedik- 11 karakter

            builder.Property(x => x.DogumTarihi)
                .IsRequired().HasColumnType("datetime2");// isim zorunlu olsun istedik- 30 karakter

            builder.Property(x => x.Birim)
                .HasMaxLength(20);// birim olsun istedik- 20 karakter

            builder.Ignore(x => x.IsimSoyisim);// veri tabanında olmayacak

            //İlişkiyi tanımlamak için 1e 1 
            builder.HasOne(x => x.IletisimBilgisi)
                .WithOne(y => y.Personel)
                .HasForeignKey<IletisimBilgileri>(z => z.PersonelId);
        }
    }
}
