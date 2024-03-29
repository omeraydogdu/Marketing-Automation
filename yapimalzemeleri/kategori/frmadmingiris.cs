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

namespace yapimalzemeleri.kategori
{
    public partial class frmadmingiris : Form
    {
        public frmadmingiris()
        {
            InitializeComponent();
        }

        private void btnbackadmin_Click(object sender, EventArgs e)
        {
            frmgiris giris=new frmgiris();
            giris.Show();
            this.Hide();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-4A657RK\\SQLEXPRESS;Initial Catalog=yapimalzemeleri;Integrated Security=True");
        private void btnkaydola_Click(object sender, EventArgs e)
        {
            //eğer textboxlar boş iken butona basılacak ise verilecek hata mesajı.
            if (txttca.Text==string.Empty || txtsifrea.Text==string.Empty)
            {
                MessageBox.Show("Lütfen Bilgilerinizi Eksiksiz Giriniz...", "UYARI !!!");
            }
            else 
            {
                //istenılen bilgiler dogru yerlere  girilmiş ise dbye kaydetme işlemi.
                baglan.Open();
                string kaydol = "Insert into AdminTable(AdminTc,AdminSifre) values(@AdminTc,@AdminSifre)";
                SqlCommand komut = new SqlCommand(kaydol, baglan);
                komut.Parameters.AddWithValue("AdminTc", txttca.Text);
                komut.Parameters.AddWithValue("AdminSifre", txtsifrea.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kaydınız Tamamlanmıştır...", "BİLGİ !!!");
                txttca.Text = "";
                txtsifrea.Text = "";
                komut.Dispose();
                baglan.Close();
            }
        }

        private void btnkaydola_MouseEnter(object sender, EventArgs e)
        {
            btnkaydola.BackColor = Color.Red;
        }

        private void btnkaydola_MouseLeave(object sender, EventArgs e)
        {
            btnkaydola.BackColor = Color.Teal;
        }

        private void frmadmingiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
