

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
                    Points = 85;
                    break;
                case "hard":
                    Speed = 16;
                    Points = 50;
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
