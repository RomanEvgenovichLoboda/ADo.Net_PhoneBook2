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

namespace ADo.Net_PhoneBook2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateTable();
        }
        private void UpdateTable(int n = 0)
        {
            string command = ""; 
            if(n == 0) { command = "SELECT * FROM [Telephones2]"; }
            if (n == 1) { command = "SELECT * FROM [Telephones2] ORDER BY Name"; }
            if (n == 2) { command = "SELECT * FROM [Telephones2] ORDER BY SecondName"; }
            if (n == 3) { command = "SELECT * FROM [Telephones2] ORDER BY LastName"; }
            if (n == 4) { command = "SELECT * FROM [Telephones2] ORDER BY BirthDate"; }
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PhoneBook;Trusted_Connection=True";
            try
            {
                conn.Open();
                
                SqlDataAdapter adapt = new SqlDataAdapter(command, conn);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
            finally { if (conn != null) { conn.Close(); } }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewAbon newForm = new AddNewAbon();
            newForm.ShowDialog();
            UpdateTable();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SortAbons sortAbon = new SortAbons();
            sortAbon.ShowDialog();
            UpdateTable(sortAbon.rb);
        }
    }
}
