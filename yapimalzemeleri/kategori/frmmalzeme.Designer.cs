namespace yapimalzemeleri.kategori
{
    partial class frmmalzeme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmalzeme));
            this.lstbox = new System.Windows.Forms.ListBox();
            this.tutar = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.urunsil = new System.Windows.Forms.Button();
            this.onayla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnurunback = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstbox
            // 
            this.lstbox.BackColor = System.Drawing.Color.Black;
            this.lstbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstbox.ForeColor = System.Drawing.SystemColors.Window;
            this.lstbox.FormattingEnabled = true;
            this.lstbox.ItemHeight = 20;
            this.lstbox.Location = new System.Drawing.Point(560, 52);
            this.lstbox.Name = "lstbox";
            this.lstbox.Size = new System.Drawing.Size(518, 524);
            this.lstbox.TabIndex = 2;
            // 
            // tutar
            // 
            this.tutar.AutoSize = true;
            this.tutar.Font = new System.Drawing.Font("Algerian", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutar.ForeColor = System.Drawing.SystemColors.Window;
            this.tutar.Location = new System.Drawing.Point(831, 579);
            this.tutar.Name = "tutar";
            this.tutar.Size = new System.Drawing.Size(0, 31);
            this.tutar.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.urunsil);
            this.panel3.Controls.Add(this.onayla);
            this.panel3.ForeColor = System.Drawing.Color.Coral;
            this.panel3.Location = new System.Drawing.Point(549, 657);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(523, 130);
            this.panel3.TabIndex = 79;
            // 
            // urunsil
            // 
            this.urunsil.BackColor = System.Drawing.Color.Teal;
            this.urunsil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.urunsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunsil.ForeColor = System.Drawing.Color.Black;
            this.urunsil.Location = new System.Drawing.Point(99, 33);
            this.urunsil.Name = "urunsil";
            this.urunsil.Size = new System.Drawing.Size(122, 94);
            this.urunsil.TabIndex = 88;
            this.urunsil.Text = "ÜRÜN ÇIKAR";
            this.urunsil.UseVisualStyleBackColor = false;
            this.urunsil.Click += new System.EventHandler(this.urunsil_Click);
            // 
            // onayla
            // 
            this.onayla.BackColor = System.Drawing.Color.Teal;
            this.onayla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.onayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.onayla.ForeColor = System.Drawing.Color.Black;
            this.onayla.Location = new System.Drawing.Point(306, 33);
            this.onayla.Name = "onayla";
            this.onayla.Size = new System.Drawing.Size(122, 94);
            this.onayla.TabIndex = 86;
            this.onayla.Text = "ONAYLA";
            this.onayla.UseVisualStyleBackColor = false;
            this.onayla.Click += new System.EventHandler(this.onayla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 48);
            this.label1.TabIndex = 80;
            this.label1.Text = "ÜRÜNLER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Algerian", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(624, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 48);
            this.label3.TabIndex = 81;
            this.label3.Text = "SEPETİM";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Teal;
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.btnurunback);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(-4, -1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1082, 56);
            this.panel5.TabIndex = 82;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(911, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 56);
            this.button1.TabIndex = 83;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Location = new System.Drawing.Point(1006, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 56);
            this.button2.TabIndex = 82;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnurunback
            // 
            this.btnurunback.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnurunback.BackgroundImage")));
            this.btnurunback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnurunback.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnurunback.Location = new System.Drawing.Point(0, 0);
            this.btnurunback.Name = "btnurunback";
            this.btnurunback.Size = new System.Drawing.Size(53, 53);
            this.btnurunback.TabIndex = 1;
            this.btnurunback.UseVisualStyleBackColor = true;
            this.btnurunback.Click += new System.EventHandler(this.btnurunback_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(547, 735);
            this.dataGridView1.TabIndex = 83;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // frmmalzeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1074, 787);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.tutar);
            this.Controls.Add(this.lstbox);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmmalzeme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SATIŞ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmmalzeme_FormClosing);
            this.Load += new System.EventHandler(this.frmmalzeme_Load);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstbox;
        private System.Windows.Forms.Label tutar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnurunback;
        private System.Windows.Forms.Button onayla;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button urunsil;
        private System.Windows.Forms.Button button1;
    }
}