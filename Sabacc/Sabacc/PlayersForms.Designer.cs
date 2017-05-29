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
            this.Dice = new System.Windows.Forms.Button();
            this.deck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Dice
            // 
            this.Dice.Location = new System.Drawing.Point(12, 12);
            this.Dice.Name = "Dice";
            this.Dice.Size = new System.Drawing.Size(63, 59);
            this.Dice.TabIndex = 0;
            this.Dice.Text = "Dice";
            this.Dice.UseVisualStyleBackColor = true;
            this.Dice.Click += new System.EventHandler(this.Dice_Click);
            // 
            // deck
            // 
            this.deck.Enabled = false;
            this.deck.Location = new System.Drawing.Point(65, 293);
            this.deck.Name = "deck";
            this.deck.Size = new System.Drawing.Size(170, 59);
            this.deck.TabIndex = 1;
            this.deck.Text = "Piocher";
            this.deck.UseVisualStyleBackColor = true;
            // 
            // PlayersForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 394);
            this.Controls.Add(this.deck);
            this.Controls.Add(this.Dice);
            this.Name = "PlayersForms";
            this.Text = "PlayersForms";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Dice;
        private System.Windows.Forms.Button deck;
    }
}