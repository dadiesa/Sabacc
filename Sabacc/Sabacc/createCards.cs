using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sabacc
{
    public class createCards
    {
        int CardSValue;
        int allCards = 2;
        int j;

        /// <summary>
        /// Retourne un chiffre aléatoire pour la valeur de la carte
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public int cardValue()
        {

            Random random = new Random();
            return (random.Next(-8,8));
        }//end card

        /// <summary>
        /// Pioche de carte
        /// </summary>
        /// <param name="valueOfCard">valeur de la carte</param>
        /// <param name="allCards">Nombre de carte</param>
        public int Deck(int valueOfCard,int allCards,int cardDeck)
        {
                //Crée le bouton
                this.j = cardDeck;
                this.CardSValue = valueOfCard;
                this.allCards = allCards;
            
                Button card = new Button();
                card.Font = new Font(card.Font.Name, 20);
                card.Size = new System.Drawing.Size(100, 100);

                card.Location = new Point(120 * j, 125);

               // PlayersForms.ActiveForm.Controls.Add(card);
            if (valueOfCard == 0)
            {
                card.Text = "idiot";
            }
            else
            {
                card.Text = Convert.ToString(CardSValue);
            }
            return CardSValue;
        }

    }
}
