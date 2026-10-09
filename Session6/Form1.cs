using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session6
{
    public partial class Form1 : Form
    {
        // 1
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-HBA0SC5\\MSSQLSERVER2022;Initial Catalog=DB1;Integrated Security=True;");
        // 2 
        SqlCommand sqlCom = new SqlCommand(); 

        public Form1()
        {
            InitializeComponent();
            // 3
            sqlCom.Connection = con; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Summary 
            // C# 
            // 1. Connection 
            // 2. Command دستورات
            // 3. Execute and Export 
            // SQL 

            DataTable dt = new DataTable(); 
            

            // 4
            sqlCom.Connection.Open();
            // 5 
            sqlCom.CommandText = "Select * From Personel "; // دستورات SQL 
            // 6 
            dt.Load(sqlCom.ExecuteReader());
            // 7 
            sqlCom.Connection.Close();


            dataGridView1.DataSource = dt; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
