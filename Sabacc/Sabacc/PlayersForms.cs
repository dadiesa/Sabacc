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
    public partial class PlayersForms : Form
    {

        public int[,] playerValues;
        //Constante
        const int numOfCard = 1;
        //Variables                
        int dice;
        int allCards = 2;
        int zeroGet = 0;
        static int i = 0;
        static int playerInGame = 0;
        static int counter = 2;
        static int ValueOfCard;
        static int cardDeck;
        public int numberOfPlayer;
        //Crée un tableau de bouton pour les cartes
        public Button[] card = new Button[numOfCard];

        //Création bouttons
        createCards carteValue = new createCards();

        /// <summary>
        /// Crée les joueurs
        /// </summary>
        /// <param name="numberOfPlayer">nombre de joueurs</param>
        public PlayersForms(int numberOfPlayer)
        {
            InitializeComponent();

            this.choosePlayer.SelectedIndex = 0;
            this.numberOfPlayer = numberOfPlayer; 

            //Prend une valeur aléatoire pour la carte
            ValueOfCard = carteValue.cardValue();

            playerValues = new int[5, 9];
            playerValues[0, 0] = ValueOfCard;
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
            //Indique le nombre de carte piochées
            cardDeck++;
            ValueOfCard = carteValue.cardValue();
            //Appel la méthode pour obtenir une valeur
            carteValue.Deck(ValueOfCard,allCards,cardDeck);
            //Compte le nombre de zéro
            if (ValueOfCard == 0)
            {
                zeroGet++;
            }
            if (zeroGet == 3)
            {
                ValueOfCard = ValueOfCard + cardDeck;
            }
            allCards++;
            //Désactive le bouton de pioche et active celui de la main
            if (cardDeck == 8)
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
            playerValues[playerInGame-1,cardDeck] = ValueOfCard;

            
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
            }
            i++;

        }//end deckClick

        /// <summary>
        /// Passe au joueur suivant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextPlayer_Click(object sender, EventArgs e)
        {
            //Limite le nombre de joueur au nombre de joueur choisi
            if (counter <= numberOfPlayer)
            {
                this.choosePlayer.SelectedIndex = playerInGame++;
                diceResult.Text = null;
                DicePtc.Enabled = true;
                deck.Enabled = true;
                showHand.Enabled = false;

            }// end if
            //Recommence le tour
            else
            {
                this.choosePlayer.SelectedIndex = 0;
                counter = 0;
                playerInGame = 0;
            }

            card1.Text = Convert.ToString(playerValues[playerInGame - 1, 0]);
            card2.Text = Convert.ToString(playerValues[playerInGame - 1, 0]);
            card3.Text = Convert.ToString(playerValues[playerInGame - 1, 0]);
            card4.Text = Convert.ToString(playerValues[playerInGame - 1, 0]);
            card5.Text = Convert.ToString(playerValues[playerInGame - 1, 0]);
            card6.Text = Convert.ToString(playerValues[playerInGame - 1, 0]);
            card7.Text = Convert.ToString(playerValues[playerInGame - 1, 0]);
            card8.Text = Convert.ToString(playerValues[playerInGame - 1, 0]);




            counter++;
            
        }//end nextPlayerClick
                       
        /// <summary>
        /// Lance le dé
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DicePtc_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            dice = random.Next(1, 6);

            int returnValue = RandomNumber(1, 3); ///////////////////////////
            
            diceResult.Text = Convert.ToString(returnValue);
        
            //Si l'utilisateur obtient moins de 4 le joueur peut pioché
            if (returnValue <= 3)
            {
                deck.Enabled = true;
            }
            else if (returnValue < 3)
            {
                //Ne peut montrer sa main que si l'utilisateur à 5 cartes6
                if (allCards > 3)
                {
                    showHand.Enabled = true;
                }
            }
            DicePtc.Enabled = false;
        }

    }//end PlayerForm
}
