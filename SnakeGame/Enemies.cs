using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Enemies
    {
        public bool enabled { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int difficulty { get; set; }
        //i still need a way to constrain the enemy to the board


        public void randomMove()
        {
            Random rand = new Random();

            this.X = (rand.Next() > 0.5) ? this.X += 1 : this.X -= 1;
            this.Y = (rand.Next() > 0.5) ? this.X += 1 : this.X -= 1;


        }
    }
}
