using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool check_l()
        {
            if (textBox1.Text.Length >= 6)
            {
                MessageBox.Show("qua");
                kq();
                textBox1.Text = "";
                return true;
            }
            return false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (!check_l())
            {
                textBox1.Text += "2";
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!check_l())
            {
                textBox1.Text += "1";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!check_l())
            {
                textBox1.Text += "3";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!check_l())
            {
                textBox1.Text += "4";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!check_l())
            {
                textBox1.Text += "5";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!check_l())
            {
                textBox1.Text += "6";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!check_l())
            {
                textBox1.Text += "7";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (!check_l())
            {
                textBox1.Text += "8";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!check_l())
            {
                textBox1.Text += "9";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (!check_l())
            {
                textBox1.Text += "0";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text=  textBox1.Text.Remove(textBox1.Text.Length-1);
        }
        private void kq()
        {
            if (textBox1.Text == "411765")
            {
                MessageBox.Show("mai yeu");
                listBox1.Items.Add(DateTime.Now + "   mat khau dung");
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("mat khau sai");
                listBox1.Items.Add(DateTime.Now + "    mat khau sai");
                textBox1.Text = "";
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            kq();
        }
    }
}
