using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceProject {
    public partial class Form1 : Form {
        readonly Greyhound[] greyhounds = new Greyhound[4];
        readonly Guy[] guys = new Guy[3];
        readonly Random random = new Random();

        public Form1() {
            InitializeComponent();
            InitializeGuys();
            CreatingGreyhounds();
        }

        public void InitializeGuys() {

            guys[0] = new Guy() { Name = "Jan", Cash = 50, MyRadioButton = radioBtn_Jan, MyLabel = lbl_Jan };
            guys[1] = new Guy() { Name = "Adam", Cash = 75, MyRadioButton = radio_Adam, MyLabel = lbl_Adam };
            guys[2] = new Guy() { Name = "Artur", Cash = 5, MyRadioButton = radio_Artur, MyLabel = lbl_Artur };

            foreach (Guy guy in guys) {
                guy.UpdateLabels();
            }

        }

        public void CreatingGreyhounds() {
            for (int i = 0; i < greyhounds.Length; i++) {
                greyhounds[i] = new Greyhound() {
                    StartingPosition = pictureBox1.Left,
                    RacetrackLength = racetrackPictureBox.Width - pictureBox1.Width,
                    MyRandom = random
                };
            }

            greyhounds[0].MyPictureBox = pictureBox1;
            greyhounds[1].MyPictureBox = pictureBox2;
            greyhounds[2].MyPictureBox = pictureBox3;
            greyhounds[3].MyPictureBox = pictureBox4;

        }

        private void Form1_Load(object sender, EventArgs e) {
            lbl_Name.Text = guys[0].Name;
        }

        private void RadioBtn_Jan_CheckedChanged(object sender, EventArgs e) {
            lbl_Name.Text = guys[0].Name;
        }

        private void Radio_Adam_CheckedChanged(object sender, EventArgs e) {
            lbl_Name.Text = guys[1].Name;
        }

        private void Radio_Artur_CheckedChanged(object sender, EventArgs e) {
            lbl_Name.Text = guys[2].Name;
        }

        private void Timer1_Tick(object sender, EventArgs e) {

            int houndIndex = 0;
            foreach (Greyhound greyhound in greyhounds) {

                if (greyhound.Run()) {
                    timer1.Stop();
                    MessageBox.Show("The Winner is chart number: " + (houndIndex + 1));
                    ResetGame();
                    WithdrawCash(houndIndex + 1);
                }

                houndIndex++;
            }

        }

        private void ResetGame() {
            foreach(Greyhound greyhound in greyhounds) {
                greyhound.TakeStartingPosition();
            }
            BetHouse.Enabled = true;
        }

        private void WithdrawCash(int check) {
            foreach (Guy guy in guys) {
                guy.Collect(check);
                guy.ClearBet();
                guy.UpdateLabels();
            }
        }

        private void Btn_Start_Click(object sender, EventArgs e) {
            BetHouse.Enabled = false;
            timer1.Start();
        }

        private void Btn_Bet_Click(object sender, EventArgs e) {

            int BetValue = (int)numeric_BetAmount.Value;
            int ChartNumber = (int)numeric_Charts.Value;

            if (radioBtn_Jan.Checked) {

                guys[0].PlaceBet(BetValue, ChartNumber);

            } else if (radio_Adam.Checked) {

                guys[1].PlaceBet(BetValue, ChartNumber);

            } else if (radio_Artur.Checked) {

                guys[2].PlaceBet(BetValue, ChartNumber);

            }
        }
    }
}
