using System;
using System.Data.SQLite;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Windows.Forms;
//just testing something, remove this later

namespace SnakeGame
{
    //To store the High Score
    static class Highscore
    {
        public static int GetHighScore(string name)
        {
            int score = 0;
            SQLiteConnection Conn;
            SQLiteCommand cmd;

            //check whether the database already exist in the target machine
            if (System.IO.File.Exists("Highscoredb.sqlite") == false)
            {

                SQLiteConnection.CreateFile("Highscoredb.sqlite");
                Conn = new SQLiteConnection("Data Source=Highscoredb.sqlite;Version=3;");

                //create a new table
                string query = "CREATE TABLE score (Highscore varchar(10), Name varchar(20))";
                cmd = new SQLiteCommand(query, Conn);
                //open the database
                Conn.Open();
                cmd.ExecuteNonQuery();
                //close the database
                Conn.Close();

                cmd = new SQLiteCommand("INSERT INTO score VALUES('0', \"" + Settings.player1Name + "\")", Conn);
                //open the database
                Conn.Open();
                cmd.ExecuteNonQuery();
                //close conection
                Conn.Close();
                return score;
            }

            else
            {
                Conn = new SQLiteConnection("Data Source=Highscoredb.sqlite;Version=3;");
                cmd = new SQLiteCommand("SELECT Highscore FROM score WHERE Name = \"" + name + "\"", Conn);
                Conn.Open();
                cmd.ExecuteNonQuery();

                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    score = Int32.Parse(reader["Highscore"].ToString());

                }
                return score;
            }

        }
       
        //Checks whether the current score is the new high score or not
        //if the current score is the new High Score then Updates the High Score in database
        public static bool SetHighScore(string name, int score)
        {
            int highScore = GetHighScore(Settings.player1Name);
            SQLiteConnection Conn = new SQLiteConnection("Data Source=Highscoredb.sqlite;Version=3;"); ;
            SQLiteCommand cmd;
            //if the current score is greater than or equal to the High Score
            if (highScore <= score)
            {
                cmd = new SQLiteCommand("UPDATE score SET Highscore=" + score.ToString() + " WHERE Name = \"" + name + "\"", Conn);
                //open the database
                Conn.Open();
                cmd.ExecuteNonQuery();
                //close conection
                Conn.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
