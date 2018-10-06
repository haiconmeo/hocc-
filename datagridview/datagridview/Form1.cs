using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datagridview
{
    
    public partial class Form1 : Form
    {
        quanlysinhvien ql = new quanlysinhvien();
        public Form1()
        {
            InitializeComponent();
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = ql._dssv;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // DataRow x =  dataGridView1.NewRow();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           if(dataGridView1.SelectedCells.Count > 0)
            {
                int r = dataGridView1.CurrentRow.Index;
                //int c = dataGridView1.CurrentCell.ColumnIndex;
                //string ms = dataGridView1.CurrentCell.Value.ToString();
                t_mssv.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
                t_hoten.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
                d_ngaysinh.Text = dataGridView1.Rows[r].Cells[2].Value.ToString();
                comboBox1.DataSource = ql._dc;
                string addr = dataGridView1.Rows[r].Cells[3].Value.ToString();
                
                comboBox1.SelectedIndex = comboBox1.FindStringExact(addr);
                // b_add.Top = dataGridView1.Rows[r].Cells[3].Value.ToString();


            }

        }
    }
}
