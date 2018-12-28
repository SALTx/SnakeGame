using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace SnakeGame
{
    class Highscore1
    {
        //new implementation of highscore.cs which just uses a text file instead
        //might finish this after i figure out how to create a relative path (to the executable file)
        public static string path = @"C:\tmp\test.txt";
        //or path = resources1.highscore;
        public static string[] top = { };

        public static StreamReader sr = new StreamReader(path);
        public static StreamWriter sw = new StreamWriter(path);

        public static void getScoresFromFile()
        {
            for(int i = 0; i < 10; i++)
            {
                top[i] = sr.ReadLine();
                top[i].Split('\t');
                
            }
            MessageBox.Show(top[0]);
        }
        public static void getScores(string name)
        {

            string[] top10 = { };
            for (int i = 0; i < 10; i++)
            {
                top10[i] = sr.ReadLine();
            }
            for (int i = 0; i < 10; i++)
            {
                if (top10[i].Contains(name))
                {

                }
            }
        }

        public static void setScores(string name, int score)
        {
            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine(name + "\t" + score);
        }
        //write the top 10 scores
        
        
        

        //read the top 10 scores
        
    }
}
