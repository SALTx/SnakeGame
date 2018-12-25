using System.Drawing;

namespace SnakeGame
{
    class Snake
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string shape { get; set; }
        //public Brush headColor { get; set; }

        public Snake()
        {
            X = 0;
            Y = 0;
            shape = "circle";
        }

    }
}
