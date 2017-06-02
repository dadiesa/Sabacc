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

        public int[,] playerValues = new int[5, 8];



























        //Constante
        const int numOfCard = 1;
        //Variables                
        int dice;
        int allCards = 2;
        int zeroGet = 0;
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

            this.numberOfPlayer = numberOfPlayer;

            //Crée les boutons de base de l'utilisateur    

            //Prend une valeur aléatoire pour la carte
            ValueOfCard = carteValue.cardValue();
            //Crée la carte               
            Button card = new Button();
            card.Size = new System.Drawing.Size(100, 100);
            card.Tag = carteValue.cardValue();
            card.Font = new Font(card.Font.Name, 20);
            //Si c'est la première carte crée elle se place différement
            playerValues[0, 1] = ValueOfCard;
            card.Location = new Point(50, 125);
            card.Text = Convert.ToString(ValueOfCard);
            Controls.Add(card);
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
            if (cardDeck == 7)
            {
                deck.Enabled = false;
            }
            //Peut montrer sa main que à partir de 5 carte
            if (cardDeck > 3)
            {
                showHand.Enabled = true;
            }//end if 

            playerValues[0,cardDeck+1] = ValueOfCard;
                       
        }//end deckClick

        /// <summary>
        /// Passe au joueur suivant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextPlayer_Click(object sender, EventArgs e)
        {
            //Limit le ^nombre de joueur au nombre de joueur choisi
            if (counter <= numberOfPlayer)
            {

                //Crée des forms pour le nombre de joueur
                PlayersForms PlayersForms = new PlayersForms(numberOfPlayer);
                PlayersForms.Visible = true;
                PlayersForms.Text = "Joueur " + Convert.ToString(counter);
                PlayersForms.Tag = counter;
                cardDeck = 0;

            }// end if
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

            int returnValue = RandomNumber(1, 6);
            
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
