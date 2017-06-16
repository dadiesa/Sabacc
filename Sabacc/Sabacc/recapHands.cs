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
        static public int[] PlayersPoint = new int[5];

        /// <summary>
        /// Affiche les cartes des joueurs et en déduit le gagnant
        /// </summary>
        /// <param name="recap">Toutes les cartes des joueurs</param>
        /// <param name="numberOfPlayer">nombre de joueur</param>
        /// <param name="playerPoints">Les points des joueurs actuel</param>
        public recapHands(string[,] recap, int numberOfPlayer, int[] playerPoints)
        {
            InitializeComponent();
            
            PlayersPoint = playerPoints;
            
            //Varables
            int[] HandOfEveryBody = new int[5];
            int playerTotal = 0;
            int roundWinner = 0;
            int tempWinner = 0;
            tempWinner = HandOfEveryBody[0];      
            bool haveIdiot = false;
            bool haveTwo = false;
            bool haveThree = false;
            bool winWith23 = false;

            //Création label
            for (int i = 0; i < numberOfPlayer; i++)
            {
                playerTotal = 0;
                for (int j = 0; j < 8; j++)
                {
                    //Crée la case pour affiché les valeur de tous les joueurs
                    Label Carte = new Label(); 
                    Carte.Size = new System.Drawing.Size(70, 70);
                    Carte.Location = new System.Drawing.Point(i * 86 + 52, j * 86 + 53);
                    this.Controls.Add(Carte);
                    Carte.BackgroundImage = null;
                    Carte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    Carte.Text = recap[i, j];

                    //Si le joeur obtient o il est remplaçé par IDIOT
                    if (recap[i, j] == "IDIOT" && haveIdiot == false)
                    {
                        playerTotal = playerTotal + 0;
                        haveIdiot = true;
                        j = 0;
                    }
                    else if (recap[i,j] != "IDIOT")
                    {
                        playerTotal = playerTotal + Convert.ToInt32(recap[i, j]);
                    }
                                        
                    //vérifie si le joueur a un idiot un 2 et un 3
                    switch (recap[i, j])
                    {
                        case "IDIOT":
                            haveIdiot = true;
                            break;
                        case "2":
                            haveTwo = true;
                            break;
                        case "3":
                            haveThree = true;
                            break;
                    }

                }//end for

                //Crée la case pour affiché le total des valeurs
                Label comboPlayer = new Label();
                comboPlayer.Size = new System.Drawing.Size(70, 70);
                comboPlayer.Location = new System.Drawing.Point(i * 86 + 52, 735);
                this.Controls.Add(comboPlayer);
                comboPlayer.BackgroundImage = null;
                comboPlayer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                HandOfEveryBody[i] = playerTotal;
                roundWinner = 0;


                //Si le joueur à un 2 un 3 et un IDIOT
                if (haveIdiot && haveTwo && haveThree)
                {
                    comboPlayer.Text = "Total : " + Convert.ToString(playerTotal) + " Vainqueur par Idiot";
                    roundWinner = i;
                    tempWinner = HandOfEveryBody[i];
                    winWith23 = true;
                }

                //Sélectionne le gagnant de la manche
                else
                {
                    //Si le joueur à le plus grand chiffre et qu'il est en dessous de 23 il gagne la manche
                    if (HandOfEveryBody[i] > tempWinner && HandOfEveryBody[i] <= 23 && HandOfEveryBody[i] > -23 && winWith23 == false)
                    {
                        roundWinner = i;
                        tempWinner = HandOfEveryBody[i];
                        comboPlayer.Text = "Total : " + Convert.ToString(playerTotal) + " Vainqueur";

                        //Ajout un point
                        PlayersPoint[i] = PlayersPoint[i] + 1;

                    }
                    //Sinon on affiche son total
                    else
                    {
                        if (HandOfEveryBody[i] > 23 || HandOfEveryBody[i] < -23)
                        {
                            PlayersPoint[i] = 0;
                        }
                        comboPlayer.Text = "Total : " + Convert.ToString(playerTotal);
                    }
                    //Lors de la dernière boucle on revérifie la case 1
                    if (i + 1 == numberOfPlayer)
                    {
                        //Si la case 1 est plus grande que le plus grande chiffre actuel le joueur 1 gagne la manche 
                        if (tempWinner < HandOfEveryBody[0] && winWith23 == false)
                        {
                            comboPlayer.Text = "Total : " + Convert.ToString(playerTotal) + " Vainqueur";
                        }//end if 1
                    }//end if 2
                }//end else

                haveIdiot = false;
                haveTwo = false;
                haveThree = false;

            }//end for

            //Vide le tableau pour que les joueur recommence le tour
            for(int i = 0; i < numberOfPlayer; i++)
            {
                for(int j = 0;j < 8; j++)
                {
                    recap[i, j] = null;
                }
            }



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
