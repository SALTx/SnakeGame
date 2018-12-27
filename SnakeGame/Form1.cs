using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace SnakeGame
{
    public partial class Form1 : Form
    {
        /*
         for future reference the pause is implemented really badly
         it starts a new clocktimer called pausetimer and stops gametimer so i can (draw) the spacebar to unpause
         very badly implemented plsfix
        */
        private List<Snake> Snake = new List<Snake>();
        private Snake food = new Snake();
        string deathCause = "You died for some unknown reason";

        //sounds
        System.Media.SoundPlayer crunch = new System.Media.SoundPlayer(Resource1.crunch);
        System.Media.SoundPlayer die = new System.Media.SoundPlayer(Resource1.The_Game_Over_1);

        /*vars for snake*/
        public static Brush headColor = Brushes.DarkOliveGreen;
        public static Brush bodyColor = Brushes.DarkGreen;
        public static Brush foodColor = Brushes.Yellow;

        public static string snakeShape = "square";
        public static string foodShape = "circle";
        public static string difficulty = "easy";

        public static string playerName = "Player 1";


        public Form1()
        {
            InitializeComponent();
            //Default settings
            new Settings(difficulty);

            //for starting the timer and setting the timer interval for tick
            GameTimer.Interval = 1000 / Settings.Speed;
            GameTimer.Tick += UpdateScreen;
            GameTimer.Start();

            //for starting the pause timer when the game is supposed to be paused
            PauseTimer.Interval = 100 / Settings.Speed;
            PauseTimer.Tick += PauseScreen;

            StartGame();

            //i want to play a sound when the game starts

        }
        private void StartGame()
        {
            status_l.Visible = false;

            //Default settings
            new Settings(difficulty);

            Snake.Clear();

            Snake head = new Snake { X = 0, Y = 0 };
            //default start for game
            Snake.Add(head);

            score_l.Text = Settings.Score.ToString();
            CreateFood();
        }
        private void PauseScreen(object sender, EventArgs e)
        {
            if (GameInput.PressedKey(Keys.Space)) {
                GameTimer.Start();
                PauseTimer.Stop();
            }
        }
        private void UpdateScreen(object sender, EventArgs e)
        {
            highscoreLBL.Text = Highscore.GetHighScore().ToString();
            //Check for Game Over
            if (Settings.IsGameOver)
            {
                //Check if Enter is pressed
                if (GameInput.PressedKey(Keys.Enter))
                {
                    StartGame();
                }
            }
            else if (Settings.IsGamePaused)
            {
                //Check if Space is pressed
                if (GameInput.PressedKey(Keys.Space))
                {
                    //
                }
            }
            else
            {
                if ((GameInput.PressedKey(Keys.Right) || (GameInput.PressedKey(Keys.D))) && Settings.InGameDirection != Direction.Left)
                    Settings.InGameDirection = Direction.Right;
                else if ((GameInput.PressedKey(Keys.Left) || (GameInput.PressedKey(Keys.A))) && Settings.InGameDirection != Direction.Right)
                    Settings.InGameDirection = Direction.Left;
                else if ((GameInput.PressedKey(Keys.Up) || (GameInput.PressedKey(Keys.W))) && Settings.InGameDirection != Direction.Down)
                    Settings.InGameDirection = Direction.Up;
                else if ((GameInput.PressedKey(Keys.Down) || (GameInput.PressedKey(Keys.S))) && Settings.InGameDirection != Direction.Up)
                    Settings.InGameDirection = Direction.Down;
                else if (GameInput.PressedKey(Keys.Space))
                    GamePaused();


                MoveSnake();
            }

            canvas.Invalidate();
        }

        private void MoveSnake()
        {
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                //Move the head
                if (i == 0)
                {
                    switch (Settings.InGameDirection)
                    {
                        case Direction.Up:
                            Snake[i].Y--;
                            break;
                        case Direction.Down:
                            Snake[i].Y++;
                            break;
                        case Direction.Right:
                            Snake[i].X++;
                            break;
                        case Direction.Left:
                            Snake[i].X--;
                            break;
                    }

                    //Maximum X ,Y coordinates
                    int MaxX = canvas.Size.Width / Settings.Width;
                    int MaxY = canvas.Size.Height / Settings.Height;

                    //Finding whether there is collision of snake with the screen border
                    if (Snake[i].X >= MaxX || Snake[i].Y >= MaxY || Snake[i].X < 0 || Snake[i].Y < 0)
                    {
                        deathCause = "You touched the wall";
                        die.Play();
                        GameOver();

                    }

                    // snake snake collision
                    for (int k = 1; k < Snake.Count; k++)
                    {
                        if (Snake[i].X == Snake[k].X && Snake[i].Y == Snake[k].Y)
                        {
                            deathCause = "You ate yourself";
                            die.Play();
                            GameOver();
                        }
                    }

                    //eat food
                    if (Snake[0].X == food.X && Snake[0].Y == food.Y)
                    {
                        crunch.Play();
                        EatFood();
                    }
                }

                else
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
        }

        //food spawn on canvas
        private void CreateFood()
        {
            int MaxX = canvas.Size.Width / Settings.Width;
            int MaxY = canvas.Size.Height / Settings.Height;
            Random rand = new Random();
            //pretty similar to javascript math lib

            //creating food object with random coordinates in the canvas
            food = new Snake { X = rand.Next(0, MaxX), Y = rand.Next(0, MaxY) };

        }



        private void GamePaused()
        {
            
            PauseTimer.Start();
            GameTimer.Stop();
        }


        private void GameOver()
        {
            Settings.IsGameOver = true;
        }

        private void EatFood()
        {
            //For adding circle to snake's body on eating the food
            Snake snake = new Snake {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y,
                //testing

                
            };
            Snake.Add(snake);
            //for updating the score
            Settings.Score += Settings.Points;
            score_l.Text = Settings.Score.ToString();

            CreateFood();


        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics draw = e.Graphics;

            if (!Settings.IsGameOver)
            {
                //Draw snake's body 
                for (int i = 0; i < Snake.Count; i++)
                {
                    //TODO: Add image implementation or different rendering methods
                    Brush SnakeColour;

                    
                    if (i == 0)
                        SnakeColour = headColor;        //For snake head
                    else
                        SnakeColour = bodyColor;             //For rest of snake's body

                    //For drawing the snake
                    if (snakeShape == "circle")
                        draw.FillEllipse(SnakeColour, new Rectangle(Snake[i].X * Settings.Width, Snake[i].Y * Settings.Height, Settings.Width, Settings.Height));
                    else if (snakeShape == "square")
                        draw.FillRectangle(SnakeColour, new Rectangle(Snake[i].X * Settings.Width, Snake[i].Y * Settings.Height, Settings.Width, Settings.Height));

                    //TODO: Give the food better design
                    //For drawing the food
                    if (foodShape == "circle")
                    {
                        draw.FillEllipse(foodColor, new Rectangle(food.X * Settings.Width, food.Y * Settings.Height, Settings.Width, Settings.Height));
                    }
                    else if (foodShape == "square")
                        draw.FillRectangle(foodColor, new Rectangle(food.X * Settings.Width, food.Y * Settings.Height, Settings.Width, Settings.Height));
                }
            }

            else
            {
                string message;
                if (Highscore.SetHighScore(Settings.Score) == true)
                {
                    message = "Reached High Score !!\nYour Score is: " + Settings.Score + "\n\nPress ENTER Key to try again";

                }
                else
                {
                    message = deathCause + "\n\nYour Score is: " + Settings.Score + "\n\nPress ENTER to try again";
                }
                status_l.Text = message;
                status_l.Visible = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            GameInput.ChangeState(e.KeyCode, true);
        }
        //i dont think keyUP works
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            GameInput.ChangeState(e.KeyCode, false);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SettingsForm().Show();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
