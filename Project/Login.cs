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
    public partial class Login : Form
    {
        public static string myconnection = @"Server=localhost;Database=db_project;uid=root;pwd=Irtaza@147";
        public Login()
        {
            InitializeComponent();
        }
        public static bool checkAdminExists(string Admin_User_Name)
        {
            bool flag = false;
            using (MySqlConnection con = new MySqlConnection(myconnection))
            {
                con.Open();
                string loginQuery = "SELECT COUNT(*) FROM admin WHERE username=\"" + Admin_User_Name + "\"";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(loginQuery, con))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    if (dt.Rows[0][0].ToString() != "0")
                    {
                        flag = true;
                    }
                }
                con.Close();
            }
            return flag;
        }
        private void clear_fields()
        {
            text_pass.Text = "";
            text_user.Text = "";
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
        private void button_user_Click(object sender, EventArgs e)
        {

            if (checkAdminExists(text_user.Text))
            {

                using (MySqlConnection con = new MySqlConnection(myconnection))
                {
                    string passwordhash = toMD5(text_pass.Text);
                    Int32 verify;
                    string query1 = "Select count(*) from admin where username='" + text_user.Text + "' and password='" + passwordhash + "' ";
                    MySqlCommand cmd1 = new MySqlCommand(query1, con);
                    con.Open();
                    verify = Convert.ToInt32(cmd1.ExecuteScalar());
                    con.Close();

                    if (verify > 0)
                    {
                        this.Hide();
                        admin_job frm = new admin_job();
                        frm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Username or Password is Incorrect");
                        clear_fields();
                    }
                }
            }
            else
            {
                MessageBox.Show("Admin Not Found! Please Contact Your Developer.");
                clear_fields();
            }
        }

        private void button_Menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Person_identify frm = new Person_identify();
            frm.ShowDialog();
            this.Close();
        }

        private void text_user_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void text_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
