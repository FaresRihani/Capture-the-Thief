using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaptureTheThief
{
    public partial class CurrentForm : Form
    {
        public CurrentForm()
        {
            InitializeComponent();
            DataTable profilesDataTable = new DataTable();
            profilesDataTable.Columns.Add("ID", typeof(string));
            profilesDataTable.Columns.Add("Name", typeof(string));
            profilesDataTable.Columns.Add("Gender", typeof(string));
            profilesDataTable.Columns.Add("Age", typeof(string));
            profilesDataTable.Columns.Add("Background Color", typeof(string));
            foreach (var player in Data.players)
            {
                profilesDataTable.Rows.Add(player.Id, player.Name, player.gender, player.Age, player.backgroundColor);

            }
            profileGridView.DataSource = profilesDataTable;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGameForm newGameForm = new NewGameForm();

            newGameForm.Show();
            this.Close();
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NewProfileForm newProfileForm = new NewProfileForm();

            newProfileForm.Show();
            this.Close();
        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatisticsForm statistics = new StatisticsForm();
            statistics.Show();
            this.Close();
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryForm historyForm = new HistoryForm();
            historyForm.Show();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void endToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void currentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();

            helpForm.Show();
        }

        private void newToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            NewGameForm newGame = new NewGameForm();
            newGame.Show();
            this.Close();
        }

        private void newToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            NewProfileForm newProfile = new NewProfileForm();
            newProfile.Show();
            this.Close();
        }

        private void statisticsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            StatisticsForm statistics = new StatisticsForm();
            statistics.Show();
            this.Close();
        }

        private void historyToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            HistoryForm historyForm = new HistoryForm();
            historyForm.Show();
            this.Close();
        }

        private void helpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            HelpForm help = new HelpForm();
            help.Show();
            this.Close();
        }

        private void CurrentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
