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
    public partial class DataPetugas : MetroFramework.Forms.MetroForm
    {
        public MySqlCommand cmd = null;
        public MySqlDataReader reader = null;
        string sql;
        MysqlDB dbconn = new MysqlDB();
        public DataPetugas()
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
                MySqlCommand command = new MySqlCommand ("SELECT * FROM petugas",dbconn.connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable table = new DataTable();

                adapter.Fill(table);
                dgviewpetugas.DataSource = table;

                dbconn.closeConnection();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to Connect::" + ex.Message);
            }
            
        }

         void clearData()
         {
             txtidpetugas.Text ="";
             txtnama.Text = "";
             txtpassword.Text = "";

         }

        
        
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtidpetugas.Text == "") {
                MessageBox.Show(" Id Petugas tidak boleh kosong");
            }
            else if (txtnama.Text == "") {
                MessageBox.Show(" Nama Petugas tidak boleh kosong");
            }
            else if (txtpassword.Text == "")
            {
                MessageBox.Show(" Password tidak boleh kosong");
            }
            else
            {
                dbconn.koneksidb();

                string sql = "INSERT INTO petugas VALUES(" +
                            "'" + txtidpetugas.Text + "', '" + txtnama.Text + "','" + txtpassword.Text + "')";

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

            sql = "UPDATE petugas SET nama_petugas ='" + txtnama.Text + "',password ='" + txtpassword.Text + "' WHERE id_petugas='" + txtidpetugas.Text + "'";
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

        private void dgviewpetugas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgviewpetugas.Rows[e.RowIndex];
            txtidpetugas.Text = row.Cells[0].Value.ToString();
            txtnama.Text = row.Cells[1].Value.ToString();
            txtpassword.Text = row.Cells[2].Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MenuAdmin menu = new MenuAdmin();
            menu.ShowDialog();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            dbconn.koneksidb();

            sql = "DELETE FROM petugas WHERE id_petugas='" + txtidpetugas.Text + "'";
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

        private void DataPetugas_Load(object sender, EventArgs e)
        {

        }

        private void lblalamat_Click(object sender, EventArgs e)
        {


        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            string text = txtpassword.Text;
            if (text.Length > 12) 
            {
                MessageBox.Show(" maximal 12 karakter ");
            }
        }

        private void txtnama_TextChanged(object sender, EventArgs e)
        {
            string text1 = txtnama.Text;
            bool hasdigit = false;
            foreach( char letter in text1)
            {
                if ( char.IsDigit(letter))
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
                txtnama.Text = "";
            }
            
            
        }

        private void txtidpetugas_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
