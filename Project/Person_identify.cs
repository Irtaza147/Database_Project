using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project
{
    public partial class Person_identify : Form
    {
        string myconnection = @"Server=localhost;Database=Db_Project;uid=root;pwd=Irtaza@147";
        public Person_identify()
        {
            InitializeComponent();
        }

        private void button_admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frm = new Login();
            frm.ShowDialog();
            this.Close();
        }

        private void button_cus_Click(object sender, EventArgs e)
        {
            this.Hide();
            login_user frm = new login_user();
            frm.ShowDialog();
            this.Close();
        }
    }
}
