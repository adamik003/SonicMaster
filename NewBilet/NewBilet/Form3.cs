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

namespace NewBilet
{
    public partial class Form3 : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=sql11.freesqldatabase.com;port=3306;username=sql11483539;password=mjvFMUAGj5;");
        public Form3()
        {
            InitializeComponent();
        }

        public void Button1_Click(object sender, EventArgs e)
        {
            Form4 four = new Form4();
            four.Show();
            this.Hide();

            

            string insertQuery = "INSERT INTO sql11483539.Bilet(sniadanie,basen) VALUES('" + checkBox1.Checked + "','" + checkBox2.Checked + "')";
            connection.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, connection);

            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data Inserted");
                }
                else
                {
                    MessageBox.Show("Data Not Inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connection.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form2 four = new Form2();
            four.Show();
            this.Hide();
        }
    }
}
