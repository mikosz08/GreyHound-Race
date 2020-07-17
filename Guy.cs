using System.Windows.Forms;

namespace RaceProject {
    public class Guy {

        public string Name;
        public Bet MyBet = new Bet();
        public int Cash;

        public RadioButton MyRadioButton;
        public Label MyLabel;

        public Guy() {
            MyBet.Bettor = this;
        }

        public void UpdateLabels() {
            MyLabel.Text = MyBet.GetDescription();
            MyRadioButton.Text = Name + " have " + Cash + '$';
        }

        public void ClearBet() {
            MyBet.Amount = 0;
            MyBet.Dog = 0;
        }

        public bool PlaceBet(int Amount, int DogToWin) {

            if (Cash >= Amount) {
                MyBet.Amount = Amount;
                MyBet.Dog = DogToWin;
                UpdateLabels();
                return true;
            }

            return false;
        }

        public void Collect(int Winner) {
            Cash += MyBet.PayOut(Winner);
        }
    }
}