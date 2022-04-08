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
    public partial class SortAbons : Form
    {
        public int rb = 0;
        public SortAbons()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) { rb = 1; }
            if (radioButton2.Checked) { rb = 2; }
            if (radioButton3.Checked) { rb = 3; }
            if (radioButton4.Checked) { rb = 4; }
            this.Close();
        }
    }
}
