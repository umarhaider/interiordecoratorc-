using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interior_DecoratorWPF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label11.Text = "1.75";
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            label11.Text = "1.00";
            checkBox1.Checked = false;
            checkBox3.Checked = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            label11.Text = "0.45";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int roomArea = (int)numericUpDown2.Value + (int)numericUpDown3.Value + (int)numericUpDown4.Value + (int)numericUpDown5.Value;
            string price = (roomArea * float.Parse(label11.Text, CultureInfo.InvariantCulture)).ToString();
            MessageBox.Show("The price will be £" + price, "Price");
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            float number = float.Parse(label11.Text, CultureInfo.InvariantCulture);
            label11.Text = (number + 0.5).ToString();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
