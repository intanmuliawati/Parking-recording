using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LatihanMysql
{
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void pbpetugas_Click(object sender, EventArgs e)
        {
            DataPetugas petugas = new DataPetugas();
            petugas.ShowDialog();
        }

        private void pbjenis_Click(object sender, EventArgs e)
        {
            Jenis_Kendaraan jk = new Jenis_Kendaraan();
            jk.ShowDialog();
        }
    }
}
