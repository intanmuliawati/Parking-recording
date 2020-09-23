namespace LatihanMysql
{
    partial class DataPetugas
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
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgviewpetugas = new System.Windows.Forms.DataGridView();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.txtidpetugas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblalamat = new System.Windows.Forms.Label();
            this.lbljudul = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnadd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewpetugas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(186, 152);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(100, 20);
            this.txtpassword.TabIndex = 39;
            this.txtpassword.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(103, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 14);
            this.label4.TabIndex = 38;
            this.label4.Text = "Password";
            // 
            // dgviewpetugas
            // 
            this.dgviewpetugas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgviewpetugas.Location = new System.Drawing.Point(164, 218);
            this.dgviewpetugas.Name = "dgviewpetugas";
            this.dgviewpetugas.Size = new System.Drawing.Size(343, 157);
            this.dgviewpetugas.TabIndex = 32;
            this.dgviewpetugas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgviewpetugas_CellContentClick);
            // 
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(416, 118);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(158, 20);
            this.txtnama.TabIndex = 31;
            this.txtnama.TextChanged += new System.EventHandler(this.txtnama_TextChanged);
            // 
            // txtidpetugas
            // 
            this.txtidpetugas.Location = new System.Drawing.Point(186, 120);
            this.txtidpetugas.Name = "txtidpetugas";
            this.txtidpetugas.Size = new System.Drawing.Size(60, 20);
            this.txtidpetugas.TabIndex = 30;
            this.txtidpetugas.TextChanged += new System.EventHandler(this.txtidpetugas_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(316, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 14);
            this.label3.TabIndex = 29;
            this.label3.Text = "Nama Petugas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 28;
            this.label2.Text = "Id Petugas";
            // 
            // lblalamat
            // 
            this.lblalamat.AutoSize = true;
            this.lblalamat.Font = new System.Drawing.Font("Trajan Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblalamat.Location = new System.Drawing.Point(375, 61);
            this.lblalamat.Name = "lblalamat";
            this.lblalamat.Size = new System.Drawing.Size(206, 15);
            this.lblalamat.TabIndex = 60;
            this.lblalamat.Text = "Jl. Moh Toha No.77 Bandung";
            this.lblalamat.Click += new System.EventHandler(this.lblalamat_Click);
            // 
            // lbljudul
            // 
            this.lbljudul.AutoSize = true;
            this.lbljudul.Font = new System.Drawing.Font("Trajan Pro", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbljudul.Location = new System.Drawing.Point(460, 41);
            this.lbljudul.Name = "lbljudul";
            this.lbljudul.Size = new System.Drawing.Size(120, 16);
            this.lbljudul.TabIndex = 59;
            this.lbljudul.Text = "PARKIR PT INTI";
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnupdate.FlatAppearance.BorderSize = 0;
            this.btnupdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnupdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnupdate.Location = new System.Drawing.Point(418, 180);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 36;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btndelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btndelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btndelete.Location = new System.Drawing.Point(499, 180);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 35;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LatihanMysql.Properties.Resources._58db860a4b5d7;
            this.pictureBox2.Location = new System.Drawing.Point(242, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 61;
            this.pictureBox2.TabStop = false;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnadd.CausesValidation = false;
            this.btnadd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnadd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnadd.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnadd.Location = new System.Drawing.Point(357, 180);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(55, 23);
            this.btnadd.TabIndex = 34;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // DataPetugas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(650, 397);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblalamat);
            this.Controls.Add(this.lbljudul);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dgviewpetugas);
            this.Controls.Add(this.txtnama);
            this.Controls.Add(this.txtidpetugas);
            this.Controls.Add(this.label3);
            this.Name = "DataPetugas";
            this.Text = "Data Petugas";
            this.Load += new System.EventHandler(this.DataPetugas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgviewpetugas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView dgviewpetugas;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.TextBox txtidpetugas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbljudul;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblalamat;
    }
}