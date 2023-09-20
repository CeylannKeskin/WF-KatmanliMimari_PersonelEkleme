using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimari_PersonelEkleme2_Entities
{
    public class Personel
    {
        public int PersonelID { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string TCKimlikNo { get; set; }
        public DateTime DogumTarihi { get; set; }
        public bool Cinsiyet { get; set; }
        public string Birim { get; set; }
        public string IsimSoyisim { get {return Isim+" "+Soyisim; } }//veritabanına eklenmeyecek.confg tab ignor ile belirtilmeli
        public IletisimBilgisi IletisimBilgisi { get; set; }

    }
}
