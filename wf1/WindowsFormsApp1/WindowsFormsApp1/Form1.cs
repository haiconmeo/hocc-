using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //public int tong = 0;
        public Form1()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            int tong = 0;
            if (textBox1.Text == null)
            {
                MessageBox.Show("nhap ten vao m , thnag ngu l");
            }
            if (checkBox1.Checked == true)
            {
                tong += 100;
            }
            if (checkBox2.Checked == true)
            {
                tong += 200;
            }
            if (checkBox3.Checked == true)
            {
                tong += 300;
            }
            int a = Convert.ToInt32(comboBox1.Items[comboBox1.SelectedIndex].ToString());
            textBox2.Text = Convert.ToString(tong*a);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
