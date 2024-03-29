using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yapimalzemeleri.kategori;

namespace yapimalzemeleri
{
    public partial class frmana : Form
    {
        public frmana()
        {
            InitializeComponent();
        }

        private void btnanagiris_Click(object sender, EventArgs e)
        {
            frmgiris giris = new frmgiris();
            giris.Show();
            this.Hide();
        }
        private void btnanakaydol_Click(object sender, EventArgs e)
        {
            frmkaydol kaydol = new frmkaydol();
            kaydol.Show();
            this.Hide();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Uygulamayı Kapatmak İstediğinize Emin Misiniz ???", "UYARI !!!", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            
            if (cevap == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }
        // MOUSE OLAYLARI BU KISIMDA BAŞLIYOR 
        //mouseenter denetime giriş yapıldığındaki olayı gösterir.
        //mouseleavae denetimden çıkış yapıldığında çalışacak olan olaydır.
        //leave olmazsa üzerine gelince kalıcı olarak o renk de kalır.
        //enter olmazasa hiçbir şekilde olay çalışmaz.


        //Giriş BUTONU
        private void btnanagiris_MouseEnter(object sender, EventArgs e)
        {
            btnanagiris.BackColor = Color.Red;
        }
        private void btnanagiris_MouseLeave(object sender, EventArgs e)
        {
            btnanagiris.BackColor = SystemColors.Window; 
        }

        //Çıkış BUTONU
        private void btnanacikis_MouseEnter(object sender, EventArgs e)
        {
            btnanacikis.BackColor = Color.Red;
        }
        private void btnanacikis_MouseLeave(object sender, EventArgs e)
        {
            btnanacikis.BackColor = SystemColors.Window;
        }
        //Kaydol BUTONU
        private void btnanakaydol_MouseEnter(object sender, EventArgs e)
        {
            btnanakaydol.BackColor = Color.Red;

        }

        private void btnanakaydol_MouseLeave(object sender, EventArgs e)
        {
            btnanakaydol.BackColor = SystemColors.Window;

        }

        private void frmana_Load(object sender, EventArgs e)
        {

        }
    }
}
