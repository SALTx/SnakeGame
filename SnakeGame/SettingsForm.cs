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
            else if (color == "purple")
                result = Brushes.Purple;
            else
                result = fallback;

            return result;
        }   
        private void applyBTN_Click(object sender, EventArgs e)
        {
            //difficulty radio
            if (easyRadio.Checked)
                Form1.difficulty = "easy";
            else if (mediumRadio.Checked)
                Form1.difficulty = "medium";
            else if (hardRadio.Checked)
                Form1.difficulty = "hard";
            else
                Form1.difficulty = "easy";

            //shapes
            if (snakeShapeCircle.Checked)
                Form1.snakeShape = "circle";
            else if (snakeShapeSquare.Checked)
                Form1.snakeShape = "square";

            if (foodShapeCircle.Checked)
                Form1.foodShape = "circle";
            else if (foodShapeSquare.Checked)
                Form1.foodShape = "square";

            //change color new
            Form1.headColor = changeColor(headColorCB.Text, Form1.headColor);
            Form1.bodyColor = changeColor(bodyColorCB.Text, Form1.bodyColor);
            Form1.foodColor = changeColor(foodColorCB.Text, Form1.foodColor);

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
