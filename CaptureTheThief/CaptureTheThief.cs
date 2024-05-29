using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace CaptureTheThief
{
    public partial class CaptureTheThief : Form
    {
        public GameInfo game = new GameInfo();

        static int GameID = 0;
        bool policeMoveUp, policeMoveRight, policeMoveLeft, policeMoveDown;
        bool thiefMoveUp, thiefMoveRight, thiefMoveLeft, thiefMoveDown;
        
        int totalSeconds = 120, gameDuration = 0;
        int policeScore = 0, thiefScore = 0;
        string winner;
        Color policeColor, thiefColor;
        Random rand = new Random();
        DateTime policeFreezeEndTime ,thiefFreezeEndTime ,policeInvisibleEndTime, thiefInvisibleEndTime, policeFlashEndTime,thiefFlashEndTime,policeSnailEndTime,thiefSnailEndTime;
        bool isPoliceFreezed = false, isThiefFreezed = false, isPoliceInvisible = false, isThiefInvisible = false, isPoliceHitFlash = false, isThiefHitFlash = false, isThiefHitSnail = false, isPoliceHitSnail = false;
        bool isPoliceComputerMode = Data.isPoliceComputerMode, isThiefComputerMode = Data.isThiefComputerMode;
        int sec = 1,location = 0;

        private int policeSpeed = 12, thiefSpeed = 12;
        public CaptureTheThief()
        {
            game.Police = Data.CurrentPolice;
            game.Thief = Data.CurrentThief;
            game.Date = DateTime.Now;
            InitializeComponent();
            policeNameBarResultLbl.Text = game.Police.Name;
            thiefNameResultBarLbl.Text = game.Thief.Name;

            //Police BackColor
            if (game.Police.backgroundColor == ColorEnum.Blue)
            {
                policeColor = Color.FromArgb(200, 0, 16, 130);
            }
            else if (game.Police.backgroundColor == ColorEnum.Green)
            {
                policeColor = Color.FromArgb(200, 33, 102, 0);
            }
            else
            {
                policeColor = Color.FromArgb(200, 223, 218, 0);
            }
            policeBarPanel.BackColor = Color.FromArgb(200, policeColor);
            
            //Thief BackColor
            if (game.Thief.backgroundColor == ColorEnum.Blue)
            {
                thiefColor = Color.FromArgb(200,0,16,130);
            }
            else if (game.Thief.backgroundColor == ColorEnum.Green)
            {
                thiefColor = Color.FromArgb(200, 33, 102, 0);
            }
            else
            {
                thiefColor = Color.FromArgb(200, 223, 218, 0);
            }
            thiefBarPanel.BackColor = Color.FromArgb(200, thiefColor);

            resetGame();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void policeCarPbx_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void thiefBarPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void policeNameBarLbl_Click(object sender, EventArgs e)
        {

        }

        private void gameOverPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CaptureTheThief_Load(object sender, EventArgs e)
        { 
            policePbx.BackColor = Color.FromArgb(200, 51, 55, 67);
            thiefPbx.BackColor = Color.FromArgb(200, 51, 55, 67);
            freezePbx.BackColor = Color.FromArgb(200, 51, 55, 67);
            invisiblePbx.BackColor = Color.FromArgb(200, 51, 55, 67);
            snailPbx.BackColor = Color.FromArgb(200, 51, 55, 67);
            flashPbx.BackColor = Color.FromArgb(200, 51, 55, 67);
            gameOverPanel.BackColor = Color.FromArgb(200, 51, 55, 67);

            policePbx.BackgroundImage = Properties.Resources.police_right;
            thiefPbx.BackgroundImage = Properties.Resources.thief_right;

            if (Data.count == 0)
            {
                gameMapPbx.Image = imageList1.Images[0];
            }
            else if (Data.count == 1)
            {
                gameMapPbx.Image = imageList1.Images[1];
            }
            else
            {
                gameMapPbx.Image = imageList1.Images[2];
            }

            flashPbx.Location = new Point(275, 10);
            snailPbx.Location = new Point(275, 10);
            freezePbx.Location = new Point(275, 10);
            invisiblePbx.Location = new Point(275, 10);

            flashPbx.SendToBack();
            snailPbx.SendToBack();
            freezePbx.SendToBack();
            invisiblePbx.SendToBack();


        }

        private void policeCarPbx_Click_1(object sender, EventArgs e)
        {

        }

        private void mapPbx_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void endToolStripMenuItem_Click(object sender, EventArgs e)
        {
             if (totalSeconds != 0)
            {
                gameOver();
            }

            this.Close();
            Data.count = 0;
        }

        private void timeLeftTimer_Tick(object sender, EventArgs e)
        {
            policeScoreBarResultLbl.Text = policeScore.ToString();
            thiefScoreResultBarLbl.Text = thiefScore.ToString();
            //Timer Logic
            if (totalSeconds > 0)
            {
                gameDuration++;
                totalSeconds--;
                int minutes = totalSeconds / 60;
                int seconds = totalSeconds - (minutes * 60);
                string timeLeftSecondFormat = seconds < 10 ? "0" + seconds.ToString() : seconds.ToString();
                string timeLeftDurationMinutesFormat = minutes < 10 ? "0" + minutes.ToString() : minutes.ToString();
                this.timeLeftResultBarLbl.Text = timeLeftDurationMinutesFormat + ":" + timeLeftSecondFormat;
                
            }
            else
            {
                gameOver();
            }
            
           
            //Thief Score Logic
            if (!policePbx.Bounds.IntersectsWith(thiefPbx.Bounds) && sec == 15)
            {
                thiefScore += 1;
            }
            //...............
            if (sec == 15)
            {
                sec = 0;
            }
            else
            {
                sec++;
            }
            

            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            // for the police picture box : 
            //changes the character direction based on the pressed key 
            // fills the boolian variables with true to make the character move 
            if (isPoliceComputerMode == false)
            {
                if (e.KeyCode == Keys.A)
                {
                    policePbx.BackgroundImage = null;
                    policeMoveLeft = true;
                    policePbx.BackgroundImage = Properties.Resources.police_left;
                }
                if (e.KeyCode == Keys.D)
                {
                    policePbx.BackgroundImage = null;
                    policeMoveRight = true;
                    policePbx.BackgroundImage = Properties.Resources.police_right;
                }
                if (e.KeyCode == Keys.W)
                {
                    policePbx.BackgroundImage = null;
                    policeMoveUp = true;
                    policePbx.BackgroundImage = Properties.Resources.police_up;

                }
                if (e.KeyCode == Keys.S)
                {
                    policePbx.BackgroundImage = null;
                    policeMoveDown = true;
                    policePbx.BackgroundImage = Properties.Resources.police_down;
                }
            }else
            {
                policeComputerPlayer();
            }


            // for the thief picture box : 
            //changes the character direction based on the pressed key 
            // fills the boolian variables with true to make the character move
            if (isThiefComputerMode == false)
            {
                if (e.KeyCode == Keys.Left)
                {
                    thiefPbx.BackgroundImage = null;
                    thiefMoveLeft = true;
                    thiefPbx.BackgroundImage = Properties.Resources.thief_left;
                }
                if (e.KeyCode == Keys.Right)
                {
                    thiefPbx.BackgroundImage = null;
                    thiefMoveRight = true;
                    thiefPbx.BackgroundImage = Properties.Resources.thief_right;
                }
                if (e.KeyCode == Keys.Up)
                {
                    thiefPbx.BackgroundImage = null;
                    thiefMoveUp = true;
                    thiefPbx.BackgroundImage = Properties.Resources.thief_up;
                }
                if (e.KeyCode == Keys.Down)
                {
                    thiefPbx.BackgroundImage = null;
                    thiefMoveDown = true;
                    thiefPbx.BackgroundImage = Properties.Resources.thief_down;
                }
            }else
            {
                thiefComputerPlayer();
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            // fills the boolian variables with false when the key is unpressed for the police and the thief 

            //the police character 

            if (e.KeyCode == Keys.A)
            {
                policeMoveLeft = false;
            }
            if (e.KeyCode == Keys.D)
            {
                policeMoveRight = false;
            }
            if (e.KeyCode == Keys.W)
            {
                policeMoveUp = false;
            }
            if (e.KeyCode == Keys.S)
            {
                policeMoveDown = false;
            }

            //....................................................................................

            //the thief character 

            if (e.KeyCode == Keys.Left)
            {
                thiefMoveLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                thiefMoveRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                thiefMoveUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                thiefMoveDown = false;
            }
        }

        private void policeComputerPlayer()
        {
            if (policePbx.Left < thiefPbx.Left)
            {
                policePbx.BackgroundImage = null; policeMoveRight = true;
                policePbx.BackgroundImage = Properties.Resources.police_right;
                policePbx.Left += policeSpeed;
            }
            if (policePbx.Left > thiefPbx.Left)
            {
                policePbx.BackgroundImage = null; policeMoveLeft = true;
                policePbx.BackgroundImage = Properties.Resources.police_left;
                policePbx.Left -= policeSpeed;
            }
            if (policePbx.Top < thiefPbx.Top)
            {
                policePbx.BackgroundImage = null;
                policeMoveDown = true;
                policePbx.BackgroundImage = Properties.Resources.police_down;
                policePbx.Top += policeSpeed;
            }
            if (policePbx.Top > thiefPbx.Top)
            {
                policePbx.BackgroundImage = null; policeMoveUp = true;
                policePbx.BackgroundImage = Properties.Resources.police_up;
                policePbx.Top -= policeSpeed;
            }
        }

        private void thiefComputerPlayer()
        {
            if (policePbx.Left < thiefPbx.Left )
            {
                thiefPbx.BackgroundImage = null;
                thiefMoveLeft = true;
                thiefPbx.BackgroundImage = Properties.Resources.thief_left;
                thiefPbx.Left += thiefSpeed;
            }
            if (policePbx.Left > thiefPbx.Left)
            {
                thiefPbx.BackgroundImage = null;
                thiefMoveRight = true;
                thiefPbx.BackgroundImage = Properties.Resources.thief_right;
                thiefPbx.Left -= thiefSpeed;
            }
            if (policePbx.Top < thiefPbx.Top)
            {
                thiefPbx.BackgroundImage = null;
                thiefMoveUp = true;
                thiefPbx.BackgroundImage = Properties.Resources.thief_up;
                thiefPbx.Top += thiefSpeed;
            }
            if (policePbx.Top > thiefPbx.Top)
            {
                thiefPbx.BackgroundImage = null;
                thiefMoveDown = true;
                thiefPbx.BackgroundImage = Properties.Resources.thief_down;
                thiefPbx.Top -= thiefSpeed;
            }
        }
        
        private void policeMoveTimerEvent(object sender, EventArgs e)
        {
            //Score for Police
            if (policePbx.Bounds.IntersectsWith(thiefPbx.Bounds))
            {
                policeScore += 1;
                randomLocationsForThiefAndPolice();
                sec = 0;
            }
           

            
            // this code is responsable of making the character move if there is not any intersection 

            GameInfo game = new GameInfo();
           
                if (policePbx.Bounds.IntersectsWith(panel1.Bounds) == false && policePbx.Bounds.IntersectsWith(panel2.Bounds) == false
                 && policePbx.Bounds.IntersectsWith(panel3.Bounds) == false && policePbx.Bounds.IntersectsWith(panel4.Bounds) == false && policePbx.Bounds.IntersectsWith(panel5.Bounds) == false
                 && policePbx.Bounds.IntersectsWith(panel6.Bounds) == false && policePbx.Bounds.IntersectsWith(panel7.Bounds) == false && policePbx.Bounds.IntersectsWith(panel8.Bounds) == false
                 && policePbx.Bounds.IntersectsWith(panel9.Bounds) == false)
                {
                    if (policeMoveLeft == true && policePbx.Left > 24)
                    {
                        policePbx.Left -= policeSpeed;
                    }
                    if (policeMoveRight == true && policePbx.Left < 763)
                    {
                        policePbx.Left += policeSpeed;
                    }
                    if (policeMoveUp == true && policePbx.Top > 90)
                    {
                        policePbx.Top -= policeSpeed;
                    }
                    if (policeMoveDown == true && policePbx.Top < 450)
                    {
                        policePbx.Top += policeSpeed;
                    }
                }


                // for the police 
                // if the police picturebox intersects with the bnounds of panels this code kind of undo the last movement

                else
                {
                    while (policePbx.Bounds.IntersectsWith(panel1.Bounds) == true || policePbx.Bounds.IntersectsWith(panel2.Bounds) == true ||
                           policePbx.Bounds.IntersectsWith(panel3.Bounds) == true || policePbx.Bounds.IntersectsWith(panel4.Bounds) == true || policePbx.Bounds.IntersectsWith(panel5.Bounds) == true ||
                           policePbx.Bounds.IntersectsWith(panel6.Bounds) == true || policePbx.Bounds.IntersectsWith(panel7.Bounds) == true || policePbx.Bounds.IntersectsWith(panel8.Bounds) == true ||
                           policePbx.Bounds.IntersectsWith(panel9.Bounds) == true)
                    {

                        if (policeMoveLeft == true && policePbx.Left > 24)
                        {
                            policePbx.Left += policeSpeed;
                            policeMoveLeft = false;
                            break;


                        }
                        if (policeMoveRight == true && policePbx.Left < 763)
                        {
                            policePbx.Left -= policeSpeed;
                            policeMoveRight = false;
                            break;

                        }
                        if (policeMoveUp == true && policePbx.Top > 90)
                        {
                            policePbx.Top += policeSpeed;
                            policeMoveUp = false;
                            break;

                        }
                        if (policeMoveDown == true && policePbx.Top < 450)
                        {
                            policePbx.Top -= policeSpeed;
                            policeMoveDown = false;
                            break;

                        }
                        break;
                    }
                }
            //Police Flash 
            if (policePbx.Bounds.IntersectsWith(flashPbx.Bounds) && isThiefHitFlash == false)
            {
                flashPbx.Visible = false;
                policeSpeed = 19;
                policeFlashEndTime = DateTime.Now.AddSeconds(2);
                isPoliceHitFlash = true;

            }
            if (DateTime.Now > policeFlashEndTime && isPoliceHitFlash)
            {
                flashPbx.Visible = true;
                policeSpeed = 12;
                isPoliceHitFlash = false;
            }
            //Police snail 
            if (policePbx.Bounds.IntersectsWith(snailPbx.Bounds) && isThiefHitSnail == false)
            {
                snailPbx.Visible = false;
                policeSpeed = 5;
                policeSnailEndTime = DateTime.Now.AddSeconds(2);
                isPoliceHitSnail = true;

            }
            if (DateTime.Now > policeSnailEndTime && isPoliceHitSnail)
            {
                snailPbx.Visible = true;
                policeSpeed = 12;
                isPoliceHitSnail = false;
            }
            //Police Freeze 
            if (policePbx.Bounds.IntersectsWith(freezePbx.Bounds) && isThiefFreezed == false)
            {
                freezePbx.Visible = false;
                policeSpeed = 0;
                policeFreezeEndTime = DateTime.Now.AddSeconds(2);
                isPoliceFreezed = true;

            }
            if (DateTime.Now > policeFreezeEndTime && isPoliceFreezed)
            {
                freezePbx.Visible = true;
                policeSpeed = 12;
                isPoliceFreezed = false;
            }
            //Police Invisible
            if (policePbx.Bounds.IntersectsWith(invisiblePbx.Bounds) && isThiefInvisible == false)
            {
                invisiblePbx.Visible = false;
                policePbx.Visible = false;
                policeInvisibleEndTime = DateTime.Now.AddSeconds(2);
                isPoliceInvisible = true;

            }
            if (DateTime.Now > policeInvisibleEndTime && isPoliceInvisible)
            {
                invisiblePbx.Visible = true;
                policePbx.Visible = true;
                isPoliceInvisible = false;
            }
        }

        private void thiefMoveTimerEvent(object sender, EventArgs e)
        {
           
           
            
            // this code is responsable of making the character move if there is not any intersection 
            if (thiefPbx.Bounds.IntersectsWith(panel1.Bounds) == false && thiefPbx.Bounds.IntersectsWith(panel2.Bounds) == false
             && thiefPbx.Bounds.IntersectsWith(panel3.Bounds) == false && thiefPbx.Bounds.IntersectsWith(panel4.Bounds) == false && thiefPbx.Bounds.IntersectsWith(panel5.Bounds) == false
             && thiefPbx.Bounds.IntersectsWith(panel6.Bounds) == false && thiefPbx.Bounds.IntersectsWith(panel7.Bounds) == false && thiefPbx.Bounds.IntersectsWith(panel8.Bounds) == false
             && thiefPbx.Bounds.IntersectsWith(panel9.Bounds) == false)
            {
                if (thiefMoveLeft == true && thiefPbx.Left > 24)
                {
                    thiefPbx.Left -= thiefSpeed;
                }
                if (thiefMoveRight == true && thiefPbx.Left < 763)
                {
                    thiefPbx.Left += thiefSpeed;
                }
                if (thiefMoveUp == true && thiefPbx.Top > 90)
                {
                    thiefPbx.Top -= thiefSpeed;
                }
                if (thiefMoveDown == true && thiefPbx.Top < 450)
                {
                    thiefPbx.Top += thiefSpeed;
                }
            }


            // for the thief 
            // if the thief picturebox intersects with the bnounds of panels this code kind of undo the last movement
            else
            {
                while (thiefPbx.Bounds.IntersectsWith(panel1.Bounds) == true || thiefPbx.Bounds.IntersectsWith(panel2.Bounds) == true ||
                       thiefPbx.Bounds.IntersectsWith(panel3.Bounds) == true || thiefPbx.Bounds.IntersectsWith(panel4.Bounds) == true || thiefPbx.Bounds.IntersectsWith(panel5.Bounds) == true ||
                       thiefPbx.Bounds.IntersectsWith(panel6.Bounds) == true || thiefPbx.Bounds.IntersectsWith(panel7.Bounds) == true || thiefPbx.Bounds.IntersectsWith(panel8.Bounds) == true ||
                       thiefPbx.Bounds.IntersectsWith(panel9.Bounds) == true)
                {

                    if (thiefMoveLeft == true && thiefPbx.Left > 24)
                    {
                        thiefPbx.Left += thiefSpeed;
                        thiefMoveLeft = false;
                        break;


                    }
                    if (thiefMoveRight == true && thiefPbx.Left < 763)
                    {
                        thiefPbx.Left -= thiefSpeed;
                        thiefMoveRight = false;
                        break;

                    }
                    if (thiefMoveUp == true && thiefPbx.Top > 90)
                    {
                        thiefPbx.Top += thiefSpeed;
                        thiefMoveUp = false;
                        break;

                    }
                    if (thiefMoveDown == true && thiefPbx.Top < 450)
                    {
                        thiefPbx.Top -= thiefSpeed;
                        thiefMoveDown = false;
                        break;

                    }
                    break;
                }
            }
            //Thief Flash 
            if (thiefPbx.Bounds.IntersectsWith(flashPbx.Bounds) && isPoliceHitFlash==false)
            {
                flashPbx.Visible = false;
                thiefSpeed = 19;
                thiefFlashEndTime = DateTime.Now.AddSeconds(2);
                isThiefHitFlash = true;

            }
            if (DateTime.Now > thiefFlashEndTime && isThiefHitFlash)
            {
                flashPbx.Visible = true;
                thiefSpeed = 12;
                isThiefHitFlash = false;
            }
            //Thief snail 
            if (thiefPbx.Bounds.IntersectsWith(snailPbx.Bounds) && isPoliceHitSnail==false)
            {
                snailPbx.Visible = false;
                thiefSpeed = 5;
                thiefSnailEndTime = DateTime.Now.AddSeconds(2);
                isThiefHitSnail = true;

            }
            if (DateTime.Now > thiefSnailEndTime && isThiefHitSnail)
            {
                snailPbx.Visible = true;
                thiefSpeed = 12;
                isThiefHitSnail = false;
            }

            //Thief Freeze
            if (thiefPbx.Bounds.IntersectsWith(freezePbx.Bounds) && isPoliceFreezed==false)
            {
                freezePbx.Visible = false;
                thiefSpeed = 0;
                thiefFreezeEndTime = DateTime.Now.AddSeconds(2);
                isThiefFreezed = true;

            }
            if (DateTime.Now > thiefFreezeEndTime && isThiefFreezed)
            {
                freezePbx.Visible = true;
                thiefSpeed = 12;
                isThiefFreezed = false;
            }
            //Thief Invisible

            if (thiefPbx.Bounds.IntersectsWith(invisiblePbx.Bounds) && isPoliceInvisible==false)
            {
                invisiblePbx.Visible = false;
                thiefPbx.Visible = false;
                thiefInvisibleEndTime = DateTime.Now.AddSeconds(2);
                isThiefInvisible = true;

            }
            if (DateTime.Now > thiefInvisibleEndTime && isThiefInvisible)
            {
                invisiblePbx.Visible = true;
                thiefPbx.Visible = true;
                isThiefInvisible = false;
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void randomLocationsForThiefAndPolice()
        {
            // Police Spawn Randomly
            location = rand.Next(1, 11);
            switch (location)
            {
                case 1:
                    policePbx.Location = new Point(12, 444);
                    break;
                case 2:
                    policePbx.Location = new Point(11, 80);
                    break;
                case 3:
                    policePbx.Location = new Point(11, 272);
                    break;
                case 4:
                    policePbx.Location = new Point(199, 326);
                    break;
                case 5:
                    policePbx.Location = new Point(348, 331);
                    break;
                case 6:
                    policePbx.Location = new Point(348, 446);
                    break;
                case 7:
                    policePbx.Location = new Point(163, 446);
                    break;
                case 8:
                    policePbx.Location = new Point(277, 183);
                    break;
                case 9:
                    policePbx.Location = new Point(201, 119);
                    break;
                case 10:
                    policePbx.Location = new Point(200, 277);
                    break;

            }
            // Thief Spawn Randomly
            switch (location)
            {
                case 1:
                    thiefPbx.Location = new Point(508, 446);
                    break;
                case 2:
                    thiefPbx.Location = new Point(508, 263);
                    break;
                case 3:
                    thiefPbx.Location = new Point(504, 80);
                    break;
                case 4:
                    thiefPbx.Location = new Point(774, 80);
                    break;
                case 5:
                    thiefPbx.Location = new Point(774, 168);
                    break;
                case 6:
                    thiefPbx.Location = new Point(774, 358);
                    break;
                case 7:
                    thiefPbx.Location = new Point(774, 446);
                    break;
                case 8:
                    thiefPbx.Location = new Point(695, 358);
                    break;
                case 9:
                    thiefPbx.Location = new Point(695, 166);
                    break;
                case 10:
                    thiefPbx.Location = new Point(578, 445);
                    break;

            }
        }

        private void mainGameTimer_Tick(object sender, EventArgs e)
        {
            //  Start Level Two
            if (totalSeconds < 80 && totalSeconds > 40)
            {
                startLevelTwo();
            }
            if (totalSeconds <= 40)
            {
                startLevelThree();
            }
        }

        private void resetGame()
        {
            levelsTimer.Start();
            policeTimer.Start();
            ThiefTimer.Start();
            timeLeftTimer.Start();
            
            



            policeScore = 0;
            thiefScore = 0;

            policeScoreBarResultLbl.Text = policeScore.ToString();
            thiefScoreResultBarLbl.Text = thiefScore.ToString();

            randomLocationsForThiefAndPolice();
            
        }

        private void gameOver()
        {
            
            gameOverPanel.Visible = true;
            
            levelsTimer.Stop();
            timeLeftTimer.Stop();
            policeTimer.Stop();
            ThiefTimer.Stop();
            

            
            
           

            GameID = GameID + 1;
            game.ID = GameID;
            game.Duration = gameDuration;
            game.PoliceScore = policeScore;
            game.ThiefScore = thiefScore;
            
            if (policeScore > thiefScore)
            {
                gameOverPanel.BackgroundImage = Properties.Resources.Police_won_removebg_preview;
                winner = game.Police.Name;
            }
            else if (policeScore < thiefScore)
            {
                gameOverPanel.BackgroundImage = Properties.Resources.Thief_Won_removebg_preview;
                winner = game.Thief.Name;
            }
            else
            {
                gameOverPanel.BackgroundImage = Properties.Resources.DRAW_removebg_preview;
                winner = "Draw!";
            }
            game.Winner = winner;
            Data.AllGames.Add(game);


        }
        
        private void randomLocationsForSnailAndFlash()
        {
            //Snail Random Locations
            location = rand.Next(1, 11); 
            switch (location)
            {
                case 1:
                    snailPbx.Location = new Point(508, 434);
                    break;
                case 2:
                    snailPbx.Location = new Point(774, 444);
                    break;
                case 3:
                    snailPbx.Location = new Point(8, 87);
                    break;
                case 4:
                    snailPbx.Location = new Point(12, 444);
                    break;
                case 5:
                    snailPbx.Location = new Point(195, 277);
                    break;
                case 6:
                    snailPbx.Location = new Point(506, 260);
                    break;
                case 7:
                    snailPbx.Location = new Point(638, 214);
                    break;
                case 8:
                    snailPbx.Location = new Point(761, 255);
                    break;
                case 9:
                    snailPbx.Location = new Point(366, 183);
                    break;
                case 10:
                    snailPbx.Location = new Point(328, 78);
                    break;
               
            }
            //Flash Random Locations
            switch (location)
            {
                case 1:
                    flashPbx.Location = new Point(80, 326);
                    break;
                case 2:
                    flashPbx.Location = new Point(336, 333);
                    break;
                case 3:
                    flashPbx.Location = new Point(706, 167);
                    break;
                case 4:
                    flashPbx.Location = new Point(774, 446);
                    break;
                case 5:
                    flashPbx.Location = new Point(29, 244);
                    break;
                case 6:
                    flashPbx.Location = new Point(111, 327);
                    break;
                case 7:
                    flashPbx.Location = new Point(333, 181);
                    break;
                case 8:
                    flashPbx.Location = new Point(38, 78);
                    break;
                case 9:
                    flashPbx.Location = new Point(514, 444);
                    break;
                case 10:
                    flashPbx.Location = new Point(351, 409);
                    break;
            }
        }

        private void randomLocationsForFreezeAndInvisible()
        {
            //Freeze Random Locations
            location = rand.Next(1, 11);
            switch (location)
            {
                case 1:
                    freezePbx.Location = new Point(13, 84);
                    break;
                case 2:
                    freezePbx.Location = new Point(363, 80);
                    break;
                case 3:
                    freezePbx.Location = new Point(763, 80);
                    break;
                case 4:
                    freezePbx.Location = new Point(768, 266);
                    break;
                case 5:
                    freezePbx.Location = new Point(763, 450);
                    break;
                case 6:
                    freezePbx.Location = new Point(381, 450);
                    break;
                case 7:
                    freezePbx.Location = new Point(14, 444);
                    break;
                case 8:
                    freezePbx.Location = new Point(201, 245);
                    break;
                case 9:
                    freezePbx.Location = new Point(497, 266);
                    break;
                case 10:
                    freezePbx.Location = new Point(634, 266);
                    break;

            }
            //Invisible Random Locations
            switch (location)
            {
                case 1:
                    invisiblePbx.Location = new Point(137, 84);
                    break;
                case 2:
                    invisiblePbx.Location = new Point(582, 84);
                    break;
                case 3:
                    invisiblePbx.Location = new Point(632, 450);
                    break;
                case 4:
                    invisiblePbx.Location = new Point(498, 345);
                    break;
                case 5:
                    invisiblePbx.Location = new Point(350, 336);
                    break;
                case 6:
                    invisiblePbx.Location = new Point(350, 187);
                    break;
                case 7:
                    invisiblePbx.Location = new Point(106, 331);
                    break;
                case 8:
                    invisiblePbx.Location = new Point(106, 447);
                    break;
                case 9:
                    invisiblePbx.Location = new Point(18, 377);
                    break;
                case 10:
                    invisiblePbx.Location = new Point(498, 121);
                    break;
            }
        }

        public void startLevelTwo()
        {
            levelResultBarLbl.Text = "2";
           

            flashPbx.Visible = true;
            flashPbx.Enabled = true;
            snailPbx.Visible = true;
            snailPbx.Enabled = true;

            randomLocationsForSnailAndFlash();

            flashPbx.BringToFront();
            snailPbx.BringToFront();
           

        }

        public void startLevelThree()
        {
            levelResultBarLbl.Text = "3";
            
            flashPbx.Visible = true;
            flashPbx.Enabled = true;
            freezePbx.Visible = true;
            freezePbx.Enabled = true;
            invisiblePbx.Visible = true;
            invisiblePbx.Enabled = true;
            snailPbx.Visible = true;
            snailPbx.Enabled = true;

            randomLocationsForSnailAndFlash();
            randomLocationsForFreezeAndInvisible();

            flashPbx.BringToFront();
            snailPbx.BringToFront();
            freezePbx.BringToFront();
            invisiblePbx.BringToFront();
        }
    }
}
