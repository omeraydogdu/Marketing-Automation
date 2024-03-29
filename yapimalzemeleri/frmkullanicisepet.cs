    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yapimalzemeleri.kategori;

namespace yapimalzemeleri
{
    public partial class frmkullanicisepet : Form
    {
        public frmkullanicisepet()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-4A657RK\\SQLEXPRESS;Initial Catalog=yapimalzemeleri;Integrated Security=True");
        SqlCommand komut;

        public void sepetdoldur()
        {

            //kullanicinin ıdsıne göre girş formunda kullanınını ıdsıne göre clasta tutulan veriden değerlerin çekilmesi.
            baglan.Open();
            komut = new SqlCommand("Select * from SiparislerTable where KullaniciId=@KullaniciId ", baglan);
            komut.Parameters.AddWithValue("@KullaniciId", VeriTut.KullaniciId);
            //sqldataadapter nesnesi , veritabanından okunan veriler üzerinde
            //daha fazla işelem  yapmaya sağlayan yapıdır.
            // verileri kolon isimleri ile birlikte datatable nesnesine doldurur.
            // bir nevi sql ile arasında köprü görevi görür.
            SqlDataAdapter datadap = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();///tablo kodları.
            datadap.Fill(dt); //tabloya doldurma işlemi.
            dataGridView1.DataSource = dt;
            komut.Dispose();
            baglan.Close();
        }
        private void frmkullanicisepet_Load(object sender, EventArgs e)
        {
            sepetdoldur();
            hesapla();
        }
        void hesapla()
        {
            //datagredviewda type:int olan kolonun toplamını aldırıyoruz.
            baglan.Open();
            komut = new SqlCommand("select sum(Tutar)from SiparislerTable where KullaniciId=@KullaniciId", baglan);
            komut.Parameters.AddWithValue("@KullaniciId", VeriTut.KullaniciId);
            label2.Text = "TOPLAM TUTAR =>>" + komut.ExecuteScalar() + " ₺";
           // daha çok görüntülenmek istenilen alanlarda kullanılır.
           // Genellikle tek bir değer döndüren sorgular için kullanılır.
            baglan.Close();
        }

        private void btnkaydolback_Click(object sender, EventArgs e)
        {
            frmmalzeme malzeme=new frmmalzeme();
            malzeme.Show();
            this.Hide();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            //kullanıcın sipiariş tablosundaki siparişi ıdye göre sildik.
            baglan.Open();
            komut = new SqlCommand("Delete SiparislerTable where Id=@Id", baglan);
            komut.Parameters.AddWithValue("@Id", dataGridView1.CurrentRow.Cells[0].Value);
            komut.ExecuteNonQuery();
            komut.Dispose();
            baglan.Close();
            MessageBox.Show("Siparişiniz Silindi....");
            sepetdoldur();
            hesapla();
        }

        private void frmkullanicisepet_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
