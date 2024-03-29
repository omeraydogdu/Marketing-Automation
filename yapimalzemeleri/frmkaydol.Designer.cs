namespace yapimalzemeleri
{
    partial class frmkaydol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmkaydol));
            this.lblkullanicik = new System.Windows.Forms.Label();
            this.lblsifrek = new System.Windows.Forms.Label();
            this.lbltelefonk = new System.Windows.Forms.Label();
            this.txtkullaniciadk = new System.Windows.Forms.TextBox();
            this.txttelefonk = new System.Windows.Forms.MaskedTextBox();
            this.txtsifrek = new System.Windows.Forms.TextBox();
            this.btnkaydolk = new System.Windows.Forms.Button();
            this.btnkaydolback = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lBLbaslıkk = new System.Windows.Forms.Label();
            this.lbltck = new System.Windows.Forms.Label();
            this.txttck = new System.Windows.Forms.MaskedTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblkullanicik
            // 
            this.lblkullanicik.AutoSize = true;
            this.lblkullanicik.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkullanicik.Location = new System.Drawing.Point(314, 75);
            this.lblkullanicik.Name = "lblkullanicik";
            this.lblkullanicik.Size = new System.Drawing.Size(163, 31);
            this.lblkullanicik.TabIndex = 4;
            this.lblkullanicik.Text = "Kullanıcı Adı :";
            // 
            // lblsifrek
            // 
            this.lblsifrek.AutoSize = true;
            this.lblsifrek.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsifrek.Location = new System.Drawing.Point(314, 134);
            this.lblsifrek.Name = "lblsifrek";
            this.lblsifrek.Size = new System.Drawing.Size(76, 31);
            this.lblsifrek.TabIndex = 5;
            this.lblsifrek.Text = "Şifre :";
            // 
            // lbltelefonk
            // 
            this.lbltelefonk.AutoSize = true;
            this.lbltelefonk.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltelefonk.Location = new System.Drawing.Point(314, 201);
            this.lbltelefonk.Name = "lbltelefonk";
            this.lbltelefonk.Size = new System.Drawing.Size(105, 31);
            this.lbltelefonk.TabIndex = 6;
            this.lbltelefonk.Text = "Telefon :";
            // 
            // txtkullaniciadk
            // 
            this.txtkullaniciadk.BackColor = System.Drawing.SystemColors.Window;
            this.txtkullaniciadk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkullaniciadk.ForeColor = System.Drawing.Color.Red;
            this.txtkullaniciadk.Location = new System.Drawing.Point(483, 75);
            this.txtkullaniciadk.Name = "txtkullaniciadk";
            this.txtkullaniciadk.Size = new System.Drawing.Size(189, 34);
            this.txtkullaniciadk.TabIndex = 0;
            // 
            // txttelefonk
            // 
            this.txttelefonk.BackColor = System.Drawing.SystemColors.Window;
            this.txttelefonk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttelefonk.ForeColor = System.Drawing.Color.Red;
            this.txttelefonk.Location = new System.Drawing.Point(483, 201);
            this.txttelefonk.Mask = "(9999) 000-0000";
            this.txttelefonk.Name = "txttelefonk";
            this.txttelefonk.Size = new System.Drawing.Size(189, 34);
            this.txttelefonk.TabIndex = 2;
            // 
            // txtsifrek
            // 
            this.txtsifrek.BackColor = System.Drawing.SystemColors.Window;
            this.txtsifrek.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsifrek.ForeColor = System.Drawing.Color.Red;
            this.txtsifrek.Location = new System.Drawing.Point(483, 134);
            this.txtsifrek.Name = "txtsifrek";
            this.txtsifrek.Size = new System.Drawing.Size(189, 34);
            this.txtsifrek.TabIndex = 1;
            this.txtsifrek.UseSystemPasswordChar = true;
            // 
            // btnkaydolk
            // 
            this.btnkaydolk.BackColor = System.Drawing.Color.Teal;
            this.btnkaydolk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkaydolk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkaydolk.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnkaydolk.ImageIndex = 0;
            this.btnkaydolk.Location = new System.Drawing.Point(197, 3);
            this.btnkaydolk.Name = "btnkaydolk";
            this.btnkaydolk.Size = new System.Drawing.Size(307, 59);
            this.btnkaydolk.TabIndex = 0;
            this.btnkaydolk.Text = "KAYDOL";
            this.btnkaydolk.UseVisualStyleBackColor = false;
            this.btnkaydolk.Click += new System.EventHandler(this.btnkaydolk_Click);
            this.btnkaydolk.MouseEnter += new System.EventHandler(this.btnkaydolk_MouseEnter);
            this.btnkaydolk.MouseLeave += new System.EventHandler(this.btnkaydolk_MouseLeave);
            // 
            // btnkaydolback
            // 
            this.btnkaydolback.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnkaydolback.BackgroundImage")));
            this.btnkaydolback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnkaydolback.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnkaydolback.Location = new System.Drawing.Point(21, 16);
            this.btnkaydolback.Name = "btnkaydolback";
            this.btnkaydolback.Size = new System.Drawing.Size(34, 34);
            this.btnkaydolback.TabIndex = 0;
            this.btnkaydolback.UseVisualStyleBackColor = true;
            this.btnkaydolback.Click += new System.EventHandler(this.btnkaydolback_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.lBLbaslıkk);
            this.panel1.Controls.Add(this.btnkaydolback);
            this.panel1.Location = new System.Drawing.Point(3, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 61);
            this.panel1.TabIndex = 12;
            // 
            // lBLbaslıkk
            // 
            this.lBLbaslıkk.AutoSize = true;
            this.lBLbaslıkk.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBLbaslıkk.Location = new System.Drawing.Point(191, 16);
            this.lBLbaslıkk.Name = "lBLbaslıkk";
            this.lBLbaslıkk.Size = new System.Drawing.Size(170, 34);
            this.lBLbaslıkk.TabIndex = 1;
            this.lBLbaslıkk.Text = "KULLANICI";
            // 
            // lbltck
            // 
            this.lbltck.AutoSize = true;
            this.lbltck.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltck.Location = new System.Drawing.Point(314, 273);
            this.lbltck.Name = "lbltck";
            this.lbltck.Size = new System.Drawing.Size(48, 31);
            this.lbltck.TabIndex = 7;
            this.lbltck.Text = "Tc :";
            // 
            // txttck
            // 
            this.txttck.BackColor = System.Drawing.SystemColors.Window;
            this.txttck.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttck.ForeColor = System.Drawing.Color.Red;
            this.txttck.Location = new System.Drawing.Point(483, 270);
            this.txttck.Mask = "00000000000";
            this.txttck.Name = "txttck";
            this.txttck.Size = new System.Drawing.Size(189, 34);
            this.txttck.TabIndex = 3;
            this.txttck.ValidatingType = typeof(int);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.btnkaydolk);
            this.panel2.Location = new System.Drawing.Point(3, 340);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(695, 65);
            this.panel2.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // frmkaydol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(690, 406);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txttck);
            this.Controls.Add(this.lbltck);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtsifrek);
            this.Controls.Add(this.txttelefonk);
            this.Controls.Add(this.txtkullaniciadk);
            this.Controls.Add(this.lbltelefonk);
            this.Controls.Add(this.lblsifrek);
            this.Controls.Add(this.lblkullanicik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmkaydol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KAYDOL FORMU";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmkaydol_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblkullanicik;
        private System.Windows.Forms.Label lblsifrek;
        private System.Windows.Forms.Label lbltelefonk;
        private System.Windows.Forms.TextBox txtkullaniciadk;
        private System.Windows.Forms.MaskedTextBox txttelefonk;
        private System.Windows.Forms.TextBox txtsifrek;
        private System.Windows.Forms.Button btnkaydolk;
        private System.Windows.Forms.Button btnkaydolback;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbltck;
        private System.Windows.Forms.MaskedTextBox txttck;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lBLbaslıkk;
    }
}