using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Powerup
    {
        public bool enabled { get; set; }
        public double spawnChance { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public void getPoints()
        {
            Settings.Score += 500;
        }
        public void getShort()
        {

        }
        /*
         Ideas for powerups
         1. extra points
         2. ghost - become immune to eating yourself for <duration>
         3. walls - allows you to go through the wall and teleport to the opposite side/ stops the snake
         4. food - spawns extra food
         */
    }
}
