using KatmanliMimari_PersonelEkleme2_Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimari_PersonelEkleme2_DAL.Configurations
{
    public class PersonelCongig : IEntityTypeConfiguration<Personel>
    {
        public void Configure(EntityTypeBuilder<Personel> builder)
        {
            builder.ToTable("Personeller");

            builder.HasKey(x => x.PersonelID);
            builder.Property(x => x.Isim).IsRequired().HasMaxLength(30);
            builder.Property(x => x.Soyisim).IsRequired().HasMaxLength(50);
            builder.Property(x => x.TCKimlikNo).IsRequired().HasMaxLength(11).HasColumnType("char");
            builder.Property(x => x.DogumTarihi).HasColumnType("datetime2");
            builder.Property(x => x.Birim).IsRequired().HasMaxLength(20);
            builder.Ignore(x => x.IsimSoyisim);//database eeklenmeyecek

            builder.HasOne(x => x.IletisimBilgisi).WithOne(x => x.Personel);

        }
        
    }
}
