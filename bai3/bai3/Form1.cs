using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai3
{
    
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        //DataRow r = new DataRow()
        //DataRow r = dt.NewRow();
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataRow r = dt.NewRow();
            r["FoodName"] = "Phô mai Tôm ";
            r["Quatity"] = 1;
            dt.Rows.Add(r);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            dt.Columns.Add("FoodName");
            dt.Columns.Add("Quatity");
            dataGridView1.DataSource = dt;
            //DataRow r = dt.NewRow();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           DataRow r = dt.NewRow();
            r["FoodName"] = "Phô mai bò ";
            r["Quatity"] = 1;
            //dt.Rows.Add(r);
            add_data(r);
        }
        private void add_data(DataRow s)
        {
            if (dataGridView1.Rows.Equals(s))
            {
                s["Quatity"] = Convert.ToInt32(s["Quatity"])+1;
            }
            else
                dt.Rows.Add(s);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DataRow r = dt.NewRow();
            r["FoodName"] = "Phô mai gà ";
            r["Quatity"] = 1;
            add_data(r);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataRow r = dt.NewRow();
            r["FoodName"] = "Phô mai cá ";
            r["Quatity"] = 1;
            add_data(r);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataRow r = dt.NewRow();
            r["FoodName"] = "tôm viên cola ";
            r["Quatity"] = 1;
            dt.Rows.Add(r);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataRow r = dt.NewRow();
            r["FoodName"] = "gà viên cola ";
            r["Quatity"] = 1;
            add_data(r);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DataRow r = dt.NewRow();
            r["FoodName"] = "gà rán phần  ";
            r["Quatity"] = 1;
            add_data(r);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DataRow r = dt.NewRow();
            r["FoodName"] = "cơm gà tender ";
            r["Quatity"] = 1;
            add_data(r);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DataRow r = dt.NewRow();
            r["FoodName"] = "pepsi ";
            r["Quatity"] = 1;
            add_data(r);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DataRow r = dt.NewRow();
            r["FoodName"] = "7 up ";
            r["Quatity"] = 1;
            add_data(r);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DataRow r = dt.NewRow();
            r["FoodName"] = "cafe ";
            r["Quatity"] = 1;
            add_data(r);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DataRow r = dt.NewRow();
            r["FoodName"] = " cola ";
            r["Quatity"] = 1;
            add_data(r);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            DataRow r = dt.NewRow();
            r["FoodName"] = "liptop ";
            r["Quatity"] = 1;
            add_data(r);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            DataRow r = dt.NewRow();
            r["FoodName"] = "cam ";
            r["Quatity"] = 1;
            add_data(r);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DataRow r = dt.NewRow();
            r["FoodName"] = "khoai tây chiên ";
            r["Quatity"] = 1;
            add_data(r);
        }

        private void button16_Click(object sender, EventArgs e)
        {
           foreach ( DataGridViewRow i in dataGridView1.SelectedRows)
            {
                if(!i.IsNewRow)
                {
                    dataGridView1.Rows.Remove(i);
                }
            }
        }
    }
}
