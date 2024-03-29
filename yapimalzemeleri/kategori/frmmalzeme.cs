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
using System.Windows.Documents;
using System.Windows.Forms;


namespace yapimalzemeleri.kategori
{

    public partial class frmmalzeme : Form
    {
        public frmmalzeme()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-4A657RK\\SQLEXPRESS;Initial Catalog=yapimalzemeleri;Integrated Security=True");
        SqlCommand komut;
        SqlDataAdapter datadap;
        DataTable table;

        private void button2_Click(object sender, EventArgs e)
        {
            //butondan gelen form
            frmkullanici kullanıcı = new frmkullanici();
            kullanıcı.Show();
            this.Hide();
        }

       
        private void btnurunback_Click(object sender, EventArgs e)
        {
            frmgiris giris = new frmgiris();
            giris.Show();
            this.Hide();
        }
        public void Urungetir()
        {
            //ürünleri sqlden getirip datagredviewa doldurma
            datadap= new SqlDataAdapter("Select UrunAd , Fiyat from UrunTable", baglan);    
            table= new DataTable();
            baglan.Open();
            datadap.Fill(table);
            dataGridView1.DataSource= table;
            dataGridView1.Columns[0].HeaderText = "Ürünler"; //default gelen kolon isimlerini değiştirdim.
            dataGridView1.Columns[1].HeaderText = "Fiyatlar";
            dataGridView1.Columns[0].Width = 180;//kolonların genişliklerini verdim.
            dataGridView1.Columns[1].Width = 180;
            dataGridView1.ClearSelection();
            baglan.Close(); 

        }
        private void frmmalzeme_Load(object sender, EventArgs e)
        {
            Tablo.Columns.Add("Urun"); //veritabaanında bilgiler bizimi olulşturduğumuz sütünların altına gelsin. 
            Tablo.Columns.Add("Fiyat"); 
            Urungetir();
        }
        DataTable Tablo = new DataTable();
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            string urun = dataGridView1.SelectedRows[0].Cells[0].Value.ToString(); 
            // bu satır seçilen satırın hücrelerinden ilkinin verisini verir.
            // dataGridView1.selectedrows => bu kod datagridten seçilmiş olan satırları bir dizi şeklinde verir
            // datagridview.secilensatirlar[0. eleman, yani ilk eleman/satır].hücreler/sütunlar[0. eleman, yani ilk eleman/sütun]
            string fiyat = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();


            DataRow Satir = Tablo.NewRow();//tabloya yeni bir satır ekliyoruz
            Satir["Urun"] = urun;
            Satir["Fiyat"] = fiyat; // boş satırı olusturduktan sonra,  boş satırın hücrelerini dolduruyoruz.
            Tablo.Rows.Add(Satir); //Tabloya ekliyoruz

            lstbox.DataSource = Tablo; //listbıxın kaynagını belirtiyoruz.
            lstbox.DisplayMember = "Urun"; //listbxa eklendiği anda görünürde olacak olan ürün adı 
            lstbox.ValueMember = "Fiyat";   //arka planda ise fiyat bilgisi tutulacaktır.
            TutarHesapla();
        }
        void TutarHesapla()
        {
            int toplam = 0;
            for (int i = 0; i < Tablo.Rows.Count; i++)  // oluşturduğumuz tablonun uzunluğunumu alacak
            {
                toplam += Convert.ToInt32(Tablo.Rows[i]["Fiyat"]);  

            }
            tutar.Text = "Toplam : " + toplam;
        }
        private void urunsil_Click(object sender, EventArgs e)
        {
            Tablo.Rows.RemoveAt(lstbox.SelectedIndex); 
            // RemoveAt fonksiyonu tablodan satır silmeye yarar, parametre olarakda hangi satırı silmek istediğini sorar
            TutarHesapla();
        }

        private void onayla_Click(object sender, EventArgs e)
        {

            string urun2 = "";
            int toplam2 = 0;
            foreach (DataRow item in Tablo.Rows)// burada Tablo'muzun satırlarını tek tek dolaşıyoruz
            {
                urun2 += item["Urun"].ToString() + " , ";        //urun değişkenimize urun bilgisni
                toplam2 += int.Parse(item["Fiyat"].ToString());  // fiyat değişkeninne ise fiyat bilgisini veriyoruz.int çevrili olacak şekilde.
            }   

            //ardından tutarı ve bilgiyi kaydetme işlemi yapıyoruz. kullanıcı bilgileri ile .
            string sql= "INSERT INTO SiparislerTable(KullaniciId,UrunAdi,Tutar,KullaniciAdi) values(@KullaniciId,@UrunAdi,@Tutar,@KullaniciAdi)";
            komut = new SqlCommand(sql,baglan);
           //komut.Connection = baglan;
            baglan.Open();  
            komut.Parameters.AddWithValue("UrunAdi", urun2);
            komut.Parameters.AddWithValue("Tutar", toplam2);
            komut.Parameters.AddWithValue("KullaniciAdi", VeriTut.KullaniciAdi);
            komut.Parameters.AddWithValue("KullaniciId", VeriTut.KullaniciId);
            komut.ExecuteNonQuery();
            komut.Dispose();
            baglan.Close();

            MessageBox.Show("Siparişiniz Alınmıştır ..."); 
            Tablo.Clear();
            tutar.Text = ""; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmkullanicisepet sepet= new frmkullanicisepet();
            sepet.Show();
            this.Hide();
        }

        private void frmmalzeme_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

