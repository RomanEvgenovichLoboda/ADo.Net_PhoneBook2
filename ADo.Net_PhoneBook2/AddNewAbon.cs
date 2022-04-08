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
    public partial class AddNewAbon : Form
    {
        public AddNewAbon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "")
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PhoneBook;Trusted_Connection=True";
                try
                {
                    string insert = "INSERT INTO [Telephones2] (Name,SecondName,LastName,BirthDate,TelNumber,Adress,Car,Company)" + "VALUES (@Name, @SecondName, @LastName, @BirthDate, @TelNumber, @Adress, @Car, @Company);";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(insert, conn);
                    cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                    cmd.Parameters.AddWithValue("@SecondName", textBox2.Text);
                    cmd.Parameters.AddWithValue("@LastName", textBox3.Text);
                    cmd.Parameters.AddWithValue("@BirthDate", textBox4.Text);
                    cmd.Parameters.AddWithValue("@TelNumber", textBox5.Text);
                    cmd.Parameters.AddWithValue("@Adress", textBox6.Text);
                    cmd.Parameters.AddWithValue("@Car", textBox7.Text);
                    cmd.Parameters.AddWithValue("@Company", textBox8.Text);
                    cmd.ExecuteNonQuery();
                }
                finally
                {
                    if (conn != null)
                    {
                        conn.Close();
                       // UpdateTable();
                    }
                }
            }
            else MessageBox.Show("Error");
        }
    }
}
