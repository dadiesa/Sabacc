using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sabacc
{
    class createCards
    {       

        private string cardName;

        public void createCard(string cardNames)
        {
            this.cardName = cardNames;

            /*Button cardName = new Button();
            cardName.Name = "i";
            cardName.Location = new Point(50*Convert.ToInt32(cardName), 100);
            cardName.BackColor = Color.Black;
            cardName.Width = 100;
            cardName.Height = 100;*/
            //cardName.Controls.Add(cardName);

           /* int i = 1;
            while (i <= 2)
            {
                Button b = new Button();
                b.Size = new Size(100, 100);
                b.Location = new Point(i * 50, i * 50); // Gaffe à ce qu'il soit différent pour chaque boucle
                                                        // Sinon tes boutons seront superposés
                                                        //b.Click += new EventHandler(methodeAppeleeLorsDuClicSurCeBouton);
                //this.Controls.Add(b);
            }*/


        }//end card

    }
}
