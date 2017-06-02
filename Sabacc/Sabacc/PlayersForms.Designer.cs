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
            this.deck = new System.Windows.Forms.Button();
            this.showHand = new System.Windows.Forms.Button();
            this.Numpoint = new System.Windows.Forms.Label();
            this.nextPlayer = new System.Windows.Forms.Button();
            this.DicePtc = new System.Windows.Forms.PictureBox();
            this.diceResult = new System.Windows.Forms.Label();
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
            // PlayersForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 394);
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
    }
}