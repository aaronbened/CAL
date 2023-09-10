using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAL_EXERCISE_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Man seeking man");
            comboBox1.Items.Add("Man seeking woman");
            comboBox1.Items.Add("Woman seeking man");
            comboBox1.Items.Add("Woman seeking woman");
            comboBox1.Items.Add("Not that fussy, really");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string yourName = textBox1.Text;
            string birthDate = dateTimePicker1.Text;
            string prefference = comboBox1.Text;
            MessageBox.Show(yourName + "\n" + birthDate + "\n" + prefference, "Your Application" );
        }
    }
}
