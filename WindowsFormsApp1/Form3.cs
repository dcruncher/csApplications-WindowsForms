using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String ConnectionString = @"server=localhost;user id=root;persistsecurityinfo=True;database=vb_db;password=root";
            //SqlConnection con = new SqlConnection(ConnectionString);
            MySqlConnection con = new MySqlConnection(ConnectionString);
            //String sql = "insert into user values(" +textBox1.Text +",'"+textBox2.Text +"','"+textBox3.Text +"')";
            

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("insert into user values(" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Values Inserted");
                con.Close();
            }
            catch(MySqlException exp)
            {
                MessageBox.Show("Error:" + exp.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String ConnectionString = @"server=localhost;user id=root;persistsecurityinfo=True;database=vb_db;password=root";
            //SqlConnection con = new SqlConnection(ConnectionString);
            MySqlConnection con = new MySqlConnection(ConnectionString);
            //String sql = "insert into user values(" +textBox1.Text +",'"+textBox2.Text +"','"+textBox3.Text +"')";


            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select * from user where userid=" + textBox1.Text ,con);
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if(dr.HasRows)
                {
                    MessageBox.Show("Name:"+ dr.GetValue(1).ToString()+", Department:" + dr.GetValue(2).ToString());
                }
                else
                {
                    MessageBox.Show("record not found");
                }
                
                con.Close();
            }
            catch (MySqlException exp)
            {
                MessageBox.Show("Error:" + exp.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String ConnectionString = @"server=localhost;user id=root;persistsecurityinfo=True;database=vb_db;password=root";
            //SqlConnection con = new SqlConnection(ConnectionString);
            MySqlConnection con = new MySqlConnection(ConnectionString);
            //String sql = "insert into user values(" +textBox1.Text +",'"+textBox2.Text +"','"+textBox3.Text +"')";


            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("delete from user where userid=" + textBox1.Text, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Values deleted");
                con.Close();
            }
            catch (MySqlException exp)
            {
                MessageBox.Show("Error:" + exp.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String ConnectionString = @"server=localhost;user id=root;persistsecurityinfo=True;database=vb_db;password=root";
            //SqlConnection con = new SqlConnection(ConnectionString);
            MySqlConnection con = new MySqlConnection(ConnectionString);
            //String sql = "insert into user values(" +textBox1.Text +",'"+textBox2.Text +"','"+textBox3.Text +"')";


            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("update user set username='"+textBox2.Text+"',department ='"+textBox3.Text+"' where userid=" + textBox1.Text, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Values updated");
                con.Close();
            }
            catch (MySqlException exp)
            {
                MessageBox.Show("Error:" + exp.ToString());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
