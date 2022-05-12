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
        public Form3()
        {
            InitializeComponent();
        }

        public void Button1_Click(object sender, EventArgs e)
        {
            Form4 four = new Form4();
            four.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form2 four = new Form2();
            four.Show();
            this.Hide();
        }
    }
}
