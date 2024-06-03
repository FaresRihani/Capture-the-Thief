using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaptureTheThief
{
    public class Data
    {
        public static int count = 0;
        public static List<GameInfo> AllGames = new List<GameInfo>();
        public static List<PlayerInfo> players;
        public static PlayerInfo CurrentPolice;
        public static PlayerInfo CurrentPolice1;
        public static PlayerInfo CurrentThief;
        public static bool isPoliceComputerMode { get; set; }
        public static bool isPolice1ComputerMode { get; set; }
        public static bool isThiefComputerMode { get; set; }
    }
}
