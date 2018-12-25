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
            foreach (System.Reflection.PropertyInfo prop in typeof(Color).GetProperties())
            {
                if (prop.PropertyType.FullName == "System.Drawing.Color")
                {
                    headColorCB.Items.Add(prop.Name);
                    bodyColorCB.Items.Add(prop.Name);
                    foodColorCB.Items.Add(prop.Name);
                }
            }
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
