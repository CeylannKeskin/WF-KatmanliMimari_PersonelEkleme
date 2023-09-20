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
    public class IletisimBilgisiConfig : IEntityTypeConfiguration<IletisimBilgisi>
    {
        public void Configure(EntityTypeBuilder<IletisimBilgisi> builder)
        {
            builder.ToTable("IletisimBilgileri");
            builder.HasKey(x => x.PersonelID);
            builder.Property(x => x.Eposta).HasColumnType("nvarchar").HasMaxLength(75);
            builder.Property(x => x.Telefon).HasColumnType("varchar").HasMaxLength(15);
            builder.Property(x => x.Adres).HasMaxLength(255);

            
        }
    }
}
