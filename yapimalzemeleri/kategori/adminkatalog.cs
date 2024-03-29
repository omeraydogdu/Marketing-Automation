using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yapimalzemeleri.kategori
{
    public partial class adminkatalog : Form
    {
        public adminkatalog()
        {
            InitializeComponent();
        }

        private void adminsatısis_Click(object sender, EventArgs e)
        {
            adminpanel panel=new adminpanel();
            panel.Show();
            this.Hide();
        }

        private void adminürünis_Click(object sender, EventArgs e)
        {
            adminurun urun= new adminurun();
            urun.Show();
            this.Hide();
        }

        private void btnadmibkback_Click(object sender, EventArgs e)
        {
            frmgiris giris=new frmgiris();
            giris.Show();
            this.Hide();
        }

        private void adminbilgi_Click(object sender, EventArgs e)
        {
            adminbilgi bilgi = new adminbilgi();
            bilgi.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminmusteri musteri = new adminmusteri();  
            musteri.Show();
            this.Hide();
        }

        private void adminkatalog_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
