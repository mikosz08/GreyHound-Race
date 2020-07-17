namespace RaceProject {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radioBtn_Jan = new System.Windows.Forms.RadioButton();
            this.lbl_Jan = new System.Windows.Forms.Label();
            this.lbl_Adam = new System.Windows.Forms.Label();
            this.radio_Adam = new System.Windows.Forms.RadioButton();
            this.lbl_Artur = new System.Windows.Forms.Label();
            this.radio_Artur = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.racetrackPictureBox = new System.Windows.Forms.PictureBox();
            this.btn_Start = new System.Windows.Forms.Button();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.btn_Bet = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.numeric_BetAmount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numeric_Charts = new System.Windows.Forms.NumericUpDown();
            this.BetHouse = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racetrackPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_BetAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Charts)).BeginInit();
            this.BetHouse.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioBtn_Jan
            // 
            this.radioBtn_Jan.AutoSize = true;
            this.radioBtn_Jan.Checked = true;
            this.radioBtn_Jan.Location = new System.Drawing.Point(12, 117);
            this.radioBtn_Jan.Name = "radioBtn_Jan";
            this.radioBtn_Jan.Size = new System.Drawing.Size(71, 17);
            this.radioBtn_Jan.TabIndex = 0;
            this.radioBtn_Jan.TabStop = true;
            this.radioBtn_Jan.Text = "radio_Jan";
            this.radioBtn_Jan.UseVisualStyleBackColor = true;
            this.radioBtn_Jan.CheckedChanged += new System.EventHandler(this.RadioBtn_Jan_CheckedChanged);
            // 
            // lbl_Jan
            // 
            this.lbl_Jan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Jan.Location = new System.Drawing.Point(138, 117);
            this.lbl_Jan.Name = "lbl_Jan";
            this.lbl_Jan.Size = new System.Drawing.Size(253, 22);
            this.lbl_Jan.TabIndex = 1;
            this.lbl_Jan.Text = "lbl_Jan";
            // 
            // lbl_Adam
            // 
            this.lbl_Adam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Adam.Location = new System.Drawing.Point(138, 83);
            this.lbl_Adam.Name = "lbl_Adam";
            this.lbl_Adam.Size = new System.Drawing.Size(253, 22);
            this.lbl_Adam.TabIndex = 3;
            this.lbl_Adam.Text = "lbl_Adam";
            // 
            // radio_Adam
            // 
            this.radio_Adam.AutoSize = true;
            this.radio_Adam.Location = new System.Drawing.Point(12, 83);
            this.radio_Adam.Name = "radio_Adam";
            this.radio_Adam.Size = new System.Drawing.Size(81, 17);
            this.radio_Adam.TabIndex = 2;
            this.radio_Adam.Text = "radio_Adam";
            this.radio_Adam.UseVisualStyleBackColor = true;
            this.radio_Adam.CheckedChanged += new System.EventHandler(this.Radio_Adam_CheckedChanged);
            // 
            // lbl_Artur
            // 
            this.lbl_Artur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Artur.Location = new System.Drawing.Point(138, 48);
            this.lbl_Artur.Name = "lbl_Artur";
            this.lbl_Artur.Size = new System.Drawing.Size(253, 22);
            this.lbl_Artur.TabIndex = 5;
            this.lbl_Artur.Text = "lbl_Artur";
            // 
            // radio_Artur
            // 
            this.radio_Artur.AutoSize = true;
            this.radio_Artur.Location = new System.Drawing.Point(11, 48);
            this.radio_Artur.Name = "radio_Artur";
            this.radio_Artur.Size = new System.Drawing.Size(76, 17);
            this.radio_Artur.TabIndex = 4;
            this.radio_Artur.Text = "radio_Artur";
            this.radio_Artur.UseVisualStyleBackColor = true;
            this.radio_Artur.CheckedChanged += new System.EventHandler(this.Radio_Artur_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RaceProject.Properties.Resources.dog;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RaceProject.Properties.Resources.dog;
            this.pictureBox2.Location = new System.Drawing.Point(12, 72);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 122);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(75, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(12, 177);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(75, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // racetrackPictureBox
            // 
            this.racetrackPictureBox.Image = global::RaceProject.Properties.Resources.racetrack;
            this.racetrackPictureBox.Location = new System.Drawing.Point(12, 12);
            this.racetrackPictureBox.Name = "racetrackPictureBox";
            this.racetrackPictureBox.Size = new System.Drawing.Size(600, 200);
            this.racetrackPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.racetrackPictureBox.TabIndex = 10;
            this.racetrackPictureBox.TabStop = false;
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(438, 25);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(162, 133);
            this.btn_Start.TabIndex = 11;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(9, 168);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(33, 13);
            this.lbl_Name.TabIndex = 12;
            this.lbl_Name.Text = "name";
            // 
            // btn_Bet
            // 
            this.btn_Bet.Location = new System.Drawing.Point(48, 164);
            this.btn_Bet.Name = "btn_Bet";
            this.btn_Bet.Size = new System.Drawing.Size(33, 21);
            this.btn_Bet.TabIndex = 13;
            this.btn_Bet.Text = "Bet";
            this.btn_Bet.UseVisualStyleBackColor = true;
            this.btn_Bet.Click += new System.EventHandler(this.Btn_Bet_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // numeric_BetAmount
            // 
            this.numeric_BetAmount.Location = new System.Drawing.Point(89, 165);
            this.numeric_BetAmount.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numeric_BetAmount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numeric_BetAmount.Name = "numeric_BetAmount";
            this.numeric_BetAmount.Size = new System.Drawing.Size(49, 20);
            this.numeric_BetAmount.TabIndex = 14;
            this.numeric_BetAmount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "USD for chart number:";
            // 
            // numeric_Charts
            // 
            this.numeric_Charts.Location = new System.Drawing.Point(263, 166);
            this.numeric_Charts.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numeric_Charts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_Charts.Name = "numeric_Charts";
            this.numeric_Charts.Size = new System.Drawing.Size(49, 20);
            this.numeric_Charts.TabIndex = 16;
            this.numeric_Charts.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BetHouse
            // 
            this.BetHouse.Controls.Add(this.radioBtn_Jan);
            this.BetHouse.Controls.Add(this.lbl_Jan);
            this.BetHouse.Controls.Add(this.radio_Adam);
            this.BetHouse.Controls.Add(this.lbl_Adam);
            this.BetHouse.Controls.Add(this.radio_Artur);
            this.BetHouse.Controls.Add(this.lbl_Artur);
            this.BetHouse.Controls.Add(this.btn_Start);
            this.BetHouse.Controls.Add(this.lbl_Name);
            this.BetHouse.Controls.Add(this.btn_Bet);
            this.BetHouse.Controls.Add(this.numeric_BetAmount);
            this.BetHouse.Controls.Add(this.label1);
            this.BetHouse.Controls.Add(this.numeric_Charts);
            this.BetHouse.Location = new System.Drawing.Point(12, 231);
            this.BetHouse.Name = "BetHouse";
            this.BetHouse.Size = new System.Drawing.Size(610, 192);
            this.BetHouse.TabIndex = 17;
            this.BetHouse.TabStop = false;
            this.BetHouse.Text = "BetHouse";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 435);
            this.Controls.Add(this.BetHouse);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.racetrackPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "RaceSim";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racetrackPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_BetAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Charts)).EndInit();
            this.BetHouse.ResumeLayout(false);
            this.BetHouse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioBtn_Jan;
        private System.Windows.Forms.Label lbl_Jan;
        private System.Windows.Forms.Label lbl_Adam;
        private System.Windows.Forms.RadioButton radio_Adam;
        private System.Windows.Forms.Label lbl_Artur;
        private System.Windows.Forms.RadioButton radio_Artur;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox racetrackPictureBox;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Button btn_Bet;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown numeric_BetAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numeric_Charts;
        private System.Windows.Forms.GroupBox BetHouse;
    }
}

