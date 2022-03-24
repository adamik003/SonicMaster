using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Zakup_Biletow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string mainconn = ConfigurationManager.ConnectionStrings["MySqlconnection"].ConnectionString;
            MySqlConnection sqlconn = new MySqlConnection(mainconn);
            string sqlquerykierunek = "select * from kierunek";
            MySqlCommand sqlcomm = new MySqlCommand(sqlquerykierunek, sqlconn);
            sqlconn.Open();
            MySqlDataAdapter sdr = new MySqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Kierunek";
            comboBox1.ValueMember = "id";
            comboBox2.Visible = true;
            label3.Visible = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["MySqlconnection"].ConnectionString;
            MySqlConnection sqlconn = new MySqlConnection(mainconn);
            string sqlquerystatek = "select * from statek where sid=@sid";
            MySqlCommand sqlcomm = new MySqlCommand(sqlquerystatek, sqlconn);
            sqlcomm.Parameters.AddWithValue("@sid", comboBox1.SelectedValue.ToString());
            sqlconn.Open();
            MySqlDataAdapter sdr = new MySqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "Statek";
            comboBox2.ValueMember = "id";
            comboBox2.Visible = true;
            label3.Visible = true;
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form2 bilet = new Form2();
            bilet.label3.Text = this.textBox1.Text;
            bilet.label4.Text = this.textBox2.Text;
            bilet.label7.Text = this.comboBox1.Text;
            bilet.label8.Text = this.comboBox2.Text;
            bilet.Show();
        }


        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Button1_Click(object sender, EventArgs e)
        {

        }
   
    }
}
