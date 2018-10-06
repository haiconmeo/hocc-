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


namespace test_ket_noi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kn = "Data Source=DESKTOP-2J8O873;Initial Catalog=quanlysinhvien;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(kn);
            string cmd = "select * from sinhvien";
            cnn.Open();
            SqlDataAdapter ad = new SqlDataAdapter(cmd, cnn);
            
            DataSet ds = new DataSet();
            ad.Fill(ds);
            dataGridView1.DataSource= ds.Tables[0];
            cnn.Close();
        }
    }
}
