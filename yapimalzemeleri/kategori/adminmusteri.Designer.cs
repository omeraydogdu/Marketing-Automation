namespace yapimalzemeleri.kategori
{
    partial class adminmusteri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminmusteri));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnmgüncelle = new System.Windows.Forms.Button();
            this.btnsilmüsteri = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.btnmgüncelle);
            this.panel1.Controls.Add(this.btnsilmüsteri);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnback);
            this.panel1.Location = new System.Drawing.Point(-4, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 70);
            this.panel1.TabIndex = 16;
            // 
            // btnmgüncelle
            // 
            this.btnmgüncelle.BackColor = System.Drawing.Color.Teal;
            this.btnmgüncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmgüncelle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnmgüncelle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnmgüncelle.ImageIndex = 0;
            this.btnmgüncelle.Location = new System.Drawing.Point(339, 11);
            this.btnmgüncelle.Name = "btnmgüncelle";
            this.btnmgüncelle.Size = new System.Drawing.Size(161, 48);
            this.btnmgüncelle.TabIndex = 18;
            this.btnmgüncelle.Text = "GÜNCELLE";
            this.btnmgüncelle.UseVisualStyleBackColor = false;
            this.btnmgüncelle.Click += new System.EventHandler(this.btnmgüncelle_Click);
            // 
            // btnsilmüsteri
            // 
            this.btnsilmüsteri.BackColor = System.Drawing.Color.Teal;
            this.btnsilmüsteri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsilmüsteri.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsilmüsteri.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnsilmüsteri.ImageIndex = 0;
            this.btnsilmüsteri.Location = new System.Drawing.Point(517, 11);
            this.btnsilmüsteri.Name = "btnsilmüsteri";
            this.btnsilmüsteri.Size = new System.Drawing.Size(189, 48);
            this.btnsilmüsteri.TabIndex = 17;
            this.btnsilmüsteri.Text = "KULLANICI SİL";
            this.btnsilmüsteri.UseVisualStyleBackColor = false;
            this.btnsilmüsteri.Click += new System.EventHandler(this.btnsilmüsteri_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(70, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 36);
            this.label3.TabIndex = 16;
            this.label3.Text = "KULLANICILAR";
            // 
            // btnback
            // 
            this.btnback.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnback.BackgroundImage")));
            this.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnback.Location = new System.Drawing.Point(16, 16);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(34, 34);
            this.btnback.TabIndex = 5;
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(731, 393);
            this.dataGridView1.TabIndex = 42;
            // 
            // adminmusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "adminmusteri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminmusteri";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.adminmusteri_FormClosing);
            this.Load += new System.EventHandler(this.adminmusteri_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnsilmüsteri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnmgüncelle;
    }
}