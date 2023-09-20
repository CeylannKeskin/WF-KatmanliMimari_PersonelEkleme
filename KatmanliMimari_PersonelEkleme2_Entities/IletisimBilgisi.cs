namespace KatmanliMimari_PersonelEkleme2_Entities
{
    public class IletisimBilgisi
    {
        public int PersonelID { get; set; }
        public string Eposta { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }

        public Personel Personel { get; set; }
    }
}