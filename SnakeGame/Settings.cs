﻿using System.Drawing;

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
        public static bool enemyEnabled { get; set; }
        public static bool powerupEnabled { get; set; }
        public static double enemySpawnRate { get; set; }
        public static double powerupSpawnRate { get; set; }
        public static Brush headColor { get; set; }
        public static Brush bodyColor { get; set; }
        public static Brush foodColor { get; set; }
        public static string snakeShape { get; set; }
        public static string foodShape { get; set; }
        public static string difficulty { get; set; }

        /*Player Names*/
        public static string player1Name { get; set; }
        public static string player2Name { get; set; }

        public Settings()
        {
            difficulty = "medium";
            Speed = 15;
            Points = 110;
            enemySpawnRate = 0.4;
            powerupSpawnRate = 0.3;
            headColor = Brushes.Orange;
            bodyColor = Brushes.Yellow;
            foodColor = Brushes.Purple;
            snakeShape = "circle";
            foodShape = "circle";
            Score = 0;
            Width = 16;
            Height = 16;
            IsGameOver = false;
            InGameDirection = Direction.Right;
            enemyEnabled = false;
            powerupEnabled = false;
            IsGamePaused = false;
            player1Name = "Player 1";
            player2Name = "Player 2";
        }
        public void resetGame()
        {
            switch (difficulty)
            {
                case "easy":
                    Speed = 12;
                    Points = 100;
                    enemySpawnRate = 0.2;
                    powerupSpawnRate = 0.5;
                    break;
                case "medium":
                    Speed = 15;
                    Points = 110;
                    enemySpawnRate = 0.4;
                    powerupSpawnRate = 0.3;
                    break;
                case "hard":
                    Speed = 20;
                    Points = 120;
                    enemySpawnRate = 0.6;
                    powerupSpawnRate = 0.1;
                    break;
                default:
                    //you shouldnt be able to get here
                    Speed = 30;
                    Points = 250;
                    enemySpawnRate = 0;
                    powerupSpawnRate = 0.5;
                    break;
            }
            Score = 0;
            IsGameOver = false;
            InGameDirection = Direction.Right;
            IsGamePaused = false;
        }

    }
}
