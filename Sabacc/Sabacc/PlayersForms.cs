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

        private int numCard = 2;

        int dice;
        public PlayersForms()
        {
            InitializeComponent();

            
            for (int i = 1; i <= numCard; i++)
            {
                Button card = new Button();
                if (i == 1)
                {
                    card.Location = new Point(20, 125);
                }
                else
                {
                    card.Location = new Point(75 * i, 125);
                }
                card.Width = 100;
                card.Height = 100;
               
                this.Controls.Add(card);
            }
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
    }
}
