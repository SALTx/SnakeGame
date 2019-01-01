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
            //foreach (System.Reflection.PropertyInfo prop in typeof(Color).GetProperties())
            //{
            //    if (prop.PropertyType.FullName == "System.Drawing.Color")
            //    {
            //        headColorCB.Items.Add(prop.Name);
            //        bodyColorCB.Items.Add(prop.Name);
            //        foodColorCB.Items.Add(prop.Name);
            //    }
            //}
            /*This code adds all of the colors to the combo boxes but i am having a hard time turning the
             string values into colors*/
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
            if (color == "Red")
                result = Brushes.Red;
            else if (color == "Orange")
                result = Brushes.Orange;
            else if (color == "Yellow")
                result = Brushes.Yellow;
            else if (color == "Green")
                result = Brushes.Green;
            else if (color == "Blue")
                result = Brushes.Blue;
            else if (color == "Purple")
                result = Brushes.Purple;
            else
                result = fallback;

            return result;
        }   
        private void applyBTN_Click(object sender, EventArgs e)
        {
            //difficulty radio
            string defaultDifficulty = SnakeGame.difficulty;
            if (easyRadio.Checked)
                SnakeGame.difficulty = "easy";
            else if (mediumRadio.Checked)
                SnakeGame.difficulty = "medium";
            else if (hardRadio.Checked)
                SnakeGame.difficulty = "hard";
            else
                SnakeGame.difficulty = defaultDifficulty;

            //shapes
            if (snakeShapeCircle.Checked)
                SnakeGame.snakeShape = "circle";
            else if (snakeShapeSquare.Checked)
                SnakeGame.snakeShape = "square";

            if (foodShapeCircle.Checked)
                SnakeGame.foodShape = "circle";
            else if (foodShapeSquare.Checked)
                SnakeGame.foodShape = "square";

            //change color new
            SnakeGame.headColor = changeColor(headColorCB.Text, SnakeGame.headColor);
            SnakeGame.bodyColor = changeColor(bodyColorCB.Text, SnakeGame.bodyColor);
            SnakeGame.foodColor = changeColor(foodColorCB.Text, SnakeGame.foodColor);

            //change colors
            //TypeConverter tc = new ColorConverter()
            //Form1.headColor= (Brush)tc.ConvertFromString(bodyColorCB.Text);
            //Form1.bodyColor = (Brush)tc.ConvertFromString(bodyColorCB.Text);
            //Form1.foodColor = (Brush)tc.ConvertFromString(foodColorCB.Text);
            MessageBox.Show("Changes Applied");
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
