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
    public partial class Form3 : Form
    {
        public Form3(string Imie, string Nazwisko, string Kierunek, string Data, string Pokoj)
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
            Form1 four = new Form1(); 
            four.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
