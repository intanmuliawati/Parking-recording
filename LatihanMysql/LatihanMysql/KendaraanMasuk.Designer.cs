namespace LatihanMysql
{
    partial class Kendaraan_Masuk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kendaraan_Masuk));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblwaktu = new System.Windows.Forms.Label();
            this.txtplatno = new System.Windows.Forms.TextBox();
            this.cmbjenis = new System.Windows.Forms.ComboBox();
            this.txtid_jenis = new System.Windows.Forms.TextBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.dgviewkendaraanmasuk = new System.Windows.Forms.DataGridView();
            this.txtnoparkir = new System.Windows.Forms.TextBox();
            this.txtketerangan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbljam = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblplat = new System.Windows.Forms.Label();
            this.lblparkir = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.lbljudul = new System.Windows.Forms.Label();
            this.lblalamat = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewkendaraanmasuk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblwaktu
            // 
            this.lblwaktu.AutoSize = true;
            this.lblwaktu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwaktu.ForeColor = System.Drawing.Color.DimGray;
            this.lblwaktu.Location = new System.Drawing.Point(134, 188);
            this.lblwaktu.Name = "lblwaktu";
            this.lblwaktu.Size = new System.Drawing.Size(90, 25);
            this.lblwaktu.TabIndex = 56;
            this.lblwaktu.Text = "lblwaktu";
            this.lblwaktu.Click += new System.EventHandler(this.lblwaktu_Click);
            // 
            // txtplatno
            // 
            this.txtplatno.Location = new System.Drawing.Point(131, 124);
            this.txtplatno.Name = "txtplatno";
            this.txtplatno.Size = new System.Drawing.Size(121, 20);
            this.txtplatno.TabIndex = 55;
            this.txtplatno.TextChanged += new System.EventHandler(this.txtplatno_TextChanged);
            // 
            // cmbjenis
            // 
            this.cmbjenis.FormattingEnabled = true;
            this.cmbjenis.Location = new System.Drawing.Point(131, 158);
            this.cmbjenis.Name = "cmbjenis";
            this.cmbjenis.Size = new System.Drawing.Size(121, 21);
            this.cmbjenis.TabIndex = 54;
            this.cmbjenis.SelectedIndexChanged += new System.EventHandler(this.cmbjenis_SelectedIndexChanged);
            // 
            // txtid_jenis
            // 
            this.txtid_jenis.Location = new System.Drawing.Point(270, 159);
            this.txtid_jenis.Name = "txtid_jenis";
            this.txtid_jenis.Size = new System.Drawing.Size(121, 20);
            this.txtid_jenis.TabIndex = 52;
            this.txtid_jenis.Visible = false;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btndelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btndelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btndelete.Location = new System.Drawing.Point(212, 278);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 51;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnupdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnupdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnupdate.Location = new System.Drawing.Point(115, 278);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 50;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnadd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnadd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnadd.Location = new System.Drawing.Point(17, 278);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 49;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dgviewkendaraanmasuk
            // 
            this.dgviewkendaraanmasuk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgviewkendaraanmasuk.Location = new System.Drawing.Point(414, 88);
            this.dgviewkendaraanmasuk.Name = "dgviewkendaraanmasuk";
            this.dgviewkendaraanmasuk.Size = new System.Drawing.Size(555, 283);
            this.dgviewkendaraanmasuk.TabIndex = 47;
            this.dgviewkendaraanmasuk.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgviewkendaraanmasuk_CellContentClick);
            // 
            // txtnoparkir
            // 
            this.txtnoparkir.Location = new System.Drawing.Point(131, 93);
            this.txtnoparkir.Name = "txtnoparkir";
            this.txtnoparkir.Size = new System.Drawing.Size(100, 20);
            this.txtnoparkir.TabIndex = 46;
            this.txtnoparkir.TextChanged += new System.EventHandler(this.txtnoparkir_TextChanged);
            // 
            // txtketerangan
            // 
            this.txtketerangan.Location = new System.Drawing.Point(131, 228);
            this.txtketerangan.Name = "txtketerangan";
            this.txtketerangan.Size = new System.Drawing.Size(100, 20);
            this.txtketerangan.TabIndex = 45;
            this.txtketerangan.TextChanged += new System.EventHandler(this.txtketerangan_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Keterangan";
            // 
            // lbljam
            // 
            this.lbljam.AutoSize = true;
            this.lbljam.Location = new System.Drawing.Point(14, 192);
            this.lbljam.Name = "lbljam";
            this.lbljam.Size = new System.Drawing.Size(64, 13);
            this.lbljam.TabIndex = 43;
            this.lbljam.Text = "Jam Masuk ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Jenis Kendaraan";
            // 
            // lblplat
            // 
            this.lblplat.AutoSize = true;
            this.lblplat.Location = new System.Drawing.Point(14, 127);
            this.lblplat.Name = "lblplat";
            this.lblplat.Size = new System.Drawing.Size(97, 13);
            this.lblplat.TabIndex = 41;
            this.lblplat.Text = "No Plat Kendaraan";
            // 
            // lblparkir
            // 
            this.lblparkir.AutoSize = true;
            this.lblparkir.Location = new System.Drawing.Point(14, 93);
            this.lblparkir.Name = "lblparkir";
            this.lblparkir.Size = new System.Drawing.Size(51, 13);
            this.lblparkir.TabIndex = 40;
            this.lblparkir.Text = "No Parkir";
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
            // lbljudul
            // 
            this.lbljudul.AutoSize = true;
            this.lbljudul.Font = new System.Drawing.Font("Trajan Pro", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbljudul.Location = new System.Drawing.Point(747, 45);
            this.lbljudul.Name = "lbljudul";
            this.lbljudul.Size = new System.Drawing.Size(120, 16);
            this.lbljudul.TabIndex = 57;
            this.lbljudul.Text = "PARKIR PT INTI";
            // 
            // lblalamat
            // 
            this.lblalamat.AutoSize = true;
            this.lblalamat.Font = new System.Drawing.Font("Trajan Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblalamat.Location = new System.Drawing.Point(677, 64);
            this.lblalamat.Name = "lblalamat";
            this.lblalamat.Size = new System.Drawing.Size(192, 14);
            this.lblalamat.TabIndex = 58;
            this.lblalamat.Text = "Jl. Moh Toha No.77 Bandung";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(873, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // Kendaraan_Masuk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 401);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblalamat);
            this.Controls.Add(this.lbljudul);
            this.Controls.Add(this.lblwaktu);
            this.Controls.Add(this.txtplatno);
            this.Controls.Add(this.cmbjenis);
            this.Controls.Add(this.txtid_jenis);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dgviewkendaraanmasuk);
            this.Controls.Add(this.txtnoparkir);
            this.Controls.Add(this.txtketerangan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbljam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblplat);
            this.Controls.Add(this.lblparkir);
            this.Name = "Kendaraan_Masuk";
            this.Text = "Kendaraan Masuk";
            this.Load += new System.EventHandler(this.Kendaraan_Masuk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgviewkendaraanmasuk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblwaktu;
        private System.Windows.Forms.TextBox txtplatno;
        private System.Windows.Forms.ComboBox cmbjenis;
        private System.Windows.Forms.TextBox txtid_jenis;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView dgviewkendaraanmasuk;
        private System.Windows.Forms.TextBox txtnoparkir;
        private System.Windows.Forms.TextBox txtketerangan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbljam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblplat;
        private System.Windows.Forms.Label lblparkir;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label lbljudul;
        private System.Windows.Forms.Label lblalamat;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}