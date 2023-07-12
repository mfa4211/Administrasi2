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
    public partial class Kelas : Form
    {
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        public Kelas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=WINDOWS-CD7O5KF;Initial Catalog=Administrasi_sekolah;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Kelas values (@KODE_KELAS, @NAMA, @GURU)", con);
            cmd.Parameters.AddWithValue("@KODE_KELAS", textBox1.Text);
            cmd.Parameters.AddWithValue("@NAMA", textBox2.Text);
            cmd.Parameters.AddWithValue("@GURU", textBox3.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully saved");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=WINDOWS-CD7O5KF;Initial Catalog=Administrasi_sekolah;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete Kelas where KODE_KELAS=@KODE_KELAS", con);
            cmd.Parameters.AddWithValue("@KODE_KELAS", textBox1.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Deleted");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=WINDOWS-CD7O5KF;Initial Catalog=Administrasi_sekolah;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update Kelas set NAMA=@NAMA, GURU=@GURU WHERE KODE_KELAS=@KODE_KELAS", con);
            cmd.Parameters.AddWithValue("@KODE_KELAS", textBox1.Text);
            cmd.Parameters.AddWithValue("@NAMA", textBox2.Text);
            cmd.Parameters.AddWithValue("@GURU", textBox3.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully UPDATED");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=WINDOWS-CD7O5KF;Initial Catalog=Administrasi_sekolah;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Kelas", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
