using System;
using System.Data.SQLite;

namespace SnakeGame
{
    //To store the High Score
    class Highscore
    {
        public static int GetHighScore()
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
                string query = "CREATE TABLE score (Highscore varchar(10))";
                cmd = new SQLiteCommand(query, Conn);
                //open the database
                Conn.Open();
                cmd.ExecuteNonQuery();
                //close the database
                Conn.Close();
                
                cmd = new SQLiteCommand("INSERT INTO score VALUES('0')", Conn);
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
                cmd = new SQLiteCommand("SELECT Highscore FROM score ", Conn);
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
        public static bool SetHighScore(int score)
        {
            int highScore = GetHighScore();
            SQLiteConnection Conn = new SQLiteConnection("Data Source=Highscoredb.sqlite;Version=3;"); ;
            SQLiteCommand cmd;
            //if the current score is greater than or equal to the High Score
            if (highScore <= score)
            {
                cmd = new SQLiteCommand("UPDATE score SET Highscore=" + score.ToString(), Conn);
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
