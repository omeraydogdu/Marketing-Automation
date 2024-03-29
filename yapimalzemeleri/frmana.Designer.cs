namespace yapimalzemeleri
{
    partial class frmana
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmana));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnanagiris = new System.Windows.Forms.Button();
            this.btnanacikis = new System.Windows.Forms.Button();
            this.btnanakaydol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "kaydol.png");
            this.ımageList1.Images.SetKeyName(1, "exit1.png");
            this.ımageList1.Images.SetKeyName(2, "login.png");
            // 
            // btnanagiris
            // 
            this.btnanagiris.BackColor = System.Drawing.SystemColors.Window;
            this.btnanagiris.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnanagiris.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnanagiris.ForeColor = System.Drawing.Color.Black;
            this.btnanagiris.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnanagiris.ImageIndex = 2;
            this.btnanagiris.ImageList = this.ımageList1;
            this.btnanagiris.Location = new System.Drawing.Point(65, 13);
            this.btnanagiris.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnanagiris.Name = "btnanagiris";
            this.btnanagiris.Size = new System.Drawing.Size(100, 115);
            this.btnanagiris.TabIndex = 0;
            this.btnanagiris.Text = "GİRİŞ";
            this.btnanagiris.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnanagiris.UseVisualStyleBackColor = false;
            this.btnanagiris.Click += new System.EventHandler(this.btnanagiris_Click);
            this.btnanagiris.MouseEnter += new System.EventHandler(this.btnanagiris_MouseEnter);
            this.btnanagiris.MouseLeave += new System.EventHandler(this.btnanagiris_MouseLeave);
            // 
            // btnanacikis
            // 
            this.btnanacikis.BackColor = System.Drawing.SystemColors.Window;
            this.btnanacikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnanacikis.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnanacikis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnanacikis.ImageIndex = 1;
            this.btnanacikis.ImageList = this.ımageList1;
            this.btnanacikis.Location = new System.Drawing.Point(427, 15);
            this.btnanacikis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnanacikis.Name = "btnanacikis";
            this.btnanacikis.Size = new System.Drawing.Size(100, 114);
            this.btnanacikis.TabIndex = 2;
            this.btnanacikis.Text = "ÇIKIŞ";
            this.btnanacikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnanacikis.UseVisualStyleBackColor = false;
            this.btnanacikis.Click += new System.EventHandler(this.btncikis_Click);
            this.btnanacikis.MouseEnter += new System.EventHandler(this.btnanacikis_MouseEnter);
            this.btnanacikis.MouseLeave += new System.EventHandler(this.btnanacikis_MouseLeave);
            // 
            // btnanakaydol
            // 
            this.btnanakaydol.BackColor = System.Drawing.SystemColors.Window;
            this.btnanakaydol.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnanakaydol.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnanakaydol.ForeColor = System.Drawing.Color.Black;
            this.btnanakaydol.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnanakaydol.ImageIndex = 0;
            this.btnanakaydol.ImageList = this.ımageList1;
            this.btnanakaydol.Location = new System.Drawing.Point(244, 13);
            this.btnanakaydol.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnanakaydol.Name = "btnanakaydol";
            this.btnanakaydol.Size = new System.Drawing.Size(100, 115);
            this.btnanakaydol.TabIndex = 4;
            this.btnanakaydol.Text = "KAYDOL";
            this.btnanakaydol.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnanakaydol.UseVisualStyleBackColor = false;
            this.btnanakaydol.Click += new System.EventHandler(this.btnanakaydol_Click);
            this.btnanakaydol.MouseEnter += new System.EventHandler(this.btnanakaydol_MouseEnter);
            this.btnanakaydol.MouseLeave += new System.EventHandler(this.btnanakaydol_MouseLeave);
            // 
            // frmana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(604, 455);
            this.Controls.Add(this.btnanakaydol);
            this.Controls.Add(this.btnanacikis);
            this.Controls.Add(this.btnanagiris);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmana";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ANA FORM";
            this.Load += new System.EventHandler(this.frmana_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnanagiris;
        private System.Windows.Forms.Button btnanacikis;
        private System.Windows.Forms.Button btnanakaydol;
    }
}