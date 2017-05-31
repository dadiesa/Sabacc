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
        int i;

        public int cardValue(int i)
        {
            this.i = i;
            Random random = new Random();
            return (random.Next(-11, 11));
        }//end card

        public void Deck(int valueOfCard,int allCards)
        {
                //Crée le bouton
                this.CardSValue = valueOfCard;
                this.allCards = allCards;
                Button card = new Button();
                card.Font = new Font(card.Font.Name, 20);
                card.Size = new System.Drawing.Size(100,100);

                card.Location = new Point(300, 125);

                PlayersForms.ActiveForm.Controls.Add(card);
                //card.Text = Convert.ToString(CardSValue);
                
                


        }

    }
}
