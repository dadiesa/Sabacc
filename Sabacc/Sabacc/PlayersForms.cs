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
        
        //Variables
        const int numOfCard = 2;
        int numberOfPlayer = 4;
        static int counter = 2;
        int allCards = 2;
        int ValueOfCard;
        int dice;

        public Button[] buttons = new Button[numOfCard];

        //Création bouttons
        createCards carteValue = new createCards();

        

        public PlayersForms()
        {
            InitializeComponent();

                
            for (int i = 0; i < buttons.Length; i++)
            {
                /*ValueOfCard =*/ carteValue.cardValue(i);
               

                Button card = new Button();
                card.Size = new System.Drawing.Size(100, 100);
                card.Tag = carteValue.cardValue(i);
                card.Font = new Font(card.Font.Name,20);

                if (i == 1)
                {
                    card.Location = new Point(20, 125);
                }
                else
                {
                    card.Location = new Point(120, 125);
                }

                Controls.Add(card);
                card.Text = Convert.ToString(carteValue.cardValue(i));
            }//end for

            
        }


        /// <summary>
        /// Lance le dé
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Dice_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            dice = random.Next(1, 6);

            int returnValue = RandomNumber(1, 6);

            Dice.Text = Convert.ToString(returnValue);
        }

        /// <summary>
        /// Création d'un dé
        /// </summary>
        /// <param name="min">Valeur minimume du dé</param>
        /// <param name="max">Valeur max du dé</param>
        /// <returns></returns>
        private int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        private void deck_Click(object sender, EventArgs e)
        {
            ValueOfCard = carteValue.cardValue(1);

            carteValue.Deck(ValueOfCard,allCards);

            allCards++;
            //Désactive le bouton de pioche et active celui de la main
            deck.Enabled = false;
            showHand.Enabled = true;            
        }

        /// <summary>
        /// Passe au joueur suivant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextPlayer_Click(object sender, EventArgs e,int numberOfPlayer)
        {
            PlayersForms.ActiveForm.Hide();

            this.numberOfPlayer = numberOfPlayer;
            
            //Crée des forms pour le nombre de joueur
            for (int i = 0; i <= numberOfPlayer; i++)
            {
                PlayersForms PlayersForms = new PlayersForms();

                if (i == 1)
                {
                    PlayersForms.Visible = true;
                    PlayersForms.Text = Convert.ToString(i);
                }
                else
                {
                    PlayersForms.Visible = false;
                }
                // this.Hide();
            }//end for
        }

        private void nextPlayer_Click(object sender, EventArgs e)
        {
            PlayersForms.ActiveForm.Hide();

            if (counter < numberOfPlayer)
            {



                //Crée des forms pour le nombre de joueur
                for (int i = 0; i == 0; i++)
                {
                    PlayersForms PlayersForms = new PlayersForms();

                    PlayersForms.Visible = true;
                    PlayersForms.Text = "Joueur " + Convert.ToString(counter);


                }//end for
            }
            else
            {

            }
            counter++;
        }
    }
}
