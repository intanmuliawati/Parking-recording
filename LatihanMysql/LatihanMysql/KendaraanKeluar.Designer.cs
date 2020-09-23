namespace LatihanMysql
{
    partial class KendaraanKeluar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KendaraanKeluar));
            this.label8 = new System.Windows.Forms.Label();
            this.txtplatno = new System.Windows.Forms.TextBox();
            this.txtjammasuk = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.dgviewkendaraankeluar = new System.Windows.Forms.DataGridView();
            this.txtnokeluar = new System.Windows.Forms.TextBox();
            this.txtharga = new System.Windows.Forms.TextBox();
            this.txtketerangan = new System.Windows.Forms.TextBox();
            this.txtnoparkir = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtjenis = new System.Windows.Forms.TextBox();
            this.txthargajenis = new System.Windows.Forms.TextBox();
            this.lblwaktu = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtjam = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.lblalamat = new System.Windows.Forms.Label();
            this.lbljudul = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewkendaraankeluar)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 67;
            this.label8.Text = "Plat No";
            // 
            // txtplatno
            // 
            this.txtplatno.Location = new System.Drawing.Point(147, 162);
            this.txtplatno.Name = "txtplatno";
            this.txtplatno.Size = new System.Drawing.Size(100, 20);
            this.txtplatno.TabIndex = 66;
            this.txtplatno.TextChanged += new System.EventHandler(this.txtplatno_TextChanged);
            // 
            // txtjammasuk
            // 
            this.txtjammasuk.Location = new System.Drawing.Point(147, 197);
            this.txtjammasuk.Name = "txtjammasuk";
            this.txtjammasuk.Size = new System.Drawing.Size(124, 20);
            this.txtjammasuk.TabIndex = 65;
            this.txtjammasuk.TextChanged += new System.EventHandler(this.txtjammasuk_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 64;
            this.label5.Text = "Jam Keluar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(935, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btndelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btndelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btndelete.Location = new System.Drawing.Point(196, 331);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 62;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnupdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnupdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnupdate.Location = new System.Drawing.Point(106, 331);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 61;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnadd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnadd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnadd.Location = new System.Drawing.Point(15, 331);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 59;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dgviewkendaraankeluar
            // 
            this.dgviewkendaraankeluar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgviewkendaraankeluar.Location = new System.Drawing.Point(479, 85);
            this.dgviewkendaraankeluar.Name = "dgviewkendaraankeluar";
            this.dgviewkendaraankeluar.Size = new System.Drawing.Size(551, 317);
            this.dgviewkendaraankeluar.TabIndex = 57;
            this.dgviewkendaraankeluar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgviewkendaraankeluar_CellContentClick);
            // 
            // txtnokeluar
            // 
            this.txtnokeluar.Location = new System.Drawing.Point(147, 91);
            this.txtnokeluar.Name = "txtnokeluar";
            this.txtnokeluar.Size = new System.Drawing.Size(100, 20);
            this.txtnokeluar.TabIndex = 56;
            this.txtnokeluar.TextChanged += new System.EventHandler(this.txtnokeluar_TextChanged);
            // 
            // txtharga
            // 
            this.txtharga.Location = new System.Drawing.Point(147, 272);
            this.txtharga.Name = "txtharga";
            this.txtharga.Size = new System.Drawing.Size(100, 20);
            this.txtharga.TabIndex = 55;
            this.txtharga.Visible = false;
            // 
            // txtketerangan
            // 
            this.txtketerangan.Location = new System.Drawing.Point(147, 234);
            this.txtketerangan.Multiline = true;
            this.txtketerangan.Name = "txtketerangan";
            this.txtketerangan.Size = new System.Drawing.Size(124, 25);
            this.txtketerangan.TabIndex = 54;
            // 
            // txtnoparkir
            // 
            this.txtnoparkir.Location = new System.Drawing.Point(147, 127);
            this.txtnoparkir.Name = "txtnoparkir";
            this.txtnoparkir.Size = new System.Drawing.Size(100, 20);
            this.txtnoparkir.TabIndex = 53;
            this.txtnoparkir.TextChanged += new System.EventHandler(this.txtnoparkir_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "Jam Masuk";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(476, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "DATA KENDARAAN KELUAR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Keterangan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Harga";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "No Parkir";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "No Keluar";
            // 
            // txtjenis
            // 
            this.txtjenis.Location = new System.Drawing.Point(355, 217);
            this.txtjenis.Name = "txtjenis";
            this.txtjenis.Size = new System.Drawing.Size(100, 20);
            this.txtjenis.TabIndex = 69;
            this.txtjenis.Visible = false;
            // 
            // txthargajenis
            // 
            this.txthargajenis.Location = new System.Drawing.Point(355, 250);
            this.txthargajenis.Name = "txthargajenis";
            this.txthargajenis.Size = new System.Drawing.Size(100, 20);
            this.txthargajenis.TabIndex = 68;
            this.txthargajenis.Visible = false;
            this.txthargajenis.TextChanged += new System.EventHandler(this.txthargajenis_TextChanged);
            // 
            // lblwaktu
            // 
            this.lblwaktu.AutoSize = true;
            this.lblwaktu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwaktu.Location = new System.Drawing.Point(364, 194);
            this.lblwaktu.Name = "lblwaktu";
            this.lblwaktu.Size = new System.Drawing.Size(30, 16);
            this.lblwaktu.TabIndex = 70;
            this.lblwaktu.Text = "jam";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtjam
            // 
            this.txtjam.Location = new System.Drawing.Point(355, 282);
            this.txtjam.Name = "txtjam";
            this.txtjam.Size = new System.Drawing.Size(100, 20);
            this.txtjam.TabIndex = 71;
            this.txtjam.Visible = false;
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnsearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnsearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnsearch.Location = new System.Drawing.Point(15, 379);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 75;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnhilang_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(116, 381);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(155, 20);
            this.txtsearch.TabIndex = 76;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // lblalamat
            // 
            this.lblalamat.AutoSize = true;
            this.lblalamat.Font = new System.Drawing.Font("Trajan Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblalamat.Location = new System.Drawing.Point(738, 57);
            this.lblalamat.Name = "lblalamat";
            this.lblalamat.Size = new System.Drawing.Size(192, 14);
            this.lblalamat.TabIndex = 78;
            this.lblalamat.Text = "Jl. Moh Toha No.77 Bandung";
            this.lblalamat.Click += new System.EventHandler(this.lblalamat_Click);
            // 
            // lbljudul
            // 
            this.lbljudul.AutoSize = true;
            this.lbljudul.Font = new System.Drawing.Font("Trajan Pro", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbljudul.Location = new System.Drawing.Point(810, 36);
            this.lbljudul.Name = "lbljudul";
            this.lbljudul.Size = new System.Drawing.Size(120, 16);
            this.lbljudul.TabIndex = 77;
            this.lbljudul.Text = "PARKIR PT INTI";
            // 
            // KendaraanKeluar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 423);
            this.Controls.Add(this.lblalamat);
            this.Controls.Add(this.lbljudul);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtjam);
            this.Controls.Add(this.lblwaktu);
            this.Controls.Add(this.txtjenis);
            this.Controls.Add(this.txthargajenis);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtplatno);
            this.Controls.Add(this.txtjammasuk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dgviewkendaraankeluar);
            this.Controls.Add(this.txtnokeluar);
            this.Controls.Add(this.txtharga);
            this.Controls.Add(this.txtketerangan);
            this.Controls.Add(this.txtnoparkir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KendaraanKeluar";
            this.Text = "KendaraanKeluar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewkendaraankeluar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtplatno;
        private System.Windows.Forms.TextBox txtjammasuk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView dgviewkendaraankeluar;
        private System.Windows.Forms.TextBox txtnokeluar;
        private System.Windows.Forms.TextBox txtharga;
        private System.Windows.Forms.TextBox txtketerangan;
        private System.Windows.Forms.TextBox txtnoparkir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtjenis;
        private System.Windows.Forms.TextBox txthargajenis;
        private System.Windows.Forms.Label lblwaktu;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtjam;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label lblalamat;
        private System.Windows.Forms.Label lbljudul;
    }
}