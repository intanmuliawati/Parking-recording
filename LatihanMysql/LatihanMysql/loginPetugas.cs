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
        
    public partial class loginPetugas : MetroFramework.Forms.MetroForm
    {
        public MySqlCommand cmd = null;
        public MySqlDataReader reader = null;
        string sql;
        MysqlDB dbconn = new MysqlDB();
        public loginPetugas()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "") {
                MessageBox.Show("User tidak boleh kosong");
            }
            else if (txtpass.Text == "")
            {
                MessageBox.Show("Password tidak boleh kosong");
            }
            else
            {
                dbconn.koneksidb();

                sql = " select * from petugas where id_petugas ='" + txtuser.Text + "' and password='" + txtpass.Text + "'";
                MySqlCommand command = new MySqlCommand(sql, dbconn.connection);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("Login Berhasil");

                    MenuPetugas menu = new MenuPetugas();
                    menu.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Username dan Password tidak cocok", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtuser.Text = "";
                    txtpass.Text = "";
                    txtuser.Focus();
                }
                dbconn.closeConnection();
            }
           

        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {   

         }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            loginAdmin admin = new loginAdmin();
            admin.ShowDialog();
        }
    }
}
