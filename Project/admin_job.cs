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
    public partial class admin_job : Form
    {
        string myconnection = @"Server=localhost;Database=Db_Project;uid=root;pwd=Irtaza@147";
        public admin_job()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            edituserinfo frm = new edituserinfo();
            frm.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edit_inventory frm = new Edit_inventory();
            frm.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Person_identify frm = new Person_identify();
            frm.ShowDialog();
            this.Close();
        }
    }
}
