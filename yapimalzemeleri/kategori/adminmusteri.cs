using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace yapimalzemeleri.kategori
{
    public partial class adminmusteri : Form
    {
        public adminmusteri()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-4A657RK\\SQLEXPRESS;Initial Catalog=yapimalzemeleri;Integrated Security=True");
        SqlCommand komut;
        SqlDataAdapter datadap;
        DataTable table;
        
        private void btnback_Click(object sender, EventArgs e)
        {
            adminkatalog katalog = new adminkatalog();
            katalog.Show();
            this.Hide();
        }
        void kisigetir()
        {
            //kişileri getirmek için ve datagredviewa doldurmak için yazılan method.
            datadap = new SqlDataAdapter("Select * from KullaniciTable", baglan);
            table = new DataTable();
            baglan.Open();
            datadap.Fill(table);
            dataGridView1.DataSource = table;
            dataGridView1.ClearSelection();
            baglan.Close();
        }

        private void btnsilmüsteri_Click(object sender, EventArgs e)
        {
            //kişileri silme işlemi.
            baglan.Open();
            komut = new SqlCommand("Delete KullaniciTable where Id=@Id", baglan); //parametre ile  kullanılıp gönder.  
            komut.Parameters.AddWithValue("@Id", dataGridView1.CurrentRow.Cells[0].Value);//value parametreleri ile çağırıp çalıştırıcaz.
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Kullanıcı Silinmiştir....");
            kisigetir();
        }

        private void adminmusteri_Load(object sender, EventArgs e)
        {
            kisigetir();
        }

        private void btnmgüncelle_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder builder= new SqlCommandBuilder(datadap); 
            //sql komut inşaa edici şeklinde çevirebilirz.
            //amacı tekil tablolarda otomatik sql sorguları üretmektir.
            datadap.Update(table); //güncelleme fonksiyonıunu kullanıyoruz.
            kisigetir();
            MessageBox.Show("Güncelleme işlemi tamamlanmıştır.");
        }

        private void adminmusteri_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
