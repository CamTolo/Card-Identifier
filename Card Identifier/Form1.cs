using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card_Identifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void outputBox_Click(object sender, EventArgs e)
        {

        }

        //Lines 29 - 53 displays code to active name of card into the output box
        private void sixOfDiamonds_Click(object sender, EventArgs e)
        {
            outputBox.Text = "Six of Diamonds";
        }
       
        private void twoOfSpades_Click(object sender, EventArgs e)
        {
            outputBox.Text = "Two of Spades";
        }

        private void aceOfHearts_Click(object sender, EventArgs e)
        {
            outputBox.Text = "Ace of Hearts";
        }

        private void joker_Click(object sender, EventArgs e)
        {
            outputBox.Text = "Joker";
        }

        private void kingOfSpades_Click(object sender, EventArgs e)
        {
            outputBox.Text = "King of Spades";
        }

        //this method displays output after exit button is clicked
        private void exit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Designed by: Cameron Tolodziecki");
        }
    }
}
