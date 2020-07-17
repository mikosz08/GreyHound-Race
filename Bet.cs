using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceProject {
    public class Bet {

        public int Amount;
        public int Dog;
        public Guy Bettor;
        public int dogToWin;

        public string GetDescription() {

            if (Amount > 0) {
                return Bettor.Name + " bet " + Amount + "$ for dog number: " + Dog;
            }

            return Bettor.Name + " does not bet.";

        }

        public int PayOut(int Winner) {

            if (Dog.Equals(Winner)) {
                return Amount;
            }

            return -Amount;
        }

    }
}
