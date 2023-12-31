﻿using System;
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
    public partial class Mapel : Form
    {
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        public Mapel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=WINDOWS-CD7O5KF;Initial Catalog=Administrasi_sekolah;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Mata_Pelajaran values (@MAPEL_ID, @NAMA, @GURU)", con);
            cmd.Parameters.AddWithValue("@MAPEL_ID", textBox1.Text);
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
            SqlCommand cmd = new SqlCommand("Delete Mata_Pelajaran where MAPEL_ID=@MAPEL_ID", con);
            cmd.Parameters.AddWithValue("@MAPEL_ID", textBox1.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Deleted");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=WINDOWS-CD7O5KF;Initial Catalog=Administrasi_sekolah;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Mata_Pelajaran set NAMA_MAPEL=@NAMA, GURU=@GURU  WHERE MAPEL_ID=@MAPEL_ID", con);
            cmd.Parameters.AddWithValue("@MAPEL_ID", textBox1.Text);
            cmd.Parameters.AddWithValue("@NAMA", textBox2.Text);
            cmd.Parameters.AddWithValue("@GURU", textBox3.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Updated");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=WINDOWS-CD7O5KF;Initial Catalog=Administrasi_sekolah;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Mata_pelajaran", con);
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

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
