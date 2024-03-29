using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace yapimalzemeleri.kategori
{
    public partial class adminurun : Form
    {
        public adminurun()
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
        public void Urungetir()
        {
            //ürün getirip datagredviewa doldruma metodu yaptık.
            datadap = new SqlDataAdapter("Select * from UrunTable", baglan);
            table = new DataTable();
            baglan.Open();
            datadap.Fill(table);
            dataGridView2.DataSource = table;
            dataGridView2.Columns[0].HeaderText = "Ürün Sıra Numarası";
            dataGridView2.Columns[1].HeaderText = "Ürünler";
            dataGridView2.Columns[2].HeaderText = "Fiyatlar";
            dataGridView2.ClearSelection();
            baglan.Close();
        }

        private void adminurun_Load(object sender, EventArgs e)
        {
           Urungetir();
        }

        private void btneklekul_Click(object sender, EventArgs e)
        {
            //ürün eklemek için yapılan işlem
            baglan.Open();
            komut = new SqlCommand("Insert into UrunTable(UrunAd,Fiyat)values(@UrunAd,@Fiyat)", baglan);
            komut.Parameters.AddWithValue("@UrunAd", txturun.Text);
            komut.Parameters.AddWithValue("@Fiyat", txtfiyat.Text);
            komut.ExecuteNonQuery();
            komut.Dispose();
            baglan.Close();
            MessageBox.Show("Ürün Eklenmiştir....");
            Urungetir();
        }
        private void btnsilkul_Click(object sender, EventArgs e)
        {
            //ürün silmek için yapılan işlem
            baglan.Open();
            komut = new SqlCommand("Delete UrunTable where UrunId=@UrunId", baglan);
            komut.Parameters.AddWithValue("@UrunId", dataGridView2.CurrentRow.Cells[0].Value);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Ürün Silinmiştir....");
            Urungetir();
        }
        private void btnguncellekul_Click(object sender, EventArgs e)
        {
            //ürün güncellemek için yapılan işlem
            baglan.Open();
            komut = new SqlCommand("Update UrunTable set UrunAd=@UrunAd,Fiyat=@Fiyat where UrunId=@UrunId", baglan);
            komut.Parameters.AddWithValue("@UrunAd", txturun.Text);
            komut.Parameters.AddWithValue("@Fiyat", txtfiyat.Text);
            komut.Parameters.AddWithValue("UrunId", dataGridView2.CurrentRow.Cells[0].Value);
            komut.ExecuteNonQuery();
            komut.Dispose();
            baglan.Close();
            MessageBox.Show("Ürün Güncellenmiştir....");
            Urungetir();
        }

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //hücreye girdiğinmde çalışır.
            //veriler textboxlara gitsin diye
            txturun.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txtfiyat.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            //burada ise üürn ve fiyat bilgisi olan iki tane textboxmız var. ve hangi satır sütünün nereye geleceğimizi belirliyoruz.
            //hangi hücrenin bilgisinin nereye geleceğini belirliyoruz.
        }

        private void adminurun_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}   
