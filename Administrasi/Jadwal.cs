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
    public partial class Jadwal : Form
    {
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        public Jadwal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=WINDOWS-CD7O5KF;Initial Catalog=Administrasi_sekolah;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Jadwal values (@ID, @GURU,  @HARI, @WAKTU, @KODE)", con);
            cmd.Parameters.AddWithValue("@ID", textBox1.Text);
            cmd.Parameters.AddWithValue("@GURU", textBox2.Text);
            cmd.Parameters.AddWithValue("@HARI", textBox3.Text);
            cmd.Parameters.AddWithValue("@WAKTU", textBox4.Text);
            cmd.Parameters.AddWithValue("@KODE", textBox5.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully saved");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=WINDOWS-CD7O5KF;Initial Catalog=Administrasi_sekolah;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete Jadwal where ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", textBox1.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Deleted");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=WINDOWS-CD7O5KF;Initial Catalog=Administrasi_sekolah;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Jadwal set GURU=@GURU, HARI=@HARI, WAKTU=@WAKTU, KODE_kelas=@KODE WHERE Id_jadwal=@ID", con);
            cmd.Parameters.AddWithValue("@ID", textBox1.Text);
            cmd.Parameters.AddWithValue("@GURU", textBox2.Text);
            cmd.Parameters.AddWithValue("@HARI", textBox3.Text);
            cmd.Parameters.AddWithValue("@WAKTU", textBox4.Text);
            cmd.Parameters.AddWithValue("@KODE", textBox5.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully UPDATED");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=WINDOWS-CD7O5KF;Initial Catalog=Administrasi_sekolah;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Jadwal", con);
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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
