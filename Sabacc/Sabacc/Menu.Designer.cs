namespace Sabacc
{
    partial class Sabacc
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.PlayerNum = new System.Windows.Forms.Label();
            this.chooseNumPlayer = new System.Windows.Forms.ComboBox();
            this.StartPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlayerNum
            // 
            this.PlayerNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.PlayerNum.Location = new System.Drawing.Point(134, 37);
            this.PlayerNum.Name = "PlayerNum";
            this.PlayerNum.Size = new System.Drawing.Size(377, 32);
            this.PlayerNum.TabIndex = 0;
            this.PlayerNum.Text = "Combien de joueurs vont participer ?";
            // 
            // chooseNumPlayer
            // 
            this.chooseNumPlayer.BackColor = System.Drawing.SystemColors.Window;
            this.chooseNumPlayer.DisplayMember = "2";
            this.chooseNumPlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chooseNumPlayer.FormattingEnabled = true;
            this.chooseNumPlayer.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5"});
            this.chooseNumPlayer.Location = new System.Drawing.Point(258, 129);
            this.chooseNumPlayer.Name = "chooseNumPlayer";
            this.chooseNumPlayer.Size = new System.Drawing.Size(121, 21);
            this.chooseNumPlayer.TabIndex = 3;
            // 
            // StartPlay
            // 
            this.StartPlay.Location = new System.Drawing.Point(258, 213);
            this.StartPlay.Name = "StartPlay";
            this.StartPlay.Size = new System.Drawing.Size(118, 51);
            this.StartPlay.TabIndex = 4;
            this.StartPlay.Text = "Jouer";
            this.StartPlay.UseVisualStyleBackColor = true;
            this.StartPlay.Click += new System.EventHandler(this.StartPlay_Click);
            // 
            // Sabacc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 325);
            this.Controls.Add(this.StartPlay);
            this.Controls.Add(this.chooseNumPlayer);
            this.Controls.Add(this.PlayerNum);
            this.Name = "Sabacc";
            this.Text = "Sabacc";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label PlayerNum;
        private System.Windows.Forms.ComboBox chooseNumPlayer;
        private System.Windows.Forms.Button StartPlay;
    }
}

