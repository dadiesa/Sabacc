using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Sabacc
{
    public partial class PlayersForms : Form
    {
        
        static public string[,] playerValues;
        public int[] playerPoints;
        //Constante
        const int numOfCard = 1;
        //Variables
        int time;
        int allCards = 2;
        static int zeroGet = 0;
        static int turn = 0;
        static int i = 0;
        static int playerInGame = 1;
        static int counter = 2;
        static int ValueOfCard;
        static int cardDeck;
        public int numberOfPlayer;

        //Création bouttons
        createCards carteValue = new createCards();

        /// <summary>
        /// Crée les joueurs
        /// </summary>
        /// <param name="numberOfPlayer">nombre de joueurs</param>
        public PlayersForms(int numberOfPlayer)
        {
            InitializeComponent();

            //Démar le compteur qui va changer une valeur aléatoire à un moment donné
            timerChangeValue.Start();
            
            this.choosePlayer.SelectedIndex = 0;
            this.numberOfPlayer = numberOfPlayer; 

            //Prend une valeur aléatoire pour la carte
            ValueOfCard = carteValue.cardValue(zeroGet);

            //Crée un tableau pour stocker les valeurss
            playerValues = new string[5, 9];

            //Crée un tableau pour stocker les points
            playerPoints = new int[5];

            namePlayer.Text = "Joueur 1";
            NumPoint.Text = Convert.ToString(playerPoints[playerInGame - 1]);

        }//end PlayerForm


        /// <summary>
        /// Création d'un dé
        /// </summary>
        /// <param name="min">Valeur minimume du dé</param>
        /// <param name="max">Valeur max du dé</param>
        /// <returns></returns>
        private int RandomNumber(int min, int max)
        {
            //géner un chiffre random
            Random random = new Random();
            return random.Next(min, max);
        }

        /// <summary>
        /// Permet de piocher
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deck_Click(object sender, EventArgs e)
        {
            
            //Si le joueur a piocher toutes les cartes une d'elles est remplacé par une nouvelle valeur
            if (playerValues[playerInGame-1,7] != null )
            {
                //Choisi quel valeur va être changé
                int wichCardChange = RandomNumber(1, 8);
                //Génère une nouvelle valeur
                string newValue = Convert.ToString(RandomNumber(-8, 8));

                if (newValue == "0")
                {
                    newValue = "IDIOT";
                }

                //Sauvegarde la nouvelle valeur et l'affiche dans la bonne case
                switch (wichCardChange)
                {
                    case 0:
                        playerValues[playerInGame-1,0] = Convert.ToString(newValue);
                        card1.Text = newValue;
                        break;
                    case 1:
                        playerValues[playerInGame-1, 1] = Convert.ToString(newValue);
                        card2.Text = newValue;
                        break;
                    case 2:
                        playerValues[playerInGame-1, 2] = Convert.ToString(newValue);
                        card3.Text = newValue;
                        break;
                    case 3:
                        playerValues[playerInGame-1, 3] = Convert.ToString(newValue);
                        card4.Text = newValue;
                        break;
                    case 4:
                        playerValues[playerInGame-1, 4] = Convert.ToString(newValue);
                        card5.Text = newValue;
                        break;
                    case 5:
                        playerValues[playerInGame-1, 5] = Convert.ToString(newValue);
                        card6.Text = newValue;
                        break;
                    case 6:
                        playerValues[playerInGame-1, 6] = Convert.ToString(newValue);
                        card7.Text = newValue;
                        break;
                    case 7:
                        playerValues[playerInGame-1, 7] = Convert.ToString(newValue);
                        card8.Text = newValue;
                        break;
                }//end switch
                showHand.Enabled = true;
            }//end if
            else
            {                                      
                ValueOfCard = carteValue.cardValue(zeroGet);
                //Appel la méthode pour obtenir une valeur
                carteValue.Deck(ValueOfCard,allCards,cardDeck);
                //Compte le nombre de zéro
                if (ValueOfCard == 0)
                {
                    zeroGet++;
                }
                //Si il y a plus de trois zéro pioché alors on ne peut plus ioché de zéro
                if (zeroGet == 3)
                {
                    ValueOfCard = ValueOfCard + cardDeck;
                }
                allCards++;
                //Désactive le bouton de pioche et active celui de la main
                if (cardDeck == 7)
                {
                    deck.Enabled = false;
                }
                //Peut montrer sa main que à partir de 5 carte
                if (cardDeck > 3)
                {
                    showHand.Enabled = true;
                }//end if 
                playerInGame = Convert.ToInt32(choosePlayer.Text.ToString());

                //Place la valeur dans la tableau
                if (ValueOfCard == 0)
                {
                    playerValues[playerInGame - 1, cardDeck] = "IDIOT";
                }
                else
                {
                    playerValues[playerInGame - 1, cardDeck] = Convert.ToString(ValueOfCard);
                }
            
                //affiche la valeur dans la bonne carte
                switch (i)
                {
                    case 0:
                            card1.Text = Convert.ToString(playerValues[playerInGame - 1, 0]);
                        break;
                    case 1:
                            card2.Text = Convert.ToString(playerValues[playerInGame - 1, 1]);
                        break;
                    case 2:
                            card3.Text = Convert.ToString(playerValues[playerInGame - 1, 2]);
                        break;
                    case 3:
                            card4.Text = Convert.ToString(playerValues[playerInGame - 1, 3]);
                        break;
                    case 4:
                            card5.Text = Convert.ToString(playerValues[playerInGame - 1, 4]);
                        break;
                    case 5:
                            card6.Text = Convert.ToString(playerValues[playerInGame - 1, 5]);
                        break;
                    case 6:
                            card7.Text = Convert.ToString(playerValues[playerInGame - 1, 6]);
                        break;
                    case 7:
                            card8.Text = Convert.ToString(playerValues[playerInGame - 1, 7]);
                        break;
                }//end switch
                //Indique le nombre de carte piochées
                cardDeck++;
                i++;
            }//end else
        }//end deckClick

        /// <summary>
        /// Passe au joueur suivant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextPlayer_Click(object sender, EventArgs e)
        {
            this.Hide();

            //Remet les varibles à 0 pour que le joueur suivant puisse piocher
            cardDeck = 0;
            i = 0;
            //Limite le nombre de joueur au nombre de joueur choisi
            if (counter <= numberOfPlayer)
            {
                this.choosePlayer.SelectedIndex = playerInGame++; /*_____________________*/
                diceResult.Text = null;
                DicePtc.Enabled = true;
                deck.Enabled = false;
                showHand.Enabled = false;
            }// end if
            //Recommence le tour
            else
            {
                diceResult.Text = null;
                DicePtc.Enabled = true;
                deck.Enabled = false;
                showHand.Enabled = false;

                this.choosePlayer.SelectedIndex = 0;
                counter = 1;
                playerInGame = 1;
                turn++;
            }//end else

            if(turn == 2)
            {
                showHand.Enabled = true;
            }

            //Remet les valeur du joueur dans les cartes
            card1.Text = playerValues[playerInGame - 1, 0];
            card2.Text = playerValues[playerInGame - 1, 1];
            card3.Text = playerValues[playerInGame - 1, 2];
            card4.Text = playerValues[playerInGame - 1, 3];
            card5.Text = playerValues[playerInGame - 1, 4];
            card6.Text = playerValues[playerInGame - 1, 5];
            card7.Text = playerValues[playerInGame - 1, 6];
            card8.Text = playerValues[playerInGame - 1, 7];


            namePlayer.Text = "Joueur " + playerInGame;
            MessageBox.Show("Au tour de joueur " + playerInGame);
            NumPoint.Text = Convert.ToString(playerPoints[playerInGame-1]);


            titleChooseCard.Visible = false;
            chooseCard.Visible = false;
            enemyCard.Visible = false;
            DicePtc.BackColor = Color.Empty;

            counter++;

            this.Show();

        }//end nextPlayerClick
                       
        /// <summary>
        /// Lance le dé
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DicePtc_Click(object sender, EventArgs e)
        {

            //Génère une valeur de 1 à 6
            Random random = new Random();
            int returnValue = RandomNumber(1, 6);
            
            //affiche le résultat du dé
            diceResult.Text = Convert.ToString(returnValue);
        
            //Si l'utilisateur obtient moins de 4 le joueur peut pioché
            if (returnValue <= 3)
            {
                deck.Enabled = true;
            }
            else
            {
                titleChooseCard.Visible = true;
                chooseCard.Visible = true;
            }
            DicePtc.Enabled = false;
            DicePtc.BackColor = Color.Red;
        }//end Dice_Click

        /// <summary>
        /// Affiche les mains des joueurs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showHand_Click(object sender, EventArgs e)
        {

            Panel panel = new Panel();
            panel.Width = 20;
            panel.Height = 20;
            panel.BackColor = Color.Black;
            for (int y = 0; y < 5; y++)
            {
                for (int z = 0; z < 8; z++)
                {
                    TextBox allHands = new TextBox();
            
                    allHands.Text = playerValues[y, z];
                    allHands.Controls.Add(panel);
                }
            }
            //Result(playerValues);

            recapHands recap = new recapHands(playerValues, numberOfPlayer,playerPoints);
            recap.Visible = true;

            //récupère le nombre de point des joueurs
            playerPoints = recap.SaveWinner(playerPoints);

            showHand.Enabled = false;

        }//end showHand

        /// <summary>
        /// Permet de choisir la carte à visualisé
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chooseCard_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Rend la carte visible
            enemyCard.Visible = true;

            string Value;

            //Vas chercher la valeur(
            if (playerInGame != 1)
            {
                Value = playerValues[playerInGame - 2, Convert.ToInt32(chooseCard.Text.ToString()) - 1];
            }
            else
            {
                Value = playerValues[numberOfPlayer-1, Convert.ToInt32(chooseCard.Text.ToString()) -1];
            }
            //affiche la valeur
            enemyCard.Text = Value;
            chooseCard.Visible = false;
        }


        /// <summary>
        /// Timer pour changer la valeur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerChangeValue_Tick_1(object sender, EventArgs e)
        {
            /*time++;
            if (time > 10)
            {
                //Choisi quel valeur va être changé
                int wichCardChange = RandomNumber(1, 8);
                //jeu de mot de fabian
                int wichCardChangeToo = RandomNumber(1, 5);
                //Génère une nouvelle valeur
                int newValue = RandomNumber(-8, 8);

                //Met le chiffre 
                playerValues[wichCardChange, wichCardChangeToo] = Convert.ToString(newValue);

                time = 0;
                //MessageBox.Show("allHands");
            }*/
                       
        }
    }//end PlayerForm
}
