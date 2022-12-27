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
    public partial class Inventory : Form
    {
        string myconnection = @"Server=localhost;Database=Db_Project;uid=root;pwd=Irtaza@147";
        public Inventory()
        {
            InitializeComponent();
        }

        private void label_inven_Click(object sender, EventArgs e)
        {

        }


        private void button_display_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(myconnection))
            {
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("select * from category", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dvg1.DataSource = dt;
            }
        }

        private void dvg1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

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
