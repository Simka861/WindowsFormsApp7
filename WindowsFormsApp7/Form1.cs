using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label7.Text = "Зарплата : " + textBox1.Text + "\nФамилия : " + textBox2.Text + "\nДолжность : " + Dolgnost.Text + "\nГород" + comboBox1.Text + "\nУлица" + comboBox2.Text + "\nДом" + textBox3.Text;
        }
    }
}
