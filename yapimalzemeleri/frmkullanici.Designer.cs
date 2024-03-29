namespace yapimalzemeleri
{
    partial class frmkullanici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmkullanici));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnkaydolback = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedtc = new System.Windows.Forms.MaskedTextBox();
            this.txtsifrek = new System.Windows.Forms.TextBox();
            this.txttelefonk = new System.Windows.Forms.MaskedTextBox();
            this.txtkullaniciadk = new System.Windows.Forms.TextBox();
            this.lbltelefonk = new System.Windows.Forms.Label();
            this.lblsifrek = new System.Windows.Forms.Label();
            this.lblkullanicik = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.btnkaydolback);
            this.panel1.Location = new System.Drawing.Point(2, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 46);
            this.panel1.TabIndex = 14;
            // 
            // btnkaydolback
            // 
            this.btnkaydolback.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnkaydolback.BackgroundImage")));
            this.btnkaydolback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnkaydolback.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnkaydolback.Location = new System.Drawing.Point(3, 8);
            this.btnkaydolback.Name = "btnkaydolback";
            this.btnkaydolback.Size = new System.Drawing.Size(34, 34);
            this.btnkaydolback.TabIndex = 5;
            this.btnkaydolback.UseVisualStyleBackColor = true;
            this.btnkaydolback.Click += new System.EventHandler(this.btnkaydolback_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.btngüncelle);
            this.panel2.Controls.Add(this.btnsil);
            this.panel2.Location = new System.Drawing.Point(2, 276);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(667, 72);
            this.panel2.TabIndex = 22;
            // 
            // btngüncelle
            // 
            this.btngüncelle.BackColor = System.Drawing.Color.Teal;
            this.btngüncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngüncelle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngüncelle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btngüncelle.ImageIndex = 0;
            this.btngüncelle.Location = new System.Drawing.Point(253, 18);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(139, 49);
            this.btngüncelle.TabIndex = 11;
            this.btngüncelle.Text = "GÜNCELLE";
            this.btngüncelle.UseVisualStyleBackColor = false;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.Teal;
            this.btnsil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnsil.ImageIndex = 0;
            this.btnsil.Location = new System.Drawing.Point(458, 18);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(142, 49);
            this.btnsil.TabIndex = 11;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(250, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "Tc  :";
            // 
            // maskedtc
            // 
            this.maskedtc.BackColor = System.Drawing.SystemColors.Window;
            this.maskedtc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedtc.ForeColor = System.Drawing.Color.Red;
            this.maskedtc.Location = new System.Drawing.Point(440, 222);
            this.maskedtc.Mask = "00000000000";
            this.maskedtc.Name = "maskedtc";
            this.maskedtc.Size = new System.Drawing.Size(189, 34);
            this.maskedtc.TabIndex = 31;
            this.maskedtc.ValidatingType = typeof(int);
            // 
            // txtsifrek
            // 
            this.txtsifrek.BackColor = System.Drawing.SystemColors.Window;
            this.txtsifrek.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsifrek.ForeColor = System.Drawing.Color.Red;
            this.txtsifrek.Location = new System.Drawing.Point(440, 122);
            this.txtsifrek.Name = "txtsifrek";
            this.txtsifrek.Size = new System.Drawing.Size(189, 34);
            this.txtsifrek.TabIndex = 25;
            // 
            // txttelefonk
            // 
            this.txttelefonk.BackColor = System.Drawing.SystemColors.Window;
            this.txttelefonk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttelefonk.ForeColor = System.Drawing.Color.Red;
            this.txttelefonk.Location = new System.Drawing.Point(440, 168);
            this.txttelefonk.Mask = "(9999) 000-0000";
            this.txttelefonk.Name = "txttelefonk";
            this.txttelefonk.Size = new System.Drawing.Size(189, 34);
            this.txttelefonk.TabIndex = 26;
            // 
            // txtkullaniciadk
            // 
            this.txtkullaniciadk.BackColor = System.Drawing.SystemColors.Window;
            this.txtkullaniciadk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkullaniciadk.ForeColor = System.Drawing.Color.Red;
            this.txtkullaniciadk.Location = new System.Drawing.Point(440, 59);
            this.txtkullaniciadk.Name = "txtkullaniciadk";
            this.txtkullaniciadk.Size = new System.Drawing.Size(189, 34);
            this.txtkullaniciadk.TabIndex = 24;
            // 
            // lbltelefonk
            // 
            this.lbltelefonk.AutoSize = true;
            this.lbltelefonk.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltelefonk.Location = new System.Drawing.Point(249, 168);
            this.lbltelefonk.Name = "lbltelefonk";
            this.lbltelefonk.Size = new System.Drawing.Size(105, 31);
            this.lbltelefonk.TabIndex = 29;
            this.lbltelefonk.Text = "Telefon :";
            // 
            // lblsifrek
            // 
            this.lblsifrek.AutoSize = true;
            this.lblsifrek.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsifrek.Location = new System.Drawing.Point(249, 112);
            this.lblsifrek.Name = "lblsifrek";
            this.lblsifrek.Size = new System.Drawing.Size(76, 31);
            this.lblsifrek.TabIndex = 28;
            this.lblsifrek.Text = "Şifre :";
            // 
            // lblkullanicik
            // 
            this.lblkullanicik.AutoSize = true;
            this.lblkullanicik.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkullanicik.Location = new System.Drawing.Point(249, 59);
            this.lblkullanicik.Name = "lblkullanicik";
            this.lblkullanicik.Size = new System.Drawing.Size(163, 31);
            this.lblkullanicik.TabIndex = 27;
            this.lblkullanicik.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // frmkullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 346);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsifrek);
            this.Controls.Add(this.maskedtc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttelefonk);
            this.Controls.Add(this.txtkullaniciadk);
            this.Controls.Add(this.lbltelefonk);
            this.Controls.Add(this.lblsifrek);
            this.Controls.Add(this.lblkullanicik);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmkullanici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KULLANICI BİLGİLERİ ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmkullanici_FormClosing);
            this.Load += new System.EventHandler(this.frmkullanici_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnkaydolback;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedtc;
        private System.Windows.Forms.TextBox txtsifrek;
        private System.Windows.Forms.MaskedTextBox txttelefonk;
        private System.Windows.Forms.TextBox txtkullaniciadk;
        private System.Windows.Forms.Label lbltelefonk;
        private System.Windows.Forms.Label lblsifrek;
        private System.Windows.Forms.Label lblkullanicik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}