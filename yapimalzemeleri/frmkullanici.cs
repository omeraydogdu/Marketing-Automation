using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using yapimalzemeleri.kategori;

namespace yapimalzemeleri
{
    public partial class frmkullanici : Form
    {
        public frmkullanici()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-4A657RK\\SQLEXPRESS;Initial Catalog=yapimalzemeleri;Integrated Security=True");
        SqlCommand komut;
        private void btnkaydolback_Click(object sender, EventArgs e)
        {
            frmmalzeme malzeme = new frmmalzeme();
            malzeme.Show();
            this.Hide();
        }
        private void frmkullanici_Load_1(object sender, EventArgs e)
        {
            txtkullaniciadk.Text = VeriTut.KullaniciAdi;
            txtsifrek.Text = VeriTut.KullaniciSifre;
            txttelefonk.Text = VeriTut.KullaniciTelefon;
            maskedtc.Text = VeriTut.KullaniciTc;
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            baglan.Open();           
            komut = new SqlCommand("Update KullaniciTable set KullaniciAd=@KullaniciAd,KullaniciSifre=@KullaniciSifre,KullaniciTelefon=@KullaniciTelefon, KullaniciTc=@KullaniciTc  where Id=@Id ", baglan);
            komut.Parameters.AddWithValue("@Id", VeriTut.KullaniciId);
            komut.Parameters.AddWithValue("@KullaniciAd", txtkullaniciadk.Text);
            komut.Parameters.AddWithValue("@KullaniciSifre", txtsifrek.Text);
            komut.Parameters.AddWithValue("@KullaniciTelefon", txttelefonk.Text);
            komut.Parameters.AddWithValue("@KullaniciTc", maskedtc.Text);
            komut.ExecuteNonQuery();
            komut.Dispose();
            baglan.Close();
            MessageBox.Show("Bilgileriniz Güncellenmiştir...");
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            komut = new SqlCommand("Delete from  KullaniciTable where Id=@Id",baglan);
            komut.Parameters.AddWithValue("@Id", VeriTut.KullaniciId);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Bilgileriniz Silinmiştir...");
            frmana ana=new frmana();
            ana.Show();
            this.Hide();
        }

        private void frmkullanici_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
