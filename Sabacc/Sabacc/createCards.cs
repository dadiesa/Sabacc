using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
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
            
            return CardSValue;
        }

        public void changeValueCard()
        {

        }

        public void seeAdvCard(int playerToSpy,int carteToSpy)
        {
            
        }

    }
}
