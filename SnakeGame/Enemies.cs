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


        public void randomMove()
        {
            double move;

            Random rand = new Random();

            move = rand.Next();
            this.X = (move > 0.5) ? this.X += 1 : this.X -= 1;

            move = rand.Next();
            this.Y = (move > 0.5) ? this.X += 1 : this.X -= 1;
        }

        public void spawnEnemy()
        {
            //TODO
        }
    }
}
