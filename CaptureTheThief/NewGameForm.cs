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
    public partial class NewGameForm : Form
    {
        
        public List<PlayerInfo> DataSourcePolice;
        public List<PlayerInfo> DataSourcePolice1;
        public List<PlayerInfo> DataSourceThief;

        public NewGameForm()
        {

            DataSourcePolice = new List<PlayerInfo>();
            DataSourcePolice = Data.players.ToList();
            DataSourcePolice1 = new List<PlayerInfo>();
            DataSourcePolice1 = Data.players.ToList();
            DataSourceThief = new List<PlayerInfo>();
            DataSourceThief = Data.players.ToList();
            InitializeComponent();


            policeComb.DataSource = DataSourcePolice;

            policeComb.DisplayMember = "Name";
            policeComb.ValueMember = "Id";

            police1Comb.DataSource = DataSourcePolice1;

            police1Comb.DisplayMember = "Name";
            police1Comb.ValueMember = "Id";
            police1Comb.SelectedIndex = 3;


            thiefComb.DataSource = DataSourceThief;

            thiefComb.DisplayMember = "Name";
            thiefComb.ValueMember = "Id";
            thiefComb.SelectedIndex = 1;

            

        }
       
        private void NewGameForm_Load(object sender, EventArgs e)
        {
            mapNameLbl.TextAlign = ContentAlignment.MiddleCenter;
            mapNameLbl.Text = "  The Dessert";
            mapsPbx.Image = mapImageList.Images[0];
        }
       

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
            NewProfileForm newProfile = new NewProfileForm();
            newProfile.Show();
            this.Close();
        }

        private void playerPbx_Click(object sender, EventArgs e)
        {

        }
        private void nextBtn_Click_1(object sender, EventArgs e)
        {
           
        }
        private void policeLbl_Click(object sender, EventArgs e)
        {

        }
        private void mapNameLbl_Click(object sender, EventArgs e)
        {
           
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void policeComb_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        private void thiefComb_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (policeComb.SelectedValue.ToString() == thiefComb.SelectedValue.ToString() || police1Comb.SelectedValue.ToString() == thiefComb.SelectedValue.ToString() || policeComb.SelectedValue.ToString() == police1Comb.SelectedValue.ToString())
            {
                MessageBox.Show("Validation Error :Please Select Diffrent Profiles  ", " Player Profile", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                int policeID,police1ID, thiefID;
                policeID = int.Parse(policeComb.SelectedValue.ToString());
                Data.CurrentPolice = Data.players.FirstOrDefault(x => x.Id == policeID);

                police1ID = int.Parse(police1Comb.SelectedValue.ToString());
                Data.CurrentPolice1 = Data.players.FirstOrDefault(x => x.Id == police1ID);

                thiefID = int.Parse(thiefComb.SelectedValue.ToString());
                Data.CurrentThief = Data.players.FirstOrDefault(x => x.Id == thiefID);

                CaptureTheThief captureTheThief = new CaptureTheThief();
                captureTheThief.Show();
                this.Hide();
            }
            //Police Rbtn Checked
            GameInfo gameInfo = new GameInfo();
            if (policeComputerRbtn.Checked == true)
            {

                
                gameInfo.isPoliceComputerMode = true;
                Data.isPoliceComputerMode = true;
            }
            else
            {
                gameInfo.isPoliceComputerMode = false;
                Data.isPoliceComputerMode = false;
            }

            //Police1 Rbtn Checked
            
            if (police1ComputerRbtn.Checked == true)
            {


                gameInfo.isPolice1ComputerMode = true;
                Data.isPolice1ComputerMode = true;
            }
            else
            {
                gameInfo.isPolice1ComputerMode = false;
                Data.isPolice1ComputerMode = false;
            }
            //Thief Rbtn Checked
            if (thiefComputerRbtn.Checked == true)
            {
                gameInfo.isThiefComputerMode = true;
                Data.isThiefComputerMode = true;
            }
            else
            {
                gameInfo.isThiefComputerMode = false;
                Data.isThiefComputerMode = false;
            }

        }

        private void policeComb_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatisticsForm statistics = new StatisticsForm();
            statistics.Show();
            this.Close();
        }

        private void currentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentForm currentForm = new CurrentForm();
            currentForm.Show();
            this.Close();
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryForm historyForm = new HistoryForm();
            historyForm.Show();
            this.Close();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();                                                                

            helpForm.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void nextMapBtn_Click(object sender, EventArgs e)
        {

            //shuffling between maps 

            if (Data.count < 2)
            {
                Data.count++;
            }
            else
            {
                Data.count = 0; 
            }

            mapsPbx.Image = mapImageList.Images[Data.count];

            if (Data.count == 0)
            {
                mapNameLbl.Text = "  The Dessert";
            }
            else if (Data.count == 1)
            {
                mapNameLbl.Text = "      Farms";
            }
            else
            {
                mapNameLbl.Text = "The City Night";
            }
        }

        private void policeComputerRbtn_CheckedChanged(object sender, EventArgs e)
        {
            GameInfo game = new GameInfo();
            if (policeComputerRbtn.Checked == true)
            {
                policeComb.Enabled = false;
                policeComb.SelectedIndex = 2;

                
                game.isPoliceComputerMode = true;
                game.isPolice1ComputerMode = false;
                game.isThiefComputerMode = false;
                Data.isPoliceComputerMode = true;
                Data.isPolice1ComputerMode = false;
                Data.isThiefComputerMode = false;
            }
            else
            {
                
                policeComb.SelectedIndex = 0;
                policeComb.Enabled = true;

                game.isPoliceComputerMode = false;
                game.isPolice1ComputerMode = false;
                game.isThiefComputerMode = true;

                Data.isPoliceComputerMode = false;
                Data.isPolice1ComputerMode = false;
                Data.isThiefComputerMode = true;
            }
        }

        private void police1ComputerRbtn_CheckedChanged(object sender, EventArgs e)
        {
            GameInfo game = new GameInfo();
            if (police1ComputerRbtn.Checked == true)
            {
                police1Comb.Enabled = false;
                police1Comb.SelectedIndex = 2;


                game.isPolice1ComputerMode = true;
                game.isPoliceComputerMode = false;
                game.isThiefComputerMode = false;
                Data.isPolice1ComputerMode = true;
                Data.isPoliceComputerMode = false;
                Data.isThiefComputerMode = false;
            }
            else
            {

                police1Comb.SelectedIndex = 3;
                police1Comb.Enabled = true;

                game.isPolice1ComputerMode = false;
                game.isPoliceComputerMode = false;
                game.isThiefComputerMode = true;

                Data.isPolice1ComputerMode = false;
                Data.isPoliceComputerMode = false;
                Data.isThiefComputerMode = true;
            }
        }

        private void thiefComputerRbtn_CheckedChanged(object sender, EventArgs e)
        {
            GameInfo game = new GameInfo();
            if (thiefComputerRbtn.Checked == true)
            {
                thiefComb.Enabled = false;
                thiefComb.SelectedIndex = 2;

                game.isPoliceComputerMode = false;
                game.isPolice1ComputerMode = false;
                game.isThiefComputerMode = true;
                Data.isPoliceComputerMode = false;
                Data.isPolice1ComputerMode = false;
                Data.isThiefComputerMode = true;
            }
            else
            {
                
                thiefComb.SelectedIndex = 1;
                thiefComb.Enabled = true;

                game.isPoliceComputerMode = true;
                game.isPolice1ComputerMode = false;
                game.isThiefComputerMode = false;

                Data.isPoliceComputerMode = true;
                Data.isPolice1ComputerMode = false;
                Data.isThiefComputerMode = false;
            }

        }

        private void mapNameLbl_Click_1(object sender, EventArgs e)
        {
            
        }

        private void thiefComb_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

       
    }
}
