using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }
        private Brush brushInterpret(string input)
        {
            input = input.ToLower();
            //self explanatory but it lowers the case all the letters in the input
            input.Replace(" ", string.Empty);
            //removes spaces from input string

            if (input == "red")
                return Brushes.Red;
            else if (input == "orange")
                return Brushes.Orange;
            else if (input == "yellow")
                return Brushes.Yellow;
            else if (input == "green")
                return Brushes.Green;
            else if (input == "blue")
                return Brushes.Blue;
            else if (input == "indigo")
                return Brushes.Indigo;
            else if (input == "violet")
                return Brushes.Violet;
            else if (input == "cyan")
                return Brushes.Cyan;
            else if (input == "magenta")
                return Brushes.Magenta;
            else
                return Brushes.Black;
            //I might shorten this but idk how
        }
            
        private void applyBTN_Click(object sender, EventArgs e)
        {
            Form1.headColor = brushInterpret(headcolorTB.Text);
            Form1.bodyColor = brushInterpret(bodycolorTB.Text);
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
