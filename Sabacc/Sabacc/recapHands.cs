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
        public int[] PlayersPoint = new int[5];
        public recapHands(string[,] recap, int numberOfPlayer, int[] playerPoints)
        {
            InitializeComponent();


            this.PlayersPoint = playerPoints;

            //int[,] PlayersPoint = new int[5, 2];
            int[] HandOfEveryBody = new int[5];            
            int playerTotal = 0;
            int roundWinner = 0;
            int tempWinner = 0;
            tempWinner = HandOfEveryBody[0];
            //Création label
            for (int i = 0; i < numberOfPlayer; i++)
            {
                //PlayersPoint[i] = i;

                playerTotal = 0;
                for (int j = 0; j < 8; j++)
                {
                    Label Carte = new Label();
                    Carte.Size = new System.Drawing.Size(70, 70);
                    Carte.Location = new System.Drawing.Point(i * 86 + 52, j * 86 + 53);
                    this.Controls.Add(Carte);
                    Carte.BackgroundImage = null;
                    Carte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    Carte.Text = recap[i,j];

                    if (recap[i,j] == "IDIOT")
                    {
                        playerTotal = playerTotal + 0;
                    }
                    else
                    {
                        playerTotal = playerTotal + Convert.ToInt32(recap[i, j]);
                    }

                    
                }//end for

                Label comboPlayer = new Label();
                comboPlayer.Size = new System.Drawing.Size(70, 70);
                comboPlayer.Location = new System.Drawing.Point(i * 86 + 52, 735);
                this.Controls.Add(comboPlayer);
                comboPlayer.BackgroundImage = null;
                comboPlayer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;                
                HandOfEveryBody[i] = playerTotal;
                roundWinner = 0;
                

                if (i != 0)
                {
                    //Sélectionne le gagnant de la manche
                    if (HandOfEveryBody[i] > tempWinner && HandOfEveryBody[i] <= 23)
                    {
                        roundWinner = i;
                        tempWinner = HandOfEveryBody[i];
                        comboPlayer.Text = "Total : " + Convert.ToString(playerTotal) + " Vainqueur";
                        PlayersPoint[i] = + 1;                        

                    }
                    else
                    {
                        comboPlayer.Text = "Total : " + Convert.ToString(playerTotal);
                    }
                    
                }//end if
                else
                {
                    tempWinner = HandOfEveryBody[0];
                    comboPlayer.Text = "Total : " + Convert.ToString(HandOfEveryBody[0]);
                }         
            }//end for
        }//end recapHand

        /// <summary>
        /// Retourne le tableau des résultats
        /// </summary>
        /// <param name="playerPoints">tableau actuel des résultats</param>
        /// <returns></returns>
        public int[] SaveWinner(int[] playerPoints)
        {
            

            return PlayersPoint;
        }
    }
}    
