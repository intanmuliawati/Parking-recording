namespace LatihanMysql
{
    partial class Data_kendaraan_belum_keluar
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
            this.btncari = new System.Windows.Forms.Button();
            this.dgviewdata = new System.Windows.Forms.DataGridView();
            this.lblalamat = new System.Windows.Forms.Label();
            this.lbljudul = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewdata)).BeginInit();
            this.SuspendLayout();
            // 
            // btncari
            // 
            this.btncari.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btncari.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btncari.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btncari.Location = new System.Drawing.Point(59, 81);
            this.btncari.Name = "btncari";
            this.btncari.Size = new System.Drawing.Size(75, 23);
            this.btncari.TabIndex = 2;
            this.btncari.Text = "Search";
            this.btncari.UseVisualStyleBackColor = false;
            this.btncari.Click += new System.EventHandler(this.btncari_Click);
            // 
            // dgviewdata
            // 
            this.dgviewdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgviewdata.Location = new System.Drawing.Point(93, 126);
            this.dgviewdata.Name = "dgviewdata";
            this.dgviewdata.Size = new System.Drawing.Size(347, 207);
            this.dgviewdata.TabIndex = 3;
            // 
            // lblalamat
            // 
            this.lblalamat.AutoSize = true;
            this.lblalamat.Font = new System.Drawing.Font("Trajan Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblalamat.Location = new System.Drawing.Point(288, 88);
            this.lblalamat.Name = "lblalamat";
            this.lblalamat.Size = new System.Drawing.Size(192, 14);
            this.lblalamat.TabIndex = 76;
            this.lblalamat.Text = "Jl. Moh Toha No.77 Bandung";
            // 
            // lbljudul
            // 
            this.lbljudul.AutoSize = true;
            this.lbljudul.Font = new System.Drawing.Font("Trajan Pro", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbljudul.Location = new System.Drawing.Point(359, 63);
            this.lbljudul.Name = "lbljudul";
            this.lbljudul.Size = new System.Drawing.Size(120, 16);
            this.lbljudul.TabIndex = 75;
            this.lbljudul.Text = "PARKIR PT INTI";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(149, 84);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(123, 20);
            this.txtsearch.TabIndex = 77;
            this.txtsearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Data_kendaraan_belum_keluar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 371);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.lblalamat);
            this.Controls.Add(this.lbljudul);
            this.Controls.Add(this.dgviewdata);
            this.Controls.Add(this.btncari);
            this.Name = "Data_kendaraan_belum_keluar";
            this.Text = "Cek Kendaraan";
            ((System.ComponentModel.ISupportInitialize)(this.dgviewdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncari;
        private System.Windows.Forms.DataGridView dgviewdata;
        private System.Windows.Forms.Label lblalamat;
        private System.Windows.Forms.Label lbljudul;
        private System.Windows.Forms.TextBox txtsearch;
    }
}