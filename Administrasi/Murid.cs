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
    public partial class Murid : Form
    {
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        public Murid()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=WINDOWS-CD7O5KF;Initial Catalog=Administrasi_sekolah;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into murid values (@NIS, @NAMA, @KODEKELAS, @JENISKELAMIN, @ALAMAT)", con);
            cmd.Parameters.AddWithValue("@NIS", textBox1.Text);
            cmd.Parameters.AddWithValue("@NAMA", textBox2.Text);
            cmd.Parameters.AddWithValue("@ALAMAT", textBox3.Text);
            cmd.Parameters.AddWithValue("@JENISKELAMIN", textBox4.Text);
            cmd.Parameters.AddWithValue("@KODEKELAS", textBox5.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully saved");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=WINDOWS-CD7O5KF;Initial Catalog=Administrasi_sekolah;Integrated Security=True");
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=WINDOWS-CD7O5KF;Initial Catalog=Administrasi_sekolah;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update murid set NAMA=@NAMA, KODEKELAS=@KODEKELAS JENISKELAMIN=@JENISKELAMIN, ALAMAT=@ALAMAT WHERE NIS=@NIS", con);
            cmd.Parameters.AddWithValue("@NIS", textBox1.Text);
            cmd.Parameters.AddWithValue("@NAMA", textBox2.Text);
            cmd.Parameters.AddWithValue("@ALAMAT", textBox3.Text);
            cmd.Parameters.AddWithValue("@JENISKELAMIN", textBox4.Text);
            cmd.Parameters.AddWithValue("@KODEKELAS", textBox5.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Updated");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=WINDOWS-CD7O5KF;Initial Catalog=Administrasi_sekolah;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Murid", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
