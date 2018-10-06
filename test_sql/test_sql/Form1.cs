using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace test_sql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Show()
        {
            string s = "Data Source=DESKTOP-2J8O873;Initial Catalog=quanlysinhvien;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(s);
            cnn.Open();
            string cmd = "Select * from Sinhvien";
            SqlDataAdapter xx = new SqlDataAdapter(cmd, cnn);
            DataSet ds = new DataSet();
            xx.Fill(ds, "manh");
            cnn.Close();
            dataGridView1.DataSource = ds.Tables["manh"];
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string s = "Data Source=DESKTOP-2J8O873;Initial Catalog=quanlysinhvien;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(s);
            cnn.Open();
            string cmd = "Select * from Sinhvien";
            SqlDataAdapter xx = new SqlDataAdapter(cmd, cnn);
            DataSet ds = new DataSet();
            xx.Fill(ds, "manh");
            cnn.Close();
            dataGridView1.DataSource = ds.Tables["manh"];
            
            //textBox1.Text = ds.Tables["manh"].Columns["name"].ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                textBox1.Text = dataGridView1.SelectedRows[0].Cells["name"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "Data Source=DESKTOP-2J8O873;Initial Catalog=quanlysinhvien;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(s);
            cnn.Open();
            string cmd = "update sinhvien set name ='manh' where mssv=1";
            //SqlCommand sq = new SqlCommand(cmd,cnn);
            // SqlDataReader doc = sq.ExecuteReader();
            SqlDataAdapter sa = new SqlDataAdapter("Select * from Sinhvien",cnn);
            DataSet ds = new DataSet();
            sa.Fill(ds);
            SqlCommandBuilder ud = new SqlCommandBuilder(sa);
            // DataTable dt = ds.Tables[0];
            /* DataRow dr = dt.NewRow();
             dr["mssv"] = "7";
             dr["name"] = "7";
             dr["qender"] = true;
             dr["birthday"] = "1996-05-05";
             dr["address"] = "7";
             dt.Rows.Add(dr);*/
            ds.Tables[0].Rows[0]["name"] = textBox1.Text;
            sa.Update(ds);
            dataGridView1.DataSource = ds.Tables[0];


            cnn.Close();
        }
    }
}
