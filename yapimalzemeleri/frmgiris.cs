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
using yapimalzemeleri.kategori;

namespace yapimalzemeleri
{
    public partial class frmgiris : Form
    {
        public frmgiris()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-4A657RK\\SQLEXPRESS;Initial Catalog=yapimalzemeleri;Integrated Security=True");
        private void btnkydlback_Click(object sender, EventArgs e)
        {
            frmana ana = new frmana();
            ana.Show();
            this.Hide();
        }

  
        private void btnkydlgiris_Click(object sender, EventArgs e)
        {
            //tetxboxlar boş iken yapılacak işlem esnasında verilecek hata mesajı.
            if (txtkullanicig.Text == string.Empty || txtsifreg.Text == string.Empty)// textboxların içini boş olması durumu 
            {
                MessageBox.Show("Lütfen Bilgilerinizi Eksiksiz Giriniz...", "UYARI !!!");
            }
            else
            {
                baglan.Open();
                string giris = "Select * from KullaniciTable where KullaniciAd=@KullaniciAd and KullaniciSifre=@KullaniciSifre";
                SqlCommand komut = new SqlCommand(giris, baglan);
                komut.Parameters.AddWithValue("KullaniciAd", txtkullanicig.Text);
                komut.Parameters.AddWithValue("KullaniciSifre", txtsifreg.Text);
                komut.ExecuteNonQuery();//ne kada varsa bilgisini int olarak getirir. yürütme.
                SqlDataReader dataread = komut.ExecuteReader();
                if (dataread.Read())
                {
                    //sqlde bulunaan kayda göre giriş yaparken verilerin nerede tutulacağını gösterilmesi.
                    VeriTut.KullaniciId = int.Parse(dataread["Id"].ToString());
                    VeriTut.KullaniciAdi = dataread["KullaniciAd"].ToString();
                    VeriTut.KullaniciTc = dataread["KullaniciTc"].ToString();
                    VeriTut.KullaniciTelefon = dataread["KullaniciTelefon"].ToString();
                    VeriTut.KullaniciSifre = dataread["KullaniciSifre"].ToString();
                    frmmalzeme malzeme = new frmmalzeme();
                    malzeme.Show();
                    this.Hide();

                }
                else
                //her iki durumunda olmaması halinde çalışacak olan kod bloğu.
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre yanlış..", "HATA !!!");
                    txtkullanicig.Text = "";
                    txtsifreg.Text = "";
                }
                komut.Dispose();
                baglan.Close();
            }
        }
        private void linkkayıtol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            kategori.frmadmingiris adm=new kategori.frmadmingiris();
            adm.Show();
            this.Hide();
        }

        //kullanıcı
        private void btnkydlgiris_MouseEnter(object sender, EventArgs e)
        {
            btnkydlgiris.BackColor = Color.Red;
        }
        private void btnkydlgiris_MouseLeave(object sender, EventArgs e)
        {
            btnkydlgiris.BackColor = Color.White;
        }

        //admin
        private void btnadmingiris_MouseEnter(object sender, EventArgs e)
        {
            btnadmingiris.BackColor = Color.Red;
        }
        private void btnadmingiris_MouseLeave(object sender, EventArgs e)
        {
            btnadmingiris.BackColor = Color.White;
        }

        private void btnadmingiris_Click(object sender, EventArgs e)
        {
            if (txtadmintc.Text==string.Empty || txtadminsifre.Text==string.Empty)// textboxların içini boş olması durumu 
            {
                MessageBox.Show("Lütfen Bilgilerinizi Eksiksiz Giriniz...", "UYARI !!!");
            }
            else
            {
                //sqlde bulunaan kayda göre giriş yaparken verilerin nerede tutulacağını gösterilmesi.
                baglan.Open();
                string admin = "Select * from AdminTable where AdminTc=@AdminTc and AdminSifre=@AdminSifre";
                SqlCommand komut=new SqlCommand(admin,baglan);
                komut.Parameters.AddWithValue("AdminTc",txtadmintc.Text);
                komut.Parameters.AddWithValue("AdminSifre",txtadminsifre.Text);
                komut.ExecuteNonQuery();    
                SqlDataReader read=komut.ExecuteReader();
                if (read.Read())
                {
                    VeriAdmin.AdminId = int.Parse(read["Id"].ToString()); //tutulacak clasın elemanları
                    VeriAdmin.AdminTc = read["AdminTc"].ToString();
                    VeriAdmin.AdminSifre = read["AdminSifre"].ToString();
                    adminkatalog katalog=new adminkatalog();
                    katalog.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre yanlış..", "HATA !!!");
                    txtadmintc.Text = "";
                    txtadminsifre.Text = "";
                }
                komut.Dispose();
                baglan.Close();

            }
        }

        private void frmgiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
