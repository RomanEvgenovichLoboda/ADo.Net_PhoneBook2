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
        private void UpdateTable()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PhoneBook;Trusted_Connection=True";
            try
            {
                conn.Open();
                string command = "SELECT * FROM [Telephones2]";
                SqlDataAdapter adapt = new SqlDataAdapter(command, conn);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewAbon newForm = new AddNewAbon();
            newForm.ShowDialog();
        }
    }
}
