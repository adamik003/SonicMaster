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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string Kierunek = comboBox3.SelectedValue as string;
            string Data = comboBox1.SelectedValue as string;
            string Pokoj = comboBox2.SelectedValue as string;
            string Imie = textBox1.Text;
            string Nazwisko = textBox2.Text;
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && comboBox3.SelectedIndex > 0 && comboBox1.SelectedIndex > 0 && comboBox2.SelectedIndex > 0)
            {
                Form3 three = new Form3(Imie, Nazwisko, Kierunek, Data, Pokoj); // Pominięcie dodawania osób do biletu
                three.Show();              // za pomocą Form2.
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wprowadz wszystkie dane!", "Potrzebne informacje!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Kierunek = comboBox3.SelectedValue as string;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Data = comboBox1.SelectedValue as string;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Pokoj = comboBox2.SelectedValue as string;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string Imie = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string Nazwisko = textBox2.Text;
        }
    }
}
