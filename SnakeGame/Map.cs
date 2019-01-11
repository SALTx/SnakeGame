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
    public partial class Map : Form
    {
        private readonly string[] maps = { "Grass", "Desert" };
        private readonly Bitmap[] images = { Resources1.grassBackground_01, Resources1.sandBackground_01 };
        private int index = 0;

        public Map()
        {
            InitializeComponent();
        }

        private void prevBTN_Click(object sender, EventArgs e)
        {
            index = (index == 0) ? maps.Length - 1 : index - 1;
            previewBox.BackgroundImage = images[index];
        }

        private void nextBTN_Click(object sender, EventArgs e)
        {
            index = (index == maps.Length - 1) ? index = 0 : index + 1;
            previewBox.BackgroundImage = images[index];
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            //TODO
        }
    }
}
