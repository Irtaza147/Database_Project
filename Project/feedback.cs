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
    public partial class feedback : Form
    {
        string myconnection = @"Server=localhost;Database=db_project;uid=root;pwd=Irtaza@147";
        public feedback()
        {
            InitializeComponent();
        }

        private void button_log_Click(object sender, EventArgs e)
        {
            MessageBox.Show("<====Thanks for Coming====>");
            this.Hide();
            Person_identify frm = new Person_identify();
            frm.ShowDialog();
            this.Close();
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(myconnection))

            {
                con.Open();

                using (MySqlCommand com = new MySqlCommand("insert into feedback (f_name,comment)" + "values (@f_name,@comment)", con))
                {
                    com.CommandType = CommandType.Text;
                    com.Parameters.AddWithValue("@f_name", text_name.Text);
                    com.Parameters.AddWithValue("@comment", text_comment.Text);

                    try
                    {
                        com.ExecuteNonQuery();
                        MessageBox.Show("Thanks for your Feedback :)");
                    }
                    catch
                    {
                        MessageBox.Show("Feedback must not be Empty");
                    }
                    }
            }
        }

        private void button_place_Click(object sender, EventArgs e)
        {
            this.Hide();
            Items frm = new Items();
            frm.ShowDialog();
            this.Close();
        }

        private void text_comment_TextChanged(object sender, EventArgs e)
        {

        }

        private void feedback_Load(object sender, EventArgs e)
        {

        }
    }
}
