using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Students
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\SHS\Documents\Visual Studio 2012\Projects\Students Database\Zain.mdf;Integrated Security=True;Connect Timeout=30");

        DataTable dt = new DataTable();
        SqlDataAdapter sqlda = new SqlDataAdapter();


        private void Form1_Load(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("select * from Student",conn);
            SqlDataAdapter sqlda = new SqlDataAdapter(cmd);
            //sqlda.SelectCommand(cmd);

            sqlda.Fill(dt);
            dataGridView1.DataSource = dt;

            conn.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("insert into Student values('"+int.Parse(txtid.Text)+"','"+txtname.Text+"','"+txtcourse.Text+"')",conn);
            cmd.ExecuteNonQuery();

            conn.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtname.Text = "";
            txtcourse.Text = "";
        }

        private void txtcourse_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("DELETE FROM Student WHERE ID = '" + txtid.Text + "' ", conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }
     
    
    


    }
}
