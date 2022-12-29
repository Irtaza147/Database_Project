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
    public partial class Items : Form
    {
        string myconnection = @"Server=localhost;Database=db_project;uid=root;pwd=Irtaza@147";
        public Items()
        {
            InitializeComponent();
        }

        private void button_simple_Click(object sender, EventArgs e)
        {

        }

        private void button_display_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(myconnection))
            {
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("select * from inventory", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dvg2.DataSource = dt;
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {


            using (MySqlConnection con = new MySqlConnection(myconnection))

            {
                con.Open();

                using (MySqlCommand com = new MySqlCommand("insert into cart (p_id,User_id)" + "values (@p_id,@User_id)", con)) 
                {
                    com.Parameters.AddWithValue("@p_id", text_pro_id.Text);
                    com.Parameters.AddWithValue("@User_id",text_user_id.Text);

                    try
                    {
                        com.ExecuteNonQuery();
                        MessageBox.Show("Record save successfully :(");
                    }
                    catch
                    {
                        MessageBox.Show("Kindly Insert correct value :(");
                    } 
                    
                }
            }
            using (MySqlConnection con = new MySqlConnection(myconnection))

            {
                con.Open();

                using (MySqlCommand com = new MySqlCommand("UPDATE inventory SET stock = stock - 1 WHERE Product_id = @p_id;", con))
                {
                    com.Parameters.AddWithValue("@p_id", text_pro_id.Text);

                    com.ExecuteNonQuery();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cart frm = new Cart();
            frm.ShowDialog();
            this.Close();
        }

        private void text_user_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_pro_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void Items_Load(object sender, EventArgs e)
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
    }
    }

