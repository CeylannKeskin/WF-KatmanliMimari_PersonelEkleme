using KatmanliMimari_PersonelEkleme2_DAL.Configurations;
using KatmanliMimari_PersonelEkleme2_Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimari_PersonelEkleme2_DAL
{
    public class Context:DbContext
    {
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<IletisimBilgisi> IletisimBilgisileri { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-2QLMN3P\\CEYLAN;Database=KatmanliMimariPersonelEkleme;User ID=SA;Password=1234567;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PersonelCongig())
                        .ApplyConfiguration(new IletisimBilgisiConfig());
        }
    }
}
