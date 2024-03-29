using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yapimalzemeleri
{
    public partial class FrmAnimsayon : Form
    {
        public FrmAnimsayon()
        {
            InitializeComponent();
        }
        bool islem = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!islem)//eğer işlem false ise opacity artır .. ki işlem şuan zaten false 
            {
                this.Opacity+=0.009; // opacity arttır.
            }
            if (this.Opacity==1.0)//opacitemiz tamamen açılmışsa  işlem true olsun (animasyon)
            {
                islem = true;
            }
            if (islem) // işlem  true ise tekrar opacity azalsın 
            {
                this.Opacity -= 0.009;
                if (this.Opacity==0)//opacityy eşitse 0a formu aç.
                {
                    frmana ana = new frmana();
                    ana.Show();
                    this.Hide();
                    timer1.Enabled = false;//timerı kapatmazsak sonsuz kere açacak bu formu . // interval hıızı
                }
            }
        }
    }
}
