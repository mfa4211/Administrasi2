using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Administrasi
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataMuridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Murid m = new Murid();
            m.ShowDialog();
        }

        private void dataGuruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Guru g = new Guru();
            g.ShowDialog();
        }

        private void jadwalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Jadwal j = new Jadwal();
            j.ShowDialog();
        }

        private void mataPelajaranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mapel map = new Mapel();
            map.ShowDialog();
        }

        private void kelasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kelas kel = new Kelas();
            kel.ShowDialog();
        }
    }
}
