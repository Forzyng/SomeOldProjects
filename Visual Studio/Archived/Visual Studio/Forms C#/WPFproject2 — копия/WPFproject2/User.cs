using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFproject2
{
    public class User
    {
        public String Login { get; set; }
        public String Password { get; set; }
        public int HighScoreInMinesweeper { get; set; }
        public int HighScoreInFlappy { get; set; }
        public int HighScoreInWords { get; set; }
        public int HighScoreInSnake { get; set; }
        public int HighScoreInMemoria { get; set; }
        public int HighScoreInAlienWar { get; set; }

        public bool OpenedMinesweeper { get; set; }
        public bool OpenedWords { get; set; }
        public bool OpenedFlappy { get; set; }
        public bool OpenedSnake { get; set; }
        public bool OpenedMemoria { get; set; }
        public bool OpenedAlienWar { get; set; }

        public int  Money { get; set; }
        public int TotalClicks { get; set; }
    }
}
