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
    public partial class StatisticsForm : Form
    {
        int scoreOneMax, scoreTwoMax, highestScore;
        int scoreOneMin, scoreTwoMin, lowestScore;

        int minimumDuration, maximumDuration, totalDuration;
        string ValidationMessage = "Not Applicable";

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGameForm newGameForm = new NewGameForm();

            newGameForm.Show();
            this.Close();
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
            this.Close();
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryForm historyForm = new HistoryForm();
            historyForm.Show();
            this.Close();
        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void historyToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            HistoryForm history = new HistoryForm();
            history.Show();
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

        private void StatisticsForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void realMaximumDurationLbl_Click(object sender, EventArgs e)
        {

        }

       
        public StatisticsForm()
        {
            InitializeComponent();

            //fill number of Profiles
            realNumberOfProfilesLbl.Text = Data.players.Count.ToString();
            if (Data.AllGames.Count > 0)
            {
                realNumberOfGamesLbl.Text = Data.AllGames.Count.ToString();
                //get the highest Score
                scoreOneMax = Data.AllGames.Max(x => x.PoliceScore);
                scoreTwoMax = Data.AllGames.Max(x => x.ThiefScore);
                if (scoreOneMax > scoreTwoMax)
                {
                    highestScore = scoreOneMax;
                }
                else
                {
                    highestScore = scoreTwoMax;
                }
                realHighestScoreLbl.Text = highestScore.ToString();
                //get the Minimum Score
                scoreOneMin = Data.AllGames.Min(x => x.PoliceScore);
                scoreTwoMin = Data.AllGames.Min(x => x.ThiefScore);
                if (scoreOneMin > scoreTwoMin)
                {
                    lowestScore = scoreTwoMin;
                }
                else
                {
                    lowestScore = scoreOneMin;
                }
                realHighestScoreLbl.Text = highestScore.ToString();
                realLowestScoreLbl.Text = lowestScore.ToString();


                //Minimum Duration

                minimumDuration = Data.AllGames.Min(x => x.Duration);
                int minutesMin = minimumDuration / 60;
                int secondsMin = minimumDuration - (minutesMin * 60);
                string minimumDurationSecondFormat = secondsMin < 10 ? "0" + secondsMin.ToString() : secondsMin.ToString();
                string minimumDurationMinutesFormat = minutesMin < 10 ? "0" + minutesMin.ToString() : minutesMin.ToString();
                this.realMinimumDurationLbl.Text = minimumDurationMinutesFormat + ":" + minimumDurationSecondFormat;


                //maximum Duration
                maximumDuration = Data.AllGames.Max(x => x.Duration);
                int minutesMax = maximumDuration / 60;
                int secondsMax = maximumDuration - (minutesMax * 60);
                string maximumDurationSecondFormat = secondsMax < 10 ? "0" + secondsMax.ToString() : secondsMax.ToString();
                string maximumDurationMinutesFormat = minutesMax < 10 ? "0" + minutesMax.ToString() : minutesMax.ToString();
                this.realMaximumDurationLbl.Text = maximumDurationMinutesFormat + ":" + maximumDurationSecondFormat;

                //Total Duration
                totalDuration = Data.AllGames.Sum(x => x.Duration);
                int minutesTotal = totalDuration / 60;
                int secondsTotal = totalDuration - (minutesTotal * 60);
                string totalDurationSecondFormat = secondsTotal < 10 ? "0" + secondsTotal.ToString() : secondsTotal.ToString();
                string totalDurationMinutesFormat = minutesTotal < 10 ? "0" + minutesTotal.ToString() : minutesTotal.ToString();
                this.realTotalDurationLbl.Text = totalDurationMinutesFormat + ":" + totalDurationSecondFormat;




            }
            else
            {
                realNumberOfGamesLbl.Text = ValidationMessage;
                realHighestScoreLbl.Text = ValidationMessage;
                realLowestScoreLbl.Text = ValidationMessage;
                realMaximumDurationLbl.Text = ValidationMessage;
                realMinimumDurationLbl.Text = ValidationMessage;
                realTotalDurationLbl.Text = ValidationMessage;
            }



        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
