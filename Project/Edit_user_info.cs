using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    
    public partial class edituserinfo : Form
    {
        string myconnection = @"Server=localhost;Database=Db_Project;uid=root;pwd=Irtaza@147";
        public edituserinfo()
        {
            InitializeComponent();
        }
        public static string toMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                    sb.Append(hashBytes[i].ToString("X2"));
                return sb.ToString();
            }
        }
            private void edituserinfo_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_display_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(myconnection))
            {
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("select * from user", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dvg.DataSource = dt;
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(myconnection))

            {
                con.Open();

                using (MySqlCommand com = new MySqlCommand("delete from user where User_id=@User_id", con))
                {
                    com.CommandType = CommandType.Text;
                    com.Parameters.AddWithValue("@User_id", text_delete.Text);

                    try
                    {
                        com.ExecuteNonQuery();
                        MessageBox.Show("Record Deleted successfully :)");
                    }
                    catch
                    {
                        MessageBox.Show("Kindly insert correct value :(");
                    }

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(myconnection))

            {
                con.Open();

                using (MySqlCommand com = new MySqlCommand("update user set F_name=@f_name where User_id=@User_id", con))
                {
                    com.Parameters.AddWithValue("@User_id", text_id.Text);
                    com.Parameters.AddWithValue("@f_name", text_f_name.Text);


                    try
                    {
                        com.ExecuteNonQuery();
                        MessageBox.Show("Record Updated successfully :)");
                    }
                    catch
                    {
                        MessageBox.Show("Kindly insert correct values :(");
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(myconnection))

            {
                con.Open();

                using (MySqlCommand com = new MySqlCommand("update user set L_name=@f_name where User_id=@User_id", con))
                {
                    com.Parameters.AddWithValue("@User_id", text_id.Text);
                    com.Parameters.AddWithValue("@L_name", text_l_name.Text);

                    try
                    {
                        com.ExecuteNonQuery();
                        MessageBox.Show("Record Updated successfully :)");
                    }
                    catch
                    {
                        MessageBox.Show("Kindly insert correct values :(");
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(myconnection))

            {
                string passwordhash = toMD5(text_pass.Text);
                con.Open();

                using (MySqlCommand com = new MySqlCommand("update user set password='" + passwordhash + "' where User_id=@User_id", con))
                {
                    com.Parameters.AddWithValue("@User_id", text_id.Text);
                    com.Parameters.AddWithValue("@password", text_pass.Text);


                    try
                    {
                        com.ExecuteNonQuery();
                        MessageBox.Show("Record Updated successfully :)");
                    }
                    catch
                    {
                        MessageBox.Show("Kindly insert correct values :(");
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(myconnection))

            {
                con.Open();

                using (MySqlCommand com = new MySqlCommand("update user set address=@address where User_id=@User_id", con))
                {
                    com.Parameters.AddWithValue("@User_id", text_id.Text);
                    com.Parameters.AddWithValue("@address", text_add.Text);


                    try
                    {
                        com.ExecuteNonQuery();
                        MessageBox.Show("Record Updated successfully :)");
                    }
                    catch
                    {
                        MessageBox.Show("Kindly insert correct values :(");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(myconnection))

            {
                con.Open();

                using (MySqlCommand com = new MySqlCommand("update user set F_name=@F_name,L_name=@L_name,password=@password,address=@address where User_id=@User_id;", con))
                {
                    com.Parameters.AddWithValue("@User_id", text_id.Text);
                    com.Parameters.AddWithValue("@F_name", text_f_name.Text);
                    com.Parameters.AddWithValue("@L_name", text_l_name.Text);
                    com.Parameters.AddWithValue("@password", text_pass.Text);
                    com.Parameters.AddWithValue("@address", text_add.Text);


                    try
                    {
                        com.ExecuteNonQuery();
                        MessageBox.Show("Record Updated successfully :)");
                    }
                    catch
                    {
                        MessageBox.Show("Kindly insert correct values :(");
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_job frm = new admin_job();
            frm.ShowDialog();
            this.Close();
        }

        private void text_f_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
