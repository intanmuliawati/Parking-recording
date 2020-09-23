namespace LatihanMysql
{
    partial class MenuAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAdmin));
            this.pbjenis = new System.Windows.Forms.PictureBox();
            this.pbpetugas = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbjenis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbpetugas)).BeginInit();
            this.SuspendLayout();
            // 
            // pbjenis
            // 
            this.pbjenis.Image = ((System.Drawing.Image)(resources.GetObject("pbjenis.Image")));
            this.pbjenis.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbjenis.InitialImage")));
            this.pbjenis.Location = new System.Drawing.Point(448, 158);
            this.pbjenis.Name = "pbjenis";
            this.pbjenis.Size = new System.Drawing.Size(116, 89);
            this.pbjenis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbjenis.TabIndex = 3;
            this.pbjenis.TabStop = false;
            this.pbjenis.Click += new System.EventHandler(this.pbjenis_Click);
            // 
            // pbpetugas
            // 
            this.pbpetugas.Image = ((System.Drawing.Image)(resources.GetObject("pbpetugas.Image")));
            this.pbpetugas.InitialImage = null;
            this.pbpetugas.Location = new System.Drawing.Point(260, 158);
            this.pbpetugas.Name = "pbpetugas";
            this.pbpetugas.Size = new System.Drawing.Size(108, 89);
            this.pbpetugas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbpetugas.TabIndex = 2;
            this.pbpetugas.TabStop = false;
            this.pbpetugas.Click += new System.EventHandler(this.pbpetugas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SkyBlue;
            this.label1.Location = new System.Drawing.Point(270, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "DATA PEGAWAI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SkyBlue;
            this.label2.Location = new System.Drawing.Point(454, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "JENIS KENDARAAN";
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(817, 381);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbjenis);
            this.Controls.Add(this.pbpetugas);
            this.DoubleBuffered = true;
            this.Name = "MenuAdmin";
            this.Text = "Menu Admin";
            ((System.ComponentModel.ISupportInitialize)(this.pbjenis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbpetugas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbjenis;
        private System.Windows.Forms.PictureBox pbpetugas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}