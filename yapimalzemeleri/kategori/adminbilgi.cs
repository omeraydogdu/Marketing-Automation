using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yapimalzemeleri.kategori
{
    public partial class adminbilgi : Form
    {
        public adminbilgi()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-4A657RK\\SQLEXPRESS;Initial Catalog=yapimalzemeleri;Integrated Security=True");
        SqlCommand komut;

        private void btnkaydolback_Click(object sender, EventArgs e)
        {
            adminkatalog katalog= new adminkatalog();   
            katalog.Show();
            this.Hide();
        }

        private void adminbilgi_Load(object sender, EventArgs e)
        {
            //adminin nilgisini giriş formunda tutan clastan alıyoruz.
            txtadmintca.Text = VeriAdmin.AdminTc;
            txtadmins.Text = VeriAdmin.AdminSifre;
        }

        private void btngüncellea_Click(object sender, EventArgs e)
        {
            //admin bilgilerini güncelleme işlemi.
            baglan.Open();
            komut = new SqlCommand("Update AdminTable set AdminTc=@AdminTc, AdminSifre=@AdminSifre where Id=@Id", baglan);
            komut.Parameters.AddWithValue("Id", VeriAdmin.AdminId);
            komut.Parameters.AddWithValue("@AdminTc", txtadmintca.Text);
            komut.Parameters.AddWithValue("@AdminSifre", txtadmins.Text);      
            komut.ExecuteNonQuery();
            komut.Dispose();//rami  temizler
            baglan.Close();
            MessageBox.Show("Bilgileriniz Güncellenmiştir...");
        }

        private void btnsila_Click(object sender, EventArgs e)
        {
            //admin bilgilerini silme işlemi
            baglan.Open();
            komut = new SqlCommand("Delete AdminTable where Id=@Id", baglan);
            komut.Parameters.AddWithValue("@Id",VeriAdmin.AdminId);
            komut.ExecuteNonQuery() ;
            baglan.Close();
            MessageBox.Show("Bilgileriniz Silinmiştir...");
            frmana ana = new frmana();  
            ana.Show();
            this.Hide();
        }

        private void adminbilgi_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
