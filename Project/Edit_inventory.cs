﻿using MySql.Data.MySqlClient;
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
    public partial class Edit_inventory : Form
    {
        string myconnection = @"Server=localhost;Database=Db_Project;uid=root;pwd=Irtaza@147";
        public Edit_inventory()
        {
            InitializeComponent();
        }

        private void button_stock_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(myconnection))

            {
                con.Open();

                using (MySqlCommand com = new MySqlCommand("update inventory set Stock=@f_name where Product_id=@Product_id", con))
                {
                    com.Parameters.AddWithValue("@Product_id", text_id.Text);
                    com.Parameters.AddWithValue("@f_name", text_stock.Text);


                    com.ExecuteNonQuery();
                    MessageBox.Show("Record Updated successfully");
                }
            }
        }

        private void button_display_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(myconnection))
            {
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("select * from inventory", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dvg.DataSource = dt;
            }
        }

        private void button_price_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(myconnection))

            {
                con.Open();

                using (MySqlCommand com = new MySqlCommand("update inventory set Price=@Price where Product_id=@Product_id", con))
                {
                    com.Parameters.AddWithValue("@Product_id", text_id.Text);
                    com.Parameters.AddWithValue("@Price", text_price.Text);


                    com.ExecuteNonQuery();
                    MessageBox.Show("Record Updated successfully");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_job frm = new admin_job();
            frm.ShowDialog();
            this.Close();
        }
    }
}