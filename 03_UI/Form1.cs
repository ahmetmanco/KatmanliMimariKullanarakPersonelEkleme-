using _01_EntityLayer;

namespace _03_UI
{
    public partial class Form1 : Form
    {
        Form1 ilkform;
        public Form1()
        {
            InitializeComponent();
            _ = ilkform;
            
        }
        PersonelContext context; // Context class'ý public deðilse buraya gelemez
        private void Form1_Load(object sender, EventArgs e)
        {
            context = new PersonelContext();
            BirimleriDoldur();
            
        }

        private void BirimleriDoldur()
        {
            cmbBirim.Items.AddRange(new object[] { "IK", "Finans", "IT" });
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!Metotlar.BosVarmi(groupBox1))
            {
                Personel personel = new Personel()
                {
                Isim = txtAd.Text,
                Soyisim = txtSoyad.Text,
                TCKimlikNo = txtTCKimlik.Text,
                //personel.Birim = cmbBirim.SelectedText;
                DogumTarihi = dateTimePicker1.Value,
                Cinsiyet = rbtErkek.Checked || rbtKadin.Checked,
            };
                context.Personeller.Add(personel);

                context.SaveChanges();

                MessageBox.Show("Kayýt baþarýyla eklenmiþtir");
            }
            else
            { 
                MessageBox.Show("Lütfen boþ alan býrakmayýnýz"); 
            }
        }
        private void btnTemizle()
        {
           Metotlar.Temizle(groupBox1);
        } 
        private void btnIletisimBilgileriniGor_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }
        private void btnTemiz_Click(object sender, EventArgs e)
        {
            btnTemizle();
        }
    }
}