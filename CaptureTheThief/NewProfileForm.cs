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
    public partial class NewProfileForm : Form
    {
        static int PlayerID = 3;
        
        public NewProfileForm()
        {

            InitializeComponent();

        }

        
        private bool ValidationProfile()
        {
            if (Data.players != null) 
            {
                //check if there is a player with the same name
                if (Data.players.Where(x => x.Name == Nametxt.Text).Count() > 0)
                {
                    MessageBox.Show("Validation Error : This player profile is already exist  ", " Palyer Profile", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
           
            //Check if Player Name is null or empty string
            if (String.IsNullOrEmpty(Nametxt.Text))
            {
                MessageBox.Show("Validation Error : Palyer Name is Required ", " Palyer Profile", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                
            }
            //Check if profile Gender  is null or empty 
            if (MaleRbtn.Checked == false && femaleRbtn.Checked == false)
            {
                MessageBox.Show("Validation Error : Gender is Required ", " Palyer Profile", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                
            }

            //Check if Age is null or empty string
            if (String.IsNullOrEmpty(ageComb.Text))
            {
                MessageBox.Show("Validation Error : Age is Required ", " Palyer Profile", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
               
            }
            
            //Check if profile Background Color  is null or empty 
            if (blueRbtn.Checked == false && greenRbtn.Checked == false && yellowRbtn.Checked == false)
            {
                MessageBox.Show("Validation Error : Background Color is Required ", " Palyer Profile", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                
            }
            if (Nametxt.Text.Length > 20)
            {
                Nametxt.Text = "";
                MessageBox.Show("Validation Error : the maximum length for Name is 20 character ", " Palyer Profile", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
               
            }

            return true;
           
           
        }
        
        private bool SaveProfile()
        {
            if (ValidationProfile())
            {
                try
                {

                    PlayerInfo playerInfo = new PlayerInfo();
                    PlayerID = PlayerID + 1;
                    playerInfo.Id = PlayerID;
                    playerInfo.Name = Nametxt.Text;
                    playerInfo.Age = Convert.ToInt32(ageComb.Text);
                   
                    if (MaleRbtn.Checked)
                    {
                        playerInfo.gender = GenderEnum.Male;
                    }
                    else
                    {
                        playerInfo.gender = GenderEnum.Female;
                    }
                    if (blueRbtn.Checked)
                    {
                        playerInfo.backgroundColor = ColorEnum.Blue;
                    }
                    else if (yellowRbtn.Checked)
                    {
                        playerInfo.backgroundColor = ColorEnum.Yellow;
                    }
                    else
                    {
                        playerInfo.backgroundColor = ColorEnum.Green;
                    }
                    
                    Data.players.Add(playerInfo);
                    MessageBox.Show("Successfully saved", " Palyer Profile", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                   
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex.Message, " Palyer Profile", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }


            }
            return false;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void saveBtn_Click_1(object sender, EventArgs e)
        {
            
            bool saveResult;
            saveResult = SaveProfile();
            

        }

       

        private void yellowRbtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGameForm newGame = new NewGameForm();
            newGame.Show();
            this.Close();
        }

        private void NewProfileForm_Load(object sender, EventArgs e)
        {

        }

        private void endToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void GenderLbl_Click(object sender, EventArgs e)
        {

        }

        private void ImagePbx_Click(object sender, EventArgs e)
        {

        }

        private void MaleRbtn_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
