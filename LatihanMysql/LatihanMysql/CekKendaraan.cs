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
    public partial class Data_kendaraan_belum_keluar : MetroFramework.Forms.MetroForm
    {
        public MySqlCommand cmd = null;
        public MySqlDataReader reader = null;
        string sql;
        MysqlDB dbconn = new MysqlDB();
        public Data_kendaraan_belum_keluar()
        {
            InitializeComponent();
        }

        private void btncari_Click(object sender, EventArgs e)
        {
            if (txtsearch.Text == "")
            {
                MessageBox.Show(" Isi plat no kendaraan terlebih dahulu");
            }
            else
            {
                dbconn.koneksidb();
                try
                {
                    MySqlCommand command = new MySqlCommand("SELECT M.id_parkir, M.plat_no, M.jam_masuk FROM kendaraan_masuk M LEFT JOIN kendaraan_keluar K ON M.id_parkir = K.id_parkir WHERE K.id_parkir is NULL and M.plat_no = '" + txtsearch.Text + "' ", dbconn.connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable table = new DataTable();

                    adapter.Fill(table);
                    dgviewdata.DataSource = table;
                    

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Failed to Connect::" + ex.Message);
                }
            }
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string text = txtsearch.Text;
            if (text.Length > 10) {
                MessageBox.Show("Maximal 10 abjad");
            }

          
        }

      
    }
}
