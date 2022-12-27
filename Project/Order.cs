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
    public partial class Order : Form
    {
        string myconnection = @"Server=localhost;Database=db_project;uid=root;pwd=Irtaza@147";
        public Order()
        {
            InitializeComponent();
        }

        private void button_Order_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(myconnection))

            {
                con.Open();

                using (MySqlCommand com = new MySqlCommand("delete from cart", con))
                {

                    com.ExecuteNonQuery();
                }
            }
            this.Hide();
            feedback frm = new feedback();
            frm.ShowDialog();
            this.Close();
        }

        private void dvg_Order_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_display_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(myconnection))
            {
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("select i.Product_id,i.Name,i.Price,u.F_name,u.L_name,u.address from user u,inventory i,cart c where u.User_id=c.user_id and c.p_id=i.Product_id;", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dvg_Order.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(myconnection))

            {
                con.Open();

                using (MySqlCommand com = new MySqlCommand("delete from cart", con))
                {
                  
                    com.ExecuteNonQuery();
                    MessageBox.Show("Record Deleted successfully");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Items frm = new Items();
            frm.ShowDialog();
            this.Close();
        }
    }
}
