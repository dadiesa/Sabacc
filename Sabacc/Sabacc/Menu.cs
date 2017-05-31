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
    public partial class Sabacc : Form
    {
        private int numberOfPlayer;
        public string formName;

        public Sabacc()
        {
            InitializeComponent();
        }
       
        /// <summary>
        /// Récupère le nombre de joueur et lance la partie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartPlay_Click(object sender, EventArgs e)
        {
            //récupère la valeur de la combobox et la convertie en int
            numberOfPlayer = Convert.ToInt32(chooseNumPlayer.Text.ToString());
                     
                PlayersForms PlayersForms = new PlayersForms();
                PlayersForms.Visible = true;
                PlayersForms.Text = "Joueur 1";
                // this.Hide();
            }//end for
        }//end StartPlay
    }

