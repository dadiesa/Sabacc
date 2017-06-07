namespace Sabacc
{
    partial class PlayersForms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.deck = new System.Windows.Forms.Button();
            this.showHand = new System.Windows.Forms.Button();
            this.Numpoint = new System.Windows.Forms.Label();
            this.nextPlayer = new System.Windows.Forms.Button();
            this.DicePtc = new System.Windows.Forms.PictureBox();
            this.diceResult = new System.Windows.Forms.Label();
            this.choosePlayer = new System.Windows.Forms.ComboBox();
            this.card1 = new System.Windows.Forms.Button();
            this.card2 = new System.Windows.Forms.Button();
            this.card3 = new System.Windows.Forms.Button();
            this.card4 = new System.Windows.Forms.Button();
            this.card5 = new System.Windows.Forms.Button();
            this.card6 = new System.Windows.Forms.Button();
            this.card7 = new System.Windows.Forms.Button();
            this.card8 = new System.Windows.Forms.Button();
            this.timerChangeValue = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DicePtc)).BeginInit();
            this.SuspendLayout();
            // 
            // deck
            // 
            this.deck.Enabled = false;
            this.deck.Location = new System.Drawing.Point(12, 260);
            this.deck.Name = "deck";
            this.deck.Size = new System.Drawing.Size(170, 59);
            this.deck.TabIndex = 1;
            this.deck.Tag = "";
            this.deck.Text = "Piocher";
            this.deck.UseVisualStyleBackColor = true;
            this.deck.Click += new System.EventHandler(this.deck_Click);
            // 
            // showHand
            // 
            this.showHand.Enabled = false;
            this.showHand.Location = new System.Drawing.Point(621, 260);
            this.showHand.Name = "showHand";
            this.showHand.Size = new System.Drawing.Size(170, 59);
            this.showHand.TabIndex = 2;
            this.showHand.Text = "Montrer sa main";
            this.showHand.UseVisualStyleBackColor = true;
            this.showHand.Click += new System.EventHandler(this.showHand_Click);
            // 
            // Numpoint
            // 
            this.Numpoint.AutoSize = true;
            this.Numpoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Numpoint.Location = new System.Drawing.Point(631, 30);
            this.Numpoint.Name = "Numpoint";
            this.Numpoint.Size = new System.Drawing.Size(68, 20);
            this.Numpoint.TabIndex = 6;
            this.Numpoint.Text = "Point(s)";
            // 
            // nextPlayer
            // 
            this.nextPlayer.Location = new System.Drawing.Point(315, 329);
            this.nextPlayer.Name = "nextPlayer";
            this.nextPlayer.Size = new System.Drawing.Size(133, 53);
            this.nextPlayer.TabIndex = 7;
            this.nextPlayer.Text = "Joueur suivant";
            this.nextPlayer.UseVisualStyleBackColor = true;
            this.nextPlayer.Click += new System.EventHandler(this.nextPlayer_Click);
            // 
            // DicePtc
            // 
            this.DicePtc.Image = global::Sabacc.Properties.Resources.de_05;
            this.DicePtc.Location = new System.Drawing.Point(12, 12);
            this.DicePtc.Name = "DicePtc";
            this.DicePtc.Size = new System.Drawing.Size(65, 59);
            this.DicePtc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DicePtc.TabIndex = 8;
            this.DicePtc.TabStop = false;
            this.DicePtc.Click += new System.EventHandler(this.DicePtc_Click);
            // 
            // diceResult
            // 
            this.diceResult.AutoSize = true;
            this.diceResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.diceResult.Location = new System.Drawing.Point(101, 36);
            this.diceResult.Name = "diceResult";
            this.diceResult.Size = new System.Drawing.Size(0, 20);
            this.diceResult.TabIndex = 9;
            // 
            // choosePlayer
            // 
            this.choosePlayer.BackColor = System.Drawing.SystemColors.Window;
            this.choosePlayer.DisplayMember = "2";
            this.choosePlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.choosePlayer.FormattingEnabled = true;
            this.choosePlayer.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.choosePlayer.Location = new System.Drawing.Point(635, 81);
            this.choosePlayer.Name = "choosePlayer";
            this.choosePlayer.Size = new System.Drawing.Size(121, 21);
            this.choosePlayer.TabIndex = 10;
            // 
            // card1
            // 
            this.card1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.card1.Location = new System.Drawing.Point(178, 62);
            this.card1.Name = "card1";
            this.card1.Size = new System.Drawing.Size(66, 94);
            this.card1.TabIndex = 11;
            this.card1.Tag = "";
            this.card1.UseVisualStyleBackColor = true;
            // 
            // card2
            // 
            this.card2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.card2.Location = new System.Drawing.Point(276, 62);
            this.card2.Name = "card2";
            this.card2.Size = new System.Drawing.Size(66, 94);
            this.card2.TabIndex = 12;
            this.card2.Tag = "";
            this.card2.UseVisualStyleBackColor = true;
            // 
            // card3
            // 
            this.card3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.card3.Location = new System.Drawing.Point(372, 62);
            this.card3.Name = "card3";
            this.card3.Size = new System.Drawing.Size(66, 94);
            this.card3.TabIndex = 13;
            this.card3.Tag = "";
            this.card3.UseVisualStyleBackColor = true;
            // 
            // card4
            // 
            this.card4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.card4.Location = new System.Drawing.Point(472, 62);
            this.card4.Name = "card4";
            this.card4.Size = new System.Drawing.Size(66, 94);
            this.card4.TabIndex = 14;
            this.card4.Tag = "";
            this.card4.UseVisualStyleBackColor = true;
            // 
            // card5
            // 
            this.card5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.card5.Location = new System.Drawing.Point(178, 162);
            this.card5.Name = "card5";
            this.card5.Size = new System.Drawing.Size(66, 94);
            this.card5.TabIndex = 15;
            this.card5.Tag = "";
            this.card5.UseVisualStyleBackColor = true;
            // 
            // card6
            // 
            this.card6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.card6.Location = new System.Drawing.Point(276, 162);
            this.card6.Name = "card6";
            this.card6.Size = new System.Drawing.Size(66, 94);
            this.card6.TabIndex = 16;
            this.card6.Tag = "";
            this.card6.UseVisualStyleBackColor = true;
            // 
            // card7
            // 
            this.card7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.card7.Location = new System.Drawing.Point(372, 162);
            this.card7.Name = "card7";
            this.card7.Size = new System.Drawing.Size(66, 94);
            this.card7.TabIndex = 17;
            this.card7.Tag = "";
            this.card7.UseVisualStyleBackColor = true;
            // 
            // card8
            // 
            this.card8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.card8.Location = new System.Drawing.Point(472, 162);
            this.card8.Name = "card8";
            this.card8.Size = new System.Drawing.Size(66, 94);
            this.card8.TabIndex = 18;
            this.card8.Tag = "";
            this.card8.UseVisualStyleBackColor = true;
            // 
            // timerChangeValue
            // 
            this.timerChangeValue.Interval = 1000;
            this.timerChangeValue.Tick += new System.EventHandler(this.timerChangeValue_Tick);
            // 
            // PlayersForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 394);
            this.Controls.Add(this.card8);
            this.Controls.Add(this.card7);
            this.Controls.Add(this.card6);
            this.Controls.Add(this.card5);
            this.Controls.Add(this.card4);
            this.Controls.Add(this.card3);
            this.Controls.Add(this.card2);
            this.Controls.Add(this.card1);
            this.Controls.Add(this.choosePlayer);
            this.Controls.Add(this.diceResult);
            this.Controls.Add(this.DicePtc);
            this.Controls.Add(this.nextPlayer);
            this.Controls.Add(this.Numpoint);
            this.Controls.Add(this.showHand);
            this.Controls.Add(this.deck);
            this.Name = "PlayersForms";
            this.Text = "PlayersForms";
            ((System.ComponentModel.ISupportInitialize)(this.DicePtc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button deck;
        public System.Windows.Forms.Button showHand;
        private System.Windows.Forms.Label Numpoint;
        private System.Windows.Forms.Button nextPlayer;
        private System.Windows.Forms.PictureBox DicePtc;
        private System.Windows.Forms.Label diceResult;
        private System.Windows.Forms.ComboBox choosePlayer;
        public System.Windows.Forms.Button card1;
        public System.Windows.Forms.Button card2;
        public System.Windows.Forms.Button card3;
        public System.Windows.Forms.Button card5;
        public System.Windows.Forms.Button card6;
        public System.Windows.Forms.Button card7;
        public System.Windows.Forms.Button card8;
        public System.Windows.Forms.Button card4;
        private System.Windows.Forms.Timer timerChangeValue;
    }
}