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
        int dice;
        public PlayersForms()
        {
            InitializeComponent();
        }

        private void Dice_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            dice = random.Next(1, 6);

            int returnValue = RandomNumber(1, 6);

            Dice.Text = Convert.ToString(returnValue);
        }

        private int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        } 

        
    }
}
