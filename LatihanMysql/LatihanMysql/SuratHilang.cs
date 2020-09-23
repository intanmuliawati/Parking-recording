using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace LatihanMysql
{
    public partial class SuratHilang : MetroFramework.Forms.MetroForm
    {
        public MySqlCommand cmd = null;
        public MySqlDataReader reader = null;
        string sql;
        MysqlDB dbconn = new MysqlDB();
        string jam = DateTime.Now.ToString("yyyy-MM-dd ");
        public SuratHilang()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string text2 = txtciri.Text;
            if (text2.Length > 80)
            {
                MessageBox.Show("Maximal 80 abjad");
            }
        }
        public void print()
        {

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            var font1 = new Font("Arial", 14);
            var font2 = new Font("Arial", 12);
            e.Graphics.DrawString("\t\t  SURAT TANDA KEHILANGAN KENDARAAN \n", font1, Brushes.Black, 70, 15);
            e.Graphics.DrawString("\t\t\t\t" + lbljudul.Text + "\n", font1, Brushes.Black, 70, 45);
            e.Graphics.DrawString("\t\t\t\t    " + lblalamat.Text + "\n", font2, Brushes.Black, 55, 75);
            e.Graphics.DrawString("\n-----------------------------------------------------------------------------------------------------------------------------------------------\n", font2, Brushes.Black, 25, 85 );
            e.Graphics.DrawString("\n Dengan surat ini telah dinyatakangan hilang sebuah kendaraan dengan keterangan sebagai  \n", font2, Brushes.Black, 70, 130);
            e.Graphics.DrawString("\nberikut : \n", font2, Brushes.Black, 35, 160);
            e.Graphics.DrawString("\n" + "No Kendaraan \t\t: " + txtnokendaraan.Text + "\n", font2, Brushes.Black, 35, 200);
            e.Graphics.DrawString("\n" + "Nama Pemilik \t\t: " + txtnamapemilik.Text + "\n", font2, Brushes.Black, 35, 230);
            e.Graphics.DrawString("\n" + "Tanggal Hilang \t\t: " + jam + "\n", font2, Brushes.Black, 35, 260);
            e.Graphics.DrawString("\n" + "Ciri-Ciri Kendaraan \t: " + txtciri.Text + "\n", font2, Brushes.Black, 35, 290);
            e.Graphics.DrawString("\n" + "Keterangan \t\t: " + txtketeranan.Text + "\n", font2, Brushes.Black, 35, 320);
            e.Graphics.DrawString("\n" + "Nama Petugas \t\t: " + txtpetugas.Text + "\n", font2, Brushes.Black, 35, 350);
            e.Graphics.DrawString("\nDemikian surat ini dibuat dengan sebenar-benarnya.  \n", font2, Brushes.Black, 35, 390);
            e.Graphics.DrawString("\n" + "Bandung, " + jam + "\n", font2, Brushes.Black, 650, 490);
            e.Graphics.DrawString("\nYang bertanda tangan dibawah ini,  \n", font2, Brushes.Black, 35, 520);
            e.Graphics.DrawString("\n" + txtnamapemilik.Text + "\n", font2, Brushes.Black, 35, 620);
            e.Graphics.DrawString("\nPetugas,  \n", font2, Brushes.Black, 650, 520);
            e.Graphics.DrawString("\n" + txtpetugas.Text + "\n", font2, Brushes.Black, 650, 620);
        }
        public void clearData() {
            txtpetugas.Text = "";
            txtnokendaraan.Text = "";
            txtnamapemilik.Text = "";
            txtketeranan.Text = "";
            txtciri.Text = "";
        }
        private void btnprint_Click(object sender, EventArgs e)
        {
            if (txtnokendaraan.Text == "") {
                MessageBox.Show("No Kendaraan tidak boleh kosong");    
            }
            else if (txtnamapemilik.Text == "") {
                MessageBox.Show("Nama pemilik kendaraan tidak boleh kosong");
            }
            else if (txtpetugas.Text == "") {
                MessageBox.Show("Nama petugas tidak boleh kosong");
            }
            else{
            dbconn.koneksidb();

            string sql = "INSERT INTO kendaraan_hilang VALUES(" +
                        "'" + txtnokendaraan.Text + "', '" + txtnamapemilik.Text+ "','" + jam + "','" + txtciri.Text + "','" + txtketeranan.Text + "','" + txtpetugas.Text + "')";

            MySqlCommand command = new MySqlCommand(sql, dbconn.connection);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Disimpan");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Gagal Disimpan" + ex.ToString());
            }
            
            print();
            clearData();
            }
        }

        private void SuratHilang_Load(object sender, EventArgs e)
        {

        }

        private void txtnamapemilik_TextChanged(object sender, EventArgs e)
        {
            string text = txtnamapemilik.Text;
            bool hasnumerik = false;
            foreach (char letter in text)
            {
                if (char.IsDigit(letter))
                {
                    hasnumerik = true;
                }
                else
                {
                    hasnumerik = false;
                }
            }
            if (hasnumerik == true)
            {
                MessageBox.Show("Tidak boleh ada numberik");
                txtnamapemilik.Text = "";
            }
        }

        private void txtnokendaraan_TextChanged(object sender, EventArgs e)
        {
            string text1 = txtnokendaraan.Text;
            if (text1.Length > 10)
            {
                MessageBox.Show("Maximal 10 abjad");
            }
        }

        private void txtketeranan_TextChanged(object sender, EventArgs e)
        {
            string text3 = txtciri.Text;
            if (text3.Length > 80)
            {
                MessageBox.Show("Maximal 80 abjad");
            }
        }
    }
}
