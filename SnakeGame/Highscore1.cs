using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SnakeGame
{
    class highscore1
    {
        private StreamReader sr = new StreamReader(Resources1.highscore);
        private StreamWriter sw = new StreamWriter(Resources1.highscore);

        private string[] names = { };
        private int[] scores = { };

        public void getData(string playerName)
        {
            if(sr.ReadToEnd().Contains(playerName))
            {

            }
            else
            {
                sw.WriteLine(playerName + "\t" + 0);
            }
        }
    }
}
