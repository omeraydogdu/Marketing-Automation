using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Controls;

namespace yapimalzemeleri
{
    public partial class frmkaydol : Form
    {
        public frmkaydol()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-4A657RK\\SQLEXPRESS;Initial Catalog=yapimalzemeleri;Integrated Security=True");
        kayıtsorgu sorgum=new kayıtsorgu();//mükerrer kayıt için oluşturdugumuz clası çağırdık.
        private void btnkaydolback_Click(object sender, EventArgs e)
        {
            frmana ana = new frmana();
            ana.Show();
            this.Hide();
        }
        private void btnkaydolk_Click(object sender, EventArgs e)
        {
            // tc textboxından kontrolu sağlıyoruz.
            sorgum.sorgula(txttck.Text);    //tcyi sorguladığımız method
            if (txttck.Text== sorgum.TCkm())//tcyi döndürdüğümüz method.
            {
                MessageBox.Show("Böyle bir kullanıcı mevcut...");
            }
            else if (txtkullaniciadk.Text == string.Empty || txtsifrek.Text == string.Empty || txttelefonk.Text == string.Empty || txttck.Text == string.Empty)
            {
                MessageBox.Show("Lütfen Bilgilerinizi Eksiksiz Giriniz...", "UYARI !!!");
            }
            else
            {
                baglan.Open();
                string kaydet = "Insert into KullaniciTable(KullaniciAd,KullaniciSifre,KullaniciTelefon,KullaniciTc) values(@KullaniciAd,@KullaniciSifre,@KullaniciTelefon,@KullaniciTc)";
                SqlCommand komut = new SqlCommand(kaydet, baglan);
                komut.Parameters.AddWithValue("KullaniciAd", txtkullaniciadk.Text);
                komut.Parameters.AddWithValue("KullaniciSifre", txtsifrek.Text);
                komut.Parameters.AddWithValue("KullaniciTelefon", txttelefonk.Text);
                komut.Parameters.AddWithValue("KullaniciTc", txttck.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kaydınız Tamamlanmıştır...", "BİLGİ !!!");
                txtkullaniciadk.Text = "";
                txtsifrek.Text = "";
                txttelefonk.Text = "";
                txttck.Text = "";
                komut.Dispose();
                baglan.Close();
            }

        }

        private void btnkaydolk_MouseEnter(object sender, EventArgs e)
        {
            btnkaydolk.BackColor = Color.Red;
        }

        private void btnkaydolk_MouseLeave(object sender, EventArgs e)
        {
            btnkaydolk.BackColor = Color.Teal;
        }

        private void frmkaydol_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
