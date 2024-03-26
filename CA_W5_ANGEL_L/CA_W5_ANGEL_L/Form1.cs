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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable showhasil = new DataTable();
        public List<string> teamlist = new List<string>();
        Form2 form2 = new Form2();
        private void Form1_Load(object sender, EventArgs e)
        {
            showhasil.Columns.Add("Date");
            showhasil.Columns.Add("Home Team Name");
            showhasil.Columns.Add("Home Score");
            showhasil.Columns.Add("Away Score");
            showhasil.Columns.Add("Away Team Name");
            dataGridView.DataSource = showhasil;

            teamlist.Add("Boston Celtics");
            teamlist.Add("Brooklyn Nets");
            teamlist.Add("New York Knicks");
            teamlist.Add("Philadephia 76ers");
            teamlist.Add("Toronto Raptors");
            teamlist.Add("Chicago Bulls");
            teamlist.Add("Cleveland Cavelier");
            teamlist.Add("Detroit Pistons");
            teamlist.Add("Indiana Paceers");
            teamlist.Add("Milwauke Bucks");
            foreach (string team in teamlist)
            {
                comboBox_team1.Items.Add(team);
                comboBox_team2.Items.Add(team); 
            }
        }

        private void button_addmatch_Click(object sender, EventArgs e)
        {
            showhasil.Rows.Add(dateTimePicker1.Text, comboBox_team1.Text, textBox_score1.Text, textBox_score2.Text, comboBox_team2.Text);
        }
        string teamm = "";
        string teams = "";
        private void comboBox_team1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (teamm != "")
            {
                comboBox_team2.Items.Add(teamm);
            }
            foreach (string team in comboBox_team2.Items)
            {
                if (team == comboBox_team1.SelectedItem.ToString())
                {
                    comboBox_team2.Items.Remove(team);
                    teamm = team;
                    break;
                }
            }

        }

        private void comboBox_team2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (teams != "")
            {
                comboBox_team1.Items.Add(teams);
            }
            foreach (string team in comboBox_team1.Items)
            {
                if (team == comboBox_team2.SelectedItem.ToString())
                {
                    comboBox_team1.Items.Remove(team);
                    teams = team;
                    break;
                }
            }
        }

        private void textBox_score1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox_score2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button_addteam_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.form1 = this;
            form2.ShowDialog();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            int row = dataGridView.SelectedCells[0].RowIndex;
            dataGridView.Rows.RemoveAt(row);
        }
    }
}
