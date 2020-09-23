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
    public partial class Jenis_Kendaraan : MetroFramework.Forms.MetroForm
    {
        public MySqlCommand cmd = null;
        public MySqlDataReader reader = null;
        string sql;
        MysqlDB dbconn = new MysqlDB();
        public Jenis_Kendaraan()
        {
            InitializeComponent();
            loadingData();
        }
         private void loadingData()
        {
            dbconn.koneksidb();

           

            Console.WriteLine("\nBegin loading data...");

            try
            {
                MySqlCommand command = new MySqlCommand ("SELECT * FROM jenis_kendaraan",dbconn.connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable table = new DataTable();

                adapter.Fill(table);
                dgviewjenis.DataSource = table;

                dbconn.closeConnection();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to Connect::" + ex.Message);
            }
            
        }

         void clearData()
         {
             txtkodejenis.Text = "";
             txtnamajenis.Text = "";
             txtharga.Text = "";

         }


        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtkodejenis.Text == "") {
                MessageBox.Show("Kode Jenis tidak boleh kosong");
            }
            else if (txtnamajenis.Text == "") {
                MessageBox.Show("Nama jenis tidak boleh kosong");
            }
            else if (txtharga.Text == "")
            {
                MessageBox.Show("Harga tidak boleh kosong");
            }
            else
            {
                dbconn.koneksidb();

                string sql = "INSERT INTO jenis_kendaraan VALUES(" +
                            "'" + txtkodejenis.Text + "', '" + txtnamajenis.Text + "','" + txtharga.Text + "')";

                MySqlCommand command = new MySqlCommand(sql, dbconn.connection);

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil Disimpan");
                    clearData();
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

            sql = "UPDATE jenis_kendaraan set id_jenis='" + txtkodejenis.Text + "',nama_jenis='" + txtnamajenis.Text + "',harga ='" + txtharga.Text + "'WHERE id_jenis='" + txtkodejenis.Text + "'";
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

            clearData();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            dbconn.koneksidb();

            sql = "DELETE FROM jenis_kendaraan WHERE id_jenis='" + txtkodejenis.Text + "'";
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
        }

       

        private void dgviewjenis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgviewjenis.Rows[e.RowIndex];
            txtkodejenis.Text = row.Cells[0].Value.ToString();
            txtnamajenis.Text = row.Cells[1].Value.ToString();
            txtharga.Text = row.Cells[2].Value.ToString();
       
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MenuAdmin menu = new MenuAdmin();
            menu.ShowDialog();
        }

        private void txtharga_TextChanged(object sender, EventArgs e)
        {
            string text = txtharga.Text;
            //bool hasdigit = false;
            int counterX = 0;
            foreach (char Letter in text)
            {
                if (char.IsDigit(Letter))
                {
                    // hasdigit = true; 
                    counterX++;
                }
            }
            if (text.Length != counterX)
            {
                MessageBox.Show("Harga harus numerik");
            }
        }

        private void txtnamajenis_TextChanged(object sender, EventArgs e)
        {
            string text1 = txtnamajenis.Text;
            bool hasdigit = false;
            foreach (char letter in text1)
            {
                if (char.IsDigit(letter))
                {
                    hasdigit = true;
                }
                else
                {
                    hasdigit = false;
                }
            }
            if (hasdigit == true)
            {
                MessageBox.Show("Tidak boleh ada numberik");
                txtnamajenis.Text = "";
            }
        }

        private void txtkodejenis_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
