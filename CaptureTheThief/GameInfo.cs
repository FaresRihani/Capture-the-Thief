﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaptureTheThief
{
    public class GameInfo
    {
        public int ID { get; set; }
       
        public PlayerInfo Police { get; set; }
        public PlayerInfo Thief { get; set; }
        public DateTime Date { get; set; }
        public int Duration { get; set; }
        public int PoliceScore { get; set; }
        public int ThiefScore { get; set; }
        public string Winner { get; set; }
        public int Level { get; set; }
        public bool isPoliceComputerMode { get; set; }
        public bool isThiefComputerMode { get; set; }
       

    }
}