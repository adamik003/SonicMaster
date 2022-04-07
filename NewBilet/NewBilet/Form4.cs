using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewBilet
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form5 four = new Form5();
            four.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form3 four = new Form3();
            four.Show();
            this.Hide();
        }
    }
}
