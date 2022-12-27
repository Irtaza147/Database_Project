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
    public partial class Cart : Form
    {
        string myconnection = @"Server=localhost;Database=Db_Project;uid=root;pwd=Irtaza@147";
        public Cart()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(myconnection))
            {
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("select * from cart", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dvg_cart.DataSource = dt;
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Items frm = new Items();
            frm.ShowDialog();
            this.Close();
        }

        private void button_order_Click(object sender, EventArgs e)
        {
            this.Hide();
            Order frm = new Order();
            frm.ShowDialog();
            this.Close();
        }

        private void dvg_cart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Cart_Load(object sender, EventArgs e)
        {

        }
    }
}
