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
            string[] colors = { "Red" , "Orange", "Yellow", "Green", "Blue", "Purple"};
            for(var i = 0; i < colors.Length; i++)
            {
                headColorCB.Items.Add(colors[i]);
                bodyColorCB.Items.Add(colors[i]);
                foodColorCB.Items.Add(colors[i]);
            }
        }
        private Brush changeColor(string color, Brush fallback)
        {
            Brush result;
            if (color == "Red") { result = Brushes.Red; }
            else if (color == "Orange") { result = Brushes.Orange; }
            else if (color == "Yellow") { result = Brushes.Yellow; }
            else if (color == "Green") { result = Brushes.Green; }
            else if (color == "Blue") { result = Brushes.Blue; }
            else if (color == "Purple") { result = Brushes.Purple; }
            else { result = fallback; }

            return result;
        }   
        private void applyBTN_Click(object sender, EventArgs e)
        {
            //difficulty radio
            string defaultDifficulty = Settings.difficulty;
            if (easyRadio.Checked) { Settings.difficulty = "easy"; }
            else if (mediumRadio.Checked) { Settings.difficulty = "medium"; }
            else if (hardRadio.Checked) { Settings.difficulty = "hard"; }
            else { Settings.difficulty = defaultDifficulty; }

            //shapes
            if (snakeShapeCircle.Checked) { Settings.snakeShape = "circle"; }
            else if (snakeShapeSquare.Checked) { Settings.snakeShape = "square"; }

            if (foodShapeCircle.Checked) { Settings.foodShape = "circle"; }
            else if (foodShapeSquare.Checked) { Settings.foodShape = "square"; }

            //change color new
            Settings.headColor = changeColor(headColorCB.Text, Settings.headColor);
            Settings.bodyColor = changeColor(bodyColorCB.Text, Settings.bodyColor);
            Settings.foodColor = changeColor(foodColorCB.Text, Settings.foodColor);

            MessageBox.Show("Changes Applied");
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
