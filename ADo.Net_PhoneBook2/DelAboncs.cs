using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADo.Net_PhoneBook2
{
    public partial class DelAboncs : Form
    {
        public string lastName = "";
        public DelAboncs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "") { MessageBox.Show("Empty Line"); }
            
            else
            { 
                lastName = textBox1.Text;
                this.Close();
            }
        }
    }
}
