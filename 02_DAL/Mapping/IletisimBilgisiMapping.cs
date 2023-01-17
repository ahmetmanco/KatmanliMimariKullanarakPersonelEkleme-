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
    public class IletisimBilgisiMapping : IEntityTypeConfiguration<IletisimBilgileri>
    {
        public void Configure(EntityTypeBuilder<IletisimBilgileri> builder)
        {
            builder.ToTable("IletisimBilgileri");
            builder.HasKey(x => x.PersonelId);
            builder.Property(x => x.Eposta).HasColumnType("nvarchar").HasMaxLength(70);

            builder.Property(x => x.Adres).HasColumnType("nvarchar").HasMaxLength(255);

            //Not:tablolar arasında 1e 1 ilişki olduğundan,tekrar yazmaya gerek yok
        }
    }
}
