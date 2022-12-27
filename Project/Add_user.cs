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
    public partial class Add_user : Form
    {
        string myconnection = @"Server=localhost;Database=Db_Project;uid=root;pwd=Irtaza@147";

        public Add_user()
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

        private void button1_Click(object sender, EventArgs e)
        {

            using (MySqlConnection con = new MySqlConnection(myconnection))

            {
                con.Open();
                string passwordhash = toMD5(text_pass.Text);

                using (MySqlCommand com = new MySqlCommand("insert into user values(@ID,@f_name,@l_name,'" + passwordhash + "',@address)", con))
                {
                    com.Parameters.AddWithValue("@ID", text_id.Text);
                    com.Parameters.AddWithValue("@f_name", text_f_name.Text.Trim());
                    com.Parameters.AddWithValue("@l_name", text_l_name.Text);
                    com.Parameters.AddWithValue("@password", text_pass.Text.Trim());
                    com.Parameters.AddWithValue("@address", text_add.Text.Trim());

                    com.ExecuteNonQuery();
                    MessageBox.Show("Record save successfully");
                }
                this.Hide();
                login_user frm = new login_user();
                frm.ShowDialog();
                this.Close();
            }
        }
    }
}
