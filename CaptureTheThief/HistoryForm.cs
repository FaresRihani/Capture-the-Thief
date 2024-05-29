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
    public partial class HistoryForm : Form
    {
        public List<GameInfo> AllGamesList;
        public GameInfo SelectedGame = new GameInfo();
        public HistoryForm()
        {

            AllGamesList = new List<GameInfo>();
            AllGamesList = Data.AllGames.ToList();

            InitializeComponent();

           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGameForm newGameForm = new NewGameForm();

            newGameForm.Show();
            this.Close();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();

            helpForm.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void currentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentForm currentForm = new CurrentForm();
            currentForm.Show();
            this.Close();
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NewProfileForm newProfileForm = new NewProfileForm();

            newProfileForm.Show();
            this.Hide();
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
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PlayBackGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void currentToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CurrentForm current = new CurrentForm();
            current.Show();
            this.Close();
        }

        private void statisticsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            StatisticsForm statistics = new StatisticsForm();
            statistics.Show();
            this.Close();
        }

        private void helpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            HelpForm help = new HelpForm();
            help.Show();
            this.Close();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HistoryDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HistoryForm_Load_1(object sender, EventArgs e)
        {
            DataTable historyTable = new DataTable();
            historyTable.Columns.Add("Date", typeof(string));
            historyTable.Columns.Add("Duration", typeof(string));
            historyTable.Columns.Add("Thief", typeof(string));
            historyTable.Columns.Add("Score1", typeof(string));
            historyTable.Columns.Add("Police", typeof(string));
            historyTable.Columns.Add("Score2", typeof(string));

            int minutes = 0;
            int seconds = 0;
            string DurationSecondFormat = "";
            string DurationMinutesFormat = "";
            foreach (var x in Data.AllGames)
            {
                minutes = x.Duration / 60;
                seconds = x.Duration - (minutes * 60);
                DurationSecondFormat = seconds < 10 ? "0" + seconds.ToString() : seconds.ToString();
                DurationMinutesFormat = minutes < 10 ? "0" + minutes.ToString() : minutes.ToString();

                historyTable.Rows.Add(x.Date.ToString("dd/MM/yyyy"), DurationMinutesFormat + ":" + DurationSecondFormat, x.Thief.Name, x.ThiefScore, x.Police.Name, x.PoliceScore);
            }
            HistoryDataGrid.DataSource = historyTable;

        }
    }
}
