using _01_EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_UI
{
    public partial class Form2 : Form
    {
        Form1 ilkform;
        public Form2(Form1 frm1)
        {
            Form1 ilkform = frm1;
            InitializeComponent();
        }
        PersonelContext context;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            context= new PersonelContext();
            cmbPersoneller.DataSource = context.Personeller.ToList();
            cmbPersoneller.DisplayMember = "IsimSoyisim";
            cmbPersoneller.ValueMember = "PersonelID";
            cmbPersoneller.SelectedIndex = -1;
        }
        private void btnYeniPersonel_Click(object sender, EventArgs e)
        {
            ilkform.Show();
            this.Hide();
        }
        private void cmbPersoneller_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPersoneller.SelectedIndex = -1;
        }
        private void btnGirisVeyaGuncelle_Click(object sender, EventArgs e)
        {
            if(cmbPersoneller.SelectedValue!= null)
            {
               IletisimBilgileri? ıletisim = context.IletisimBilgileris.Find(Convert.ToInt32(cmbPersoneller.SelectedValue));
                if (ıletisim != null)
                {
                    txtAdres.Text = ıletisim.Adres;
                    txtEposta.Text = ıletisim.Eposta;
                    txtTel.Text = ıletisim.Telefon;
                }
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbPersoneller.SelectedValue != null)
            {
                IletisimBilgileri? ıletisim = context.IletisimBilgileris.Find(Convert.ToInt32(cmbPersoneller.SelectedValue));
                if (ıletisim != null)
                {
                    ıletisim.Telefon = txtTel.Text;
                    ıletisim.Eposta = txtEposta.Text;
                    ıletisim.Adres = txtAdres.Text;
                }
                else
                {
                    IletisimBilgileri iletisim = new IletisimBilgileri();
                    iletisim.Telefon = txtTel.Text;
                    iletisim.Eposta = txtEposta.Text;
                    iletisim.Adres = txtAdres.Text;
                    iletisim.PersonelId = Convert.ToInt32(cmbPersoneller.SelectedValue);
                    context.IletisimBilgileris.Add(iletisim);
                }
                context.SaveChanges();
            }
            
        }
    }
}
