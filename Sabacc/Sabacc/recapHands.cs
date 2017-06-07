using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sabacc
{
    public partial class recapHands : Form
    {
        public recapHands(string[,] recap)
        {
            InitializeComponent();


            int playerTotal = 0;

            //Création label
            for (int i = 0; i < 5; i++)
            {
                playerTotal = 0;
                for (int j = 0; j < 8; j++)
                {
                    Label Carte = new Label();
                    //label[i, j] = Carte;
                    Carte.Size = new System.Drawing.Size(50, 50);
                    Carte.Location = new System.Drawing.Point(i * 56 + 22, j * 56 + 23);
                    this.Controls.Add(Carte);
                    Carte.BackgroundImage = null;
                    Carte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;                                    
                    //Carte.BackColor = Color.Black;
                    //Carte.Text = Convert.ToString(i);
                    Carte.Text = recap[i,j];

                    if (recap[i,j] == "IDIOT") {
                        playerTotal = playerTotal + 0;
                    }
                    else
                    {
                        playerTotal = playerTotal + Convert.ToInt32(recap[i, j]);
                    }

                    
                }
                Label comboPlayer = new Label();
                comboPlayer.Size = new System.Drawing.Size(50, 50);
                comboPlayer.Location = new System.Drawing.Point(i * 56 + 22, 470);
                this.Controls.Add(comboPlayer);
                comboPlayer.BackgroundImage = null;
                comboPlayer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                comboPlayer.Text = "Total : " + Convert.ToString(playerTotal);
            }
        }
    }
}    
