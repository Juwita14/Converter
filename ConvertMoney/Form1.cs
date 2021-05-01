using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertMoney
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = int.Parse(textBox1.Text);
            if (comboBox1.SelectedItem == "IDR" && comboBox3.SelectedItem == "USD")
            {
                Double conv = i / 14084;
                conv = System.Math.Round(conv, 2);
                label4.Text = "Converted Amount: " + conv + "\t $";
            }
            if (comboBox1.SelectedItem == "IDR" && comboBox3.SelectedItem == "JYP")
            {
                Double conv = i / 13482.04;
                conv = System.Math.Round(conv, 2);
                label4.Text = "Converted Amount: " + conv + "\t yen";
            }
            if (comboBox1.SelectedItem == "IDR" && comboBox3.SelectedItem == "IDR")
            {
                Double conv = i;
                label4.Text = "Converted Amount: " + conv + "\t Rupiah";
            }
            if (comboBox1.SelectedItem == "USD" && comboBox3.SelectedItem == "IDR")
            {
                Double conv = i * 14084;
                conv = System.Math.Round(conv, 2);
                label4.Text = "Converted Amount: " + conv + "\t Rupiah";
            }
            if (comboBox1.SelectedItem == "USD" && comboBox3.SelectedItem == "JYP")
            {
                Double conv = i * 109.98;
                conv = System.Math.Round(conv, 2);
                label4.Text = "Converted Amount: " + conv + "\t yen";
            }
            if (comboBox1.SelectedItem == "USD" && comboBox3.SelectedItem == "USD")
            {
                Double conv = i;
                label4.Text = "Converted Amount: " + conv + "\t $";
            }
            if (comboBox1.SelectedItem == "JYP" && comboBox3.SelectedItem == "IDR")
            {
                Double conv = i * 131.44;
                conv = System.Math.Round(conv, 2);
                label4.Text = "Converted Amount: " + conv + "\t Rupiah";
            }
            if (comboBox1.SelectedItem == "JYP" && comboBox3.SelectedItem == "USD")
            {
                Double conv = i * 0.0091;
                conv = System.Math.Round(conv, 2);
                label4.Text = "Converted Amount: " + conv + "\t $";
            }
            if (comboBox1.SelectedItem == "JYP" && comboBox3.SelectedItem == "JYP")
            {
                Double conv = i;
                label4.Text = "Converted Amount: " + conv + "\t yen";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
