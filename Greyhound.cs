using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceProject {
    public class Greyhound {

        public int StartingPosition;
        public int RacetrackLength;
        public Random MyRandom = new Random();

        public PictureBox MyPictureBox = null;
        public int Location = 12;

        public bool Run() {

            Location += MyRandom.Next(4) + 1;
            if (BonusRoll()) {
                Location += 10;
                Debug.WriteLine("Bonus ROll!");
            }

            MyPictureBox.Left = Location;

            if (Location >= RacetrackLength) {
                return true;
            }

            return false;
        }

        public bool BonusRoll() {
            int roll = MyRandom.Next(100);
            return roll == 50;
        }

        public void TakeStartingPosition() {
            Location = 12;
            MyPictureBox.Left = Location;
        }

    }

}
