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
    public partial class Kendaraan_Masuk : MetroFramework.Forms.MetroForm
    {
        public MySqlCommand cmd = null;
        public MySqlDataReader reader = null;
        string sql;
        MysqlDB dbconn = new MysqlDB();
        string jam = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        public Kendaraan_Masuk()
        {
            InitializeComponent();
            loadingData();
            isicmbjenis();
            autonumber();
            timer1.Enabled = true;
        }
        private void loadingData()
        {
            dbconn.koneksidb();
            Console.WriteLine("\nBegin loading data...");

            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM kendaraan_masuk", dbconn.connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable table = new DataTable();

                adapter.Fill(table);
                dgviewkendaraanmasuk.DataSource = table;

                dbconn.closeConnection();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to Connect::" + ex.Message);
            }

        }
       
        void clearData()
        {

            txtnoparkir.Text = "";
            txtplatno.Text = "";
            cmbjenis.Text = "";
            txtid_jenis.Text = "";
            txtketerangan.Text = "";
            autonumber();
            txtplatno.Focus();
        }
        void isicmbjenis()
        {
            dbconn.koneksidb();

            try
            {
                string sql = "SELECT nama_jenis FROM jenis_kendaraan";
                MySqlCommand command = new MySqlCommand(sql, dbconn.connection);
                reader = command.ExecuteReader();


                while (reader.Read())
                {
                    cmbjenis.Items.Add(reader[0].ToString());

                }
            }

            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }


        }
        public void print() {
            
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtplatno.Text == "")
            {
                MessageBox.Show(" No kendaraan tidak boleh kosong");
            }
            else if (cmbjenis.Text == "") {
                MessageBox.Show(" Jenis Kendaraan tidak boleh kosong");
            }
            else
            {
                dbconn.koneksidb();
                string sql = "INSERT INTO kendaraan_masuk VALUES(" +
                             "'" + txtnoparkir.Text + "',"
                             + "'" + txtplatno.Text + "','" + txtid_jenis.Text + "','" + jam + "','" + txtketerangan.Text + "')";

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
                loadingData();
                clearData();
            }
        }

        private void cmbjenis_SelectedIndexChanged(object sender, EventArgs e)
        {
            dbconn.koneksidb();

            try
            {
                sql = "SELECT id_jenis FROM jenis_kendaraan WHERE "
                   + "nama_jenis = '" + cmbjenis.Text + "'";
                cmd = new MySqlCommand(sql, dbconn.connection);
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtid_jenis.Text = reader[0].ToString();
                }

            }


            catch (Exception ex)
            {
                MessageBox.Show("Data Gagal " + ex.ToString());
            }


        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            dbconn.koneksidb();

            sql = "UPDATE kendaraan_masuk SET plat_no='" + txtplatno.Text + "',id_jenis='" + txtid_jenis.Text + "',jam_masuk='" + jam + "',keterangan='" + txtketerangan.Text + "'WHERE id_parkir='" + txtnoparkir.Text + "'";
            cmd = new MySqlCommand(sql, dbconn.connection);

            try
            {

                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Tersimpan");
                loadingData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("data gagal diupdate " + ex);
            }
            loadingData();
            clearData();

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            dbconn.koneksidb();

            sql = "DELETE FROM kendaraan_masuk WHERE id_parkir='" + txtnoparkir.Text + "'";
            cmd = new MySqlCommand(sql, dbconn.connection);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil dihapus");
                loadingData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("data gagal dihapus " + ex);
            }
            loadingData();
            clearData();
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            loadingData();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblwaktu.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void autonumber() {
            long hitung;
            string urut;

            dbconn.koneksidb();
            cmd = new MySqlCommand("select id_parkir from kendaraan_masuk where id_parkir in(select max(id_parkir) from kendaraan_masuk) order by id_parkir desc", dbconn.connection);
            reader = cmd.ExecuteReader();
            reader.Read();
             if (reader.HasRows)
            {
                // Menambahkan data dari field nomor
                hitung = Convert.ToInt64(reader[0].ToString().Substring(reader["id_parkir"].ToString().Length - 6, 6)) + 1;
                string joinstr = "000000" + hitung;
                // Mengambil 4 karakter kanan terakhir dari string joinstr lalu di tambahkan dengan string URUT
                urut = "P-" + joinstr.Substring(joinstr.Length - 6, 6);
            }
            else
            {
                urut = "P-000001";
            }
            dbconn.closeConnection();
            txtnoparkir.Text = urut;
                        
        }

        private void Kendaraan_Masuk_Load(object sender, EventArgs e)
        {
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var font1 = new Font("Arial", 10);
            var font2 = new Font("Arial", 8);
            e.Graphics.DrawString("\t" + lbljudul.Text + "\n", font1, Brushes.Black, 70, 15);
            e.Graphics.DrawString("\t" + lblalamat.Text + "\n", font2, Brushes.Black, 55, 40);
            e.Graphics.DrawString("\n-------------------------------------------------------------\n", font2, Brushes.Black, 25, 40);
            e.Graphics.DrawString("\n" + "No Parkir \t: " + txtnoparkir.Text + "\n\n", font2, Brushes.Black, 25, 65);
            e.Graphics.DrawString("\n" + "Waktu masuk \t: " + jam + "\n", font2, Brushes.Black, 25, 90);
        }

        private void dgviewkendaraanmasuk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgviewkendaraanmasuk.Rows[e.RowIndex];
            txtnoparkir.Text = row.Cells[0].Value.ToString();
            txtplatno.Text = row.Cells[1].Value.ToString();
            cmbjenis.Text = row.Cells[2].Value.ToString();
            txtketerangan.Text = row.Cells[4].Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MenuPetugas menu = new MenuPetugas();
            menu.ShowDialog();
        }

        private void lblwaktu_Click(object sender, EventArgs e)
        {

        }

        private void txtnoparkir_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtplatno_TextChanged(object sender, EventArgs e)
        {
            string text = txtplatno.Text;
            if (text.Length > 10)
            {
                MessageBox.Show("Maximal 10 abjad");
                txtplatno.Text = "";
            }
            
        }

        private void txtketerangan_TextChanged(object sender, EventArgs e)
        {

        }

           
        
     
    }
}
