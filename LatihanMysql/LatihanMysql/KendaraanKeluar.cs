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
using System.Timers;

namespace LatihanMysql
{
    public partial class KendaraanKeluar : MetroFramework.Forms.MetroForm
    {
        public MySqlCommand cmd = null;
        public MySqlDataReader reader = null;
        string sql;
        MysqlDB dbconn = new MysqlDB();
        string jenis;
        public int harga, x,total;
        string jam = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        public KendaraanKeluar()
        {
            InitializeComponent();
            loadingData();
            autonumber();
            timer1.Enabled = true;
            txtnoparkir.Focus();
          
        }

        private void loadingData()
        {
            dbconn.koneksidb();

            Console.WriteLine("\nBegin loading data...");

            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM Kendaraan_keluar", dbconn.connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable table = new DataTable();

                adapter.Fill(table);
                dgviewkendaraankeluar.DataSource = table;


            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to Connect::" + ex.Message);
            }
        }
        void clearData()
        {
            txtnokeluar.Text = "";
            txtnoparkir.Text = "";
            txtplatno.Text = "";
            txtjammasuk.Text = "";
            txtharga.Text = "";
            txtketerangan.Text = "";
            txtsearch.Text = ""; 
            autonumber();
        }

           

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtnoparkir.Text == "")
            {
                MessageBox.Show(" No parkir tidak boleh kosong");
            }
            else
            {
                hitungjam();
                hitungharga();
                MessageBox.Show("TOTAL HARGA PARKIR = " + txtharga.Text);

                dbconn.koneksidb();
                string sql = "INSERT INTO kendaraan_keluar VALUES(" +
                             "'" + txtnokeluar.Text + "',"
                             + "'" + txtnoparkir.Text + "','" + jam + "','" + txtharga.Text + "','" + txtketerangan.Text + "')";

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
                loadingData();
                clearData();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            dbconn.koneksidb();

            sql = "UPDATE kendaraan_keluar SET id_parkir='" + txtnoparkir.Text + "',jam_keluar='" + jam + "',keterangan='" + txtketerangan.Text + "'WHERE id_keluar ='" + txtnokeluar.Text + "'";
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

            sql = "DELETE FROM kendaraan_keluar WHERE id_keluar='" + txtnokeluar.Text + "'";
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
            txtjammasuk.Text = "";
            loadingData();
            clearData();
        }

        private void btnlihat_Click(object sender, EventArgs e)
        {
            loadingData();
        }
       

        private void isiharga() {
            dbconn.koneksidb();

            try{
                sql = "SELECT harga FROM jenis_kendaraan WHERE "
                   + "id_jenis = '" + txtjenis.Text + "'";
                cmd = new MySqlCommand(sql, dbconn.connection);
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txthargajenis.Text = reader[0].ToString();       
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Data Gagal " + ex.ToString());
            }
        }

        private void txtnoparkir_TextChanged(object sender, EventArgs e)
        {
            string text = txtnoparkir.Text;
            if (text.Length > 10)
            {
                MessageBox.Show("Maximal 8 abjad");
            }

            else
            {
                dbconn.koneksidb();

                try
                {
                    sql = " SELECT M.plat_no, M.jam_masuk, M.id_jenis FROM kendaraan_masuk M LEFT JOIN kendaraan_keluar K ON M.id_parkir = K.id_parkir WHERE K.id_parkir is NULL and M.id_parkir = '" + txtnoparkir.Text + "'";
                    cmd = new MySqlCommand(sql, dbconn.connection);
                    reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtplatno.Text = reader[0].ToString();
                        txtjammasuk.Text = reader[1].ToString();
                        txtjenis.Text = reader[2].ToString();
                        
                    } 
                                    

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Data Gagal " + ex.ToString());
                }
                
                isiharga();
            }
           

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblwaktu.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void hitungjam() {
            DateTime parsedDate = DateTime.Parse(txtjammasuk.Text);
            
            TimeSpan duration = DateTime.Now - parsedDate;
            x = (int)duration.TotalHours;
            txtjam.Text = Convert.ToString(x);
            
        }

        private void txtjammasuk_TextChanged(object sender, EventArgs e)
        {
          
        }
        private void autonumber()
        {
            long hitung;
            string urut;

            dbconn.koneksidb();
            cmd = new MySqlCommand("select id_keluar from kendaraan_keluar where id_keluar in(select max(id_keluar) from kendaraan_keluar) order by id_keluar desc", dbconn.connection);
            reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                // Menambahkan data dari field nomor
                hitung = Convert.ToInt64(reader[0].ToString().Substring(reader["id_keluar"].ToString().Length - 6, 6)) + 1;
                string joinstr = "000000" + hitung;
                // Mengambil 6 karakter kanan terakhir dari string joinstr lalu di tambahkan dengan string URUT
                urut = "K-" + joinstr.Substring(joinstr.Length - 6, 6);
            }
            else
            {
                urut = "K-000001";
            }
            dbconn.closeConnection();
            txtnokeluar.Text = urut;

        }
        public void hitungharga() {
            
            int jam = Convert.ToInt32(txtjam.Text);
            harga = Convert.ToInt32(txthargajenis.Text);
            if (jam < 1)
            {
                total = harga * 1;
            }
            else if(jam >=1 && jam <= 10)
            {
                total = harga * jam;
            }
            else if (jam>10){
                total = harga * 10;
            }
            txtharga.Text = Convert.ToString(total);
        }

        private void txthargajenis_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MenuPetugas menu = new MenuPetugas();
            menu.ShowDialog();
            this.Close();
        }

        private void dgviewkendaraankeluar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgviewkendaraankeluar.Rows[e.RowIndex];
            txtnokeluar.Text = row.Cells[0].Value.ToString();
            txtnoparkir.Text = row.Cells[1].Value.ToString();
            txtharga.Text = row.Cells[3].Value.ToString();
            txtketerangan.Text = row.Cells[4].Value.ToString();
        }

        private void txtplatno_TextChanged(object sender, EventArgs e)
        {
            string text1 = txtplatno.Text;
            if (text1.Length > 10)
            {
                MessageBox.Show("Maximal 10 abjad");
            }
        }

        private void btnhilang_Click(object sender, EventArgs e)
        {
            if (txtsearch.Text == "") {
                MessageBox.Show("Isi plat no terebih dahulu");
            }
            
            dbconn.koneksidb();

            try
            {
                sql = "SELECT id_parkir FROM kendaraan_masuk WHERE "
                   + "plat_no = '" + txtsearch.Text + "' order by id_parkir desc ";
                cmd = new MySqlCommand(sql, dbconn.connection);
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtnoparkir.Text = reader[0].ToString();
                }

            }


            catch (Exception ex)
            {
                MessageBox.Show("Data Gagal " + ex.ToString());
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnokeluar_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblalamat_Click(object sender, EventArgs e)
        {

        }

       

       

       
    }
}
