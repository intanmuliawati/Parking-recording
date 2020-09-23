namespace LatihanMysql
{
    partial class SuratHilang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuratHilang));
            this.lblalamat = new System.Windows.Forms.Label();
            this.lbljudul = new System.Windows.Forms.Label();
            this.btnprint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnokendaraan = new System.Windows.Forms.TextBox();
            this.txtnamapemilik = new System.Windows.Forms.TextBox();
            this.txtciri = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.txtketeranan = new System.Windows.Forms.TextBox();
            this.txtpetugas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblalamat
            // 
            this.lblalamat.AutoSize = true;
            this.lblalamat.Font = new System.Drawing.Font("Trajan Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblalamat.Location = new System.Drawing.Point(175, 64);
            this.lblalamat.Name = "lblalamat";
            this.lblalamat.Size = new System.Drawing.Size(192, 14);
            this.lblalamat.TabIndex = 80;
            this.lblalamat.Text = "Jl. Moh Toha No.77 Bandung";
            // 
            // lbljudul
            // 
            this.lbljudul.AutoSize = true;
            this.lbljudul.Font = new System.Drawing.Font("Trajan Pro", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbljudul.Location = new System.Drawing.Point(210, 42);
            this.lbljudul.Name = "lbljudul";
            this.lbljudul.Size = new System.Drawing.Size(120, 16);
            this.lbljudul.TabIndex = 79;
            this.lbljudul.Text = "PARKIR PT INTI";
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnprint.Location = new System.Drawing.Point(409, 93);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(75, 23);
            this.btnprint.TabIndex = 77;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = false;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 81;
            this.label1.Text = "No Kendaraan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 82;
            this.label2.Text = "Nama Pemilik";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 84;
            this.label4.Text = "Ciri-Ciri Kendaraan";
            // 
            // txtnokendaraan
            // 
            this.txtnokendaraan.Location = new System.Drawing.Point(173, 100);
            this.txtnokendaraan.Name = "txtnokendaraan";
            this.txtnokendaraan.Size = new System.Drawing.Size(187, 20);
            this.txtnokendaraan.TabIndex = 85;
            this.txtnokendaraan.TextChanged += new System.EventHandler(this.txtnokendaraan_TextChanged);
            // 
            // txtnamapemilik
            // 
            this.txtnamapemilik.Location = new System.Drawing.Point(173, 133);
            this.txtnamapemilik.Name = "txtnamapemilik";
            this.txtnamapemilik.Size = new System.Drawing.Size(187, 20);
            this.txtnamapemilik.TabIndex = 86;
            this.txtnamapemilik.TextChanged += new System.EventHandler(this.txtnamapemilik_TextChanged);
            // 
            // txtciri
            // 
            this.txtciri.Location = new System.Drawing.Point(175, 166);
            this.txtciri.Multiline = true;
            this.txtciri.Name = "txtciri";
            this.txtciri.Size = new System.Drawing.Size(185, 79);
            this.txtciri.TabIndex = 88;
            this.txtciri.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 89;
            this.label3.Text = "Keterangan";
            // 
            // txtketeranan
            // 
            this.txtketeranan.Location = new System.Drawing.Point(175, 259);
            this.txtketeranan.Multiline = true;
            this.txtketeranan.Name = "txtketeranan";
            this.txtketeranan.Size = new System.Drawing.Size(185, 79);
            this.txtketeranan.TabIndex = 90;
            this.txtketeranan.TextChanged += new System.EventHandler(this.txtketeranan_TextChanged);
            // 
            // txtpetugas
            // 
            this.txtpetugas.Location = new System.Drawing.Point(173, 344);
            this.txtpetugas.Name = "txtpetugas";
            this.txtpetugas.Size = new System.Drawing.Size(187, 20);
            this.txtpetugas.TabIndex = 92;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 91;
            this.label5.Text = "Nama Petugas";
            // 
            // SuratHilang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 411);
            this.Controls.Add(this.txtpetugas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtketeranan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtciri);
            this.Controls.Add(this.txtnamapemilik);
            this.Controls.Add(this.txtnokendaraan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblalamat);
            this.Controls.Add(this.lbljudul);
            this.Controls.Add(this.btnprint);
            this.Name = "SuratHilang";
            this.Text = "SuratHilang";
            this.Load += new System.EventHandler(this.SuratHilang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblalamat;
        private System.Windows.Forms.Label lbljudul;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnokendaraan;
        private System.Windows.Forms.TextBox txtnamapemilik;
        private System.Windows.Forms.TextBox txtciri;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtketeranan;
        private System.Windows.Forms.TextBox txtpetugas;
        private System.Windows.Forms.Label label5;
    }
}