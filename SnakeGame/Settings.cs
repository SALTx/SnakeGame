

namespace SnakeGame
{
    //Probably wont add diagonals soon
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    };
    //public enum Enemies
    //{ 
    //    Random, //moves randomly
    //    Corner, //tries to corner the snake
    //    Follow, //follows the snake
    //    Ambush //tries to walk in front of the snake
    //}

    public class Settings
    {
        public static int Speed { get; set; }
        public static int Score { get; set; }
        public static int Points { get; set; }
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static bool IsGameOver { get; set; }
        public static bool IsGamePaused { get; set; }
        public static Direction InGameDirection { get; set; }
        //public static Enemies enemeies { get; set; }

        public Settings(string difficulty)
        {

            switch(difficulty)
            {
                case "easy":
                    Speed = 8;
                    Points = 100;
                    break;
                case "medium":
                    Speed = 12;
                    Points = 110;
                    break;
                case "hard":
                    Speed = 16;
                    Points = 120;
                    break;
            }
            Score = 0;
            Width = 16;
            Height = 16;
            IsGameOver = false;
            InGameDirection = Direction.Right;
            //this will be the default direction in which the game starts with
        }

    }
}
