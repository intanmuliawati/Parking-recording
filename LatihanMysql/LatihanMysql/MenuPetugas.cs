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
    public partial class MenuPetugas : Form
    {
        public MenuPetugas()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Kendaraan_Masuk KM = new Kendaraan_Masuk();
            KM.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            KendaraanKeluar KK = new KendaraanKeluar();
            KK.ShowDialog();
        }

        private void pbexit_Click(object sender, EventArgs e)
        {
            Data_kendaraan_belum_keluar dk = new Data_kendaraan_belum_keluar();
            dk.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SuratHilang sh = new SuratHilang();
            sh.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginPetugas lp = new loginPetugas();
            lp.ShowDialog();
        }

      
    }
}
