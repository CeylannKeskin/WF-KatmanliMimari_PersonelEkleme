using KatmanliMimari_PersonelEkleme2_DAL;
using KatmanliMimari_PersonelEkleme2_Entities;

namespace KatmanliMimari_PersonelEkleme2_WinUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Context db;
        private void Form1_Load(object sender, EventArgs e)
        {
            db = new Context();
            rbErkek.Checked = true;
            btnTemizle.Enabled = false;
            btnIletisimBilgiGor.Enabled = db.Personeller.ToList().Count > 0 ? true : false;

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Metotlar.BosAlanVarmi(grpPersonelKayit))
            {
                MessageBox.Show("Boþ alan býrakmayýnýz");
            }
            else
            {
                Personel personel = db.Personeller.FirstOrDefault(x => x.TCKimlikNo == txtTcKimlikNo.Text);
                if (personel == null)
                {
                    personel = new Personel()
                    {
                        Isim = txtAd.Text,
                        Soyisim = txtSoyad.Text,
                        TCKimlikNo = txtTcKimlikNo.Text,
                        DogumTarihi = dtpDogumTarihi.Value,
                        Cinsiyet = rbErkek.Checked,
                        Birim = cmbBirimler.Text

                    };
                    db.Personeller.Add(personel);
                    db.SaveChanges();
                    btnTemizle.Enabled = btnIletisimBilgiGor.Enabled = true;
                    MessageBox.Show("Personel Baþarýlý bir þekilde eklendi");

                }
                else
                {
                    MessageBox.Show("Ayný TC No ile personel Ekleyemezsiniz");
                }
            }
        }
    }
}