using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA_W5_ANGEL_L
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form1 form1;

        private void button_add_Click(object sender, EventArgs e)
        {
            if (((Form1)form1).teamlist.Contains(textBox1.Text))
            {
                MessageBox.Show("TIM ALREADY EXIST");

            }
            else
            {
                ((Form1)form1).teamlist.Add(textBox1.Text);
                ((Form1)form1).comboBox_team1.Items.Add(textBox1.Text);
                ((Form1)form1).comboBox_team2.Items.Add(textBox1.Text);
                this.Close();
            }
        }
    }
}
