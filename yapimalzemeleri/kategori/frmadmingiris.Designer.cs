namespace yapimalzemeleri.kategori
{
    partial class frmadmingiris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmadmingiris));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblbaslıka = new System.Windows.Forms.Label();
            this.btnbackadmin = new System.Windows.Forms.Button();
            this.txtsifrea = new System.Windows.Forms.TextBox();
            this.lblsifrea = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnkaydola = new System.Windows.Forms.Button();
            this.lblkullanicia = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txttca = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.lblbaslıka);
            this.panel1.Controls.Add(this.btnbackadmin);
            this.panel1.Location = new System.Drawing.Point(-5, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 57);
            this.panel1.TabIndex = 13;
            // 
            // lblbaslıka
            // 
            this.lblbaslıka.AutoSize = true;
            this.lblbaslıka.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbaslıka.Location = new System.Drawing.Point(271, 16);
            this.lblbaslıka.Name = "lblbaslıka";
            this.lblbaslıka.Size = new System.Drawing.Size(107, 34);
            this.lblbaslıka.TabIndex = 2;
            this.lblbaslıka.Text = "ADMİN";
            // 
            // btnbackadmin
            // 
            this.btnbackadmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnbackadmin.BackgroundImage")));
            this.btnbackadmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbackadmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnbackadmin.Location = new System.Drawing.Point(21, 16);
            this.btnbackadmin.Name = "btnbackadmin";
            this.btnbackadmin.Size = new System.Drawing.Size(34, 34);
            this.btnbackadmin.TabIndex = 0;
            this.btnbackadmin.UseVisualStyleBackColor = true;
            this.btnbackadmin.Click += new System.EventHandler(this.btnbackadmin_Click);
            // 
            // txtsifrea
            // 
            this.txtsifrea.BackColor = System.Drawing.SystemColors.Window;
            this.txtsifrea.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsifrea.ForeColor = System.Drawing.Color.Red;
            this.txtsifrea.Location = new System.Drawing.Point(384, 156);
            this.txtsifrea.Name = "txtsifrea";
            this.txtsifrea.Size = new System.Drawing.Size(189, 34);
            this.txtsifrea.TabIndex = 15;
            this.txtsifrea.UseSystemPasswordChar = true;
            // 
            // lblsifrea
            // 
            this.lblsifrea.AutoSize = true;
            this.lblsifrea.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsifrea.Location = new System.Drawing.Point(270, 156);
            this.lblsifrea.Name = "lblsifrea";
            this.lblsifrea.Size = new System.Drawing.Size(61, 25);
            this.lblsifrea.TabIndex = 19;
            this.lblsifrea.Text = "Şifre :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.btnkaydola);
            this.panel2.Location = new System.Drawing.Point(-5, 240);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(593, 65);
            this.panel2.TabIndex = 23;
            // 
            // btnkaydola
            // 
            this.btnkaydola.BackColor = System.Drawing.Color.Teal;
            this.btnkaydola.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkaydola.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkaydola.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnkaydola.ImageIndex = 0;
            this.btnkaydola.Location = new System.Drawing.Point(213, 0);
            this.btnkaydola.Name = "btnkaydola";
            this.btnkaydola.Size = new System.Drawing.Size(230, 65);
            this.btnkaydola.TabIndex = 0;
            this.btnkaydola.Text = "KAYDOL";
            this.btnkaydola.UseVisualStyleBackColor = false;
            this.btnkaydola.Click += new System.EventHandler(this.btnkaydola_Click);
            this.btnkaydola.MouseEnter += new System.EventHandler(this.btnkaydola_MouseEnter);
            this.btnkaydola.MouseLeave += new System.EventHandler(this.btnkaydola_MouseLeave);
            // 
            // lblkullanicia
            // 
            this.lblkullanicia.AutoSize = true;
            this.lblkullanicia.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkullanicia.Location = new System.Drawing.Point(270, 97);
            this.lblkullanicia.Name = "lblkullanicia";
            this.lblkullanicia.Size = new System.Drawing.Size(40, 25);
            this.lblkullanicia.TabIndex = 18;
            this.lblkullanicia.Text = "Tc :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-5, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // txttca
            // 
            this.txttca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txttca.Location = new System.Drawing.Point(384, 88);
            this.txttca.Mask = "00000000000";
            this.txttca.Name = "txttca";
            this.txttca.Size = new System.Drawing.Size(189, 34);
            this.txttca.TabIndex = 26;
            this.txttca.ValidatingType = typeof(int);
            // 
            // frmadmingiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 305);
            this.Controls.Add(this.txttca);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtsifrea);
            this.Controls.Add(this.lblsifrea);
            this.Controls.Add(this.lblkullanicia);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmadmingiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMİN KAYDOL";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmadmingiris_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnbackadmin;
        private System.Windows.Forms.TextBox txtsifrea;
        private System.Windows.Forms.Label lblsifrea;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnkaydola;
        private System.Windows.Forms.Label lblbaslıka;
        private System.Windows.Forms.Label lblkullanicia;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox txttca;
    }
}