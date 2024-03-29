using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace yapimalzemeleri.kategori
{
    public partial class adminpanel : Form
    {
        public adminpanel()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-4A657RK\\SQLEXPRESS;Initial Catalog=yapimalzemeleri;Integrated Security=True");
        SqlCommand komut;
        SqlDataAdapter datadap;
        DataTable table;
        private void btnback_Click(object sender, EventArgs e)
        {
            adminkatalog admkata = new adminkatalog();
            admkata.Show();
            this.Hide();
        }

        void siparisgetir()
        {
            //sipairş getirip datagrede doldurmak için yazdığımız meethod.
            datadap = new SqlDataAdapter("Select * from SiparislerTable", baglan);
            table = new DataTable();
            baglan.Open();
            datadap.Fill(table);
            dataGridView2.DataSource= table;
            dataGridView2.ClearSelection();
            baglan.Close();
        }
        void hesapla()
        {
            baglan.Open();
            komut = new SqlCommand("select sum(Tutar)from SiparislerTable", baglan);
            label4.Text=komut.ExecuteScalar()+" ₺";
            // daha çok görüntülenmek istenilen alanlarda kullanılır.
            // Genellikle tek bir değer döndüren sorgular için kullanılır.
            baglan.Close();
        }

        private void adminpanel_Load(object sender, EventArgs e)
        {
            hesapla();
            siparisgetir();
        }
        private void btnsilpanels_Click(object sender, EventArgs e)
        {
            baglan.Open();
            komut = new SqlCommand("Delete SiparislerTable where Id=@Id", baglan);
            // CurrentRow sayesinde seçili satırı belirledik. Cells[0] kısmı ilede hangi hücreyisi alacağımızı belirledik.
            komut.Parameters.AddWithValue("@Id", dataGridView2.CurrentRow.Cells[0].Value);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Sİpariş Silinmiştir....");
            siparisgetir();
            hesapla();

        }

        private void adminpanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
