using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

 
namespace CaptureTheThief
{
    public partial class MainForm : Form
    {
        

        public MainForm()
        {
            Data.players = new List<PlayerInfo>();
            InitializeComponent();
        }
        private void SeedPlayers()
        {
           

            PlayerInfo player = new PlayerInfo
            {
                Name = "Faris",
                Age = 23,
                gender = GenderEnum.Male,
                backgroundColor = ColorEnum.Blue,
                Id = 1,
                
            };
            Data.players.Add(player);

            player = new PlayerInfo
            {
                Name = "Ahmad",
                Age = 28,
                gender = GenderEnum.Male,
                backgroundColor = ColorEnum.Green,
                Id = 2,
                
            };
            Data.players.Add(player);
            player = new PlayerInfo
            {
                Name = "Computer",
                Age = 0,
                gender = GenderEnum.Female,
                backgroundColor = ColorEnum.Yellow,
                Id = 3,
                
            };
            Data.players.Add(player);

            player = new PlayerInfo
            {
                Name = "Ali",
                Age = 20,
                gender = GenderEnum.Male,
                backgroundColor = ColorEnum.Blue,
                Id = 4,

            };
            Data.players.Add(player);


        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGameForm newGame = new NewGameForm();
            newGame.Show();
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NewProfileForm newProfile = new NewProfileForm();
            newProfile.Show();
            
        }

        private void currentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentForm currentForm = new CurrentForm();
            currentForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SeedPlayers();

        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatisticsForm statistics = new StatisticsForm();
            statistics.Show();
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryForm history = new HistoryForm();
            history.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm help = new HelpForm();
            help.Show();
        }
    }
}