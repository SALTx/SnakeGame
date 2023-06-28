using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class SnakeGame : Form
    {
        private static readonly List<Shape> Snake = new List<Shape>();
        private Shape _food = new Shape();
        private Powerup _powerup = new Powerup { X = -10, Y = -10 };

        private string _deathCause = "You died for some unknown reason";

        private static readonly TextureBrush Test = new TextureBrush(Resources1.test_03);
        private static Image _background = Resources1.grassBackground_01;


        //sounds
        private readonly SoundPlayer _crunch = new SoundPlayer(Resources1.crunch);
        private readonly SoundPlayer _die = new SoundPlayer(Resources1.The_Game_Over_1);
        private readonly SoundPlayer _extraPoints = new SoundPlayer(Resources1.powerup);


        private readonly SettingsForm _settings;
        private readonly ProfileForm _profiles;
        private readonly Map _maps;
        private readonly Settings _setup = new Settings();

        public SnakeGame()
        {
            InitializeComponent();

            _settings = new SettingsForm();
            _profiles = new ProfileForm();
            _maps = new Map();

            //for starting the timer and setting the timer interval for tick
            GameTimer.Interval = 1000 / Settings.Speed;
            GameTimer.Tick += UpdateScreen;
            GameTimer.Start();

            StartGame();

            //i want to play a sound when the game starts
        }

        public void CutSnake()
        {
            var len = Snake.Count;
            if (len > 1)
                Snake.RemoveAt(len - 1);
        }

        public static void ChangeBackground(Image i)
        {
            _background = i;
        }

        private void StartGame()
        {
            status_l.Visible = false;
            playernamelbl.Text = Settings.player1Name;

            //Default settings
            _setup.resetGame();
            Snake.Clear();

            var head = new Shape { X = 0, Y = 0 };
            Snake.Add(head);
            score_l.Text = Settings.Score.ToString();

            CreateFood();
        }

        private void UpdateScreen(object sender, EventArgs e)
        {
            highscoreLBL.Text = Highscore.GetHighScore(Settings.player1Name).ToString();

            //Check for Game Over
            if (Settings.IsGameOver)
            {
                //Check if Enter is pressed
                if (GameInput.PressedKey(Keys.Enter)) StartGame();
            }
            else
            {
                if (GameInput.PressedKey(Keys.Space))
                {
                    Settings.IsGamePaused = !Settings.IsGamePaused;
                    pausedLBL.Visible = !pausedLBL.Visible;
                }

                if (GameInput.PressedKey(Keys.K)) CutSnake();

                if (!Settings.IsGamePaused)
                {
                    if ((GameInput.PressedKey(Keys.Right) || GameInput.PressedKey(Keys.D)) &&
                        Settings.InGameDirection != Direction.Left)
                        Settings.InGameDirection = Direction.Right;
                    else if ((GameInput.PressedKey(Keys.Left) || GameInput.PressedKey(Keys.A)) &&
                             Settings.InGameDirection != Direction.Right)
                        Settings.InGameDirection = Direction.Left;
                    else if ((GameInput.PressedKey(Keys.Up) || GameInput.PressedKey(Keys.W)) &&
                             Settings.InGameDirection != Direction.Down)
                        Settings.InGameDirection = Direction.Up;
                    else if ((GameInput.PressedKey(Keys.Down) || GameInput.PressedKey(Keys.S)) &&
                             Settings.InGameDirection != Direction.Up) Settings.InGameDirection = Direction.Down;
                    MoveSnake(Snake);
                }
            }

            canvas.Invalidate();
        }

        private void MoveSnake(IReadOnlyList<Shape> snake)
        {
            for (var i = Snake.Count - 1; i >= 0; i--)
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
                    var maxX = canvas.Size.Width / Settings.Width;
                    var maxY = canvas.Size.Height / Settings.Height;

                    //Finding whether there is collision of snake with the screen border
                    if (Snake[i].X >= maxX || Snake[i].Y >= maxY || Snake[i].X < 0 || Snake[i].Y < 0)
                    {
                        _deathCause = "You touched the wall";
                        _die.Play();
                        GameOver();
                    }

                    // snake snake collision
                    for (var k = 1; k < Snake.Count; k++)
                    {
                        if (Snake[i].X != Snake[k].X || Snake[i].Y != Snake[k].Y) continue;
                        _deathCause = "You ate yourself";
                        _die.Play();
                        GameOver();
                    }

                    //eat food
                    if (Snake[0].X == _food.X && Snake[0].Y == _food.Y)
                    {
                        _crunch.Play();
                        EatFood();
                    }

                    if (Snake[0].X == _powerup.X && snake[0].Y == _powerup.Y) EatPowerup("extraPoints");
                }
                else
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
        }

        //food spawn on canvas
        private void CreateFood()
        {
            var maxX = canvas.Size.Width / Settings.Width;
            var maxY = canvas.Size.Height / Settings.Height;
            var rand = new Random();

            var x = rand.Next(0, maxX);
            var y = rand.Next(0, maxY);

            _food = new Shape { X = x, Y = y };
        }

        private void CreatePowerup()
        {
            var chance = Settings.powerupSpawnRate;
            var rng = new Random().Next(0, 100);
            if (!(rng < chance * 100)) return;
            var maxX = canvas.Size.Width / Settings.Width;
            var maxY = canvas.Size.Height / Settings.Height;
            var rand = new Random();

            var x = rand.Next(0, maxX);
            var y = rand.Next(0, maxY);

            _powerup = new Powerup { X = x, Y = y };
        }

        private static void GameOver()
        {
            Settings.IsGameOver = true;
        }

        private void EatFood()
        {
            //For adding circle to snake's body on eating the food
            var snake = new Shape
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };
            Snake.Add(snake);
            //for updating the score
            Settings.Score += Settings.Points;
            score_l.Text = Settings.Score.ToString();
            highscoreLBL.Text = Highscore.GetHighScore(Settings.player1Name).ToString();
            CreateFood();
            CreatePowerup();
        }

        private void EatPowerup(string p)
        {
            if (p == "extraPoints")
            {
                _extraPoints.Play();
                Settings.Score += 500;
                score_l.Text = Settings.Score.ToString();
                highscoreLBL.Text = Highscore.GetHighScore(Settings.player1Name).ToString();
            }

            if (p == "shortenSnake")
            {
                //TODO
            }

            _powerup.X = -100;
            _powerup.Y = -100;
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            var draw = e.Graphics;

            if (!Settings.IsGameOver)
            {
                //Draw snake's body 
                for (var i = 0; i < Snake.Count; i++)
                {
                    //TODO: Add image implementation or different rendering methods
                    Brush snakeColor;

                    snakeColor = i == 0 ? Settings.headColor : Settings.bodyColor;

                    switch (Settings.snakeShape)
                    {
                        //For drawing the snake
                        case "circle":
                            draw.FillEllipse(snakeColor,
                                new Rectangle(Snake[i].X * Settings.Width, Snake[i].Y * Settings.Height, Settings.Width,
                                    Settings.Height));
                            break;
                        case "square":
                            draw.FillRectangle(snakeColor,
                                new Rectangle(Snake[i].X * Settings.Width, Snake[i].Y * Settings.Height, Settings.Width,
                                    Settings.Height));
                            break;
                    }

                    switch (Settings.foodShape)
                    {
                        //For drawing the food
                        case "circle":
                            draw.FillEllipse(Settings.foodColor,
                                new Rectangle(_food.X * Settings.Width, _food.Y * Settings.Height, Settings.Width,
                                    Settings.Height));
                            break;
                        case "square":
                            draw.FillRectangle(Settings.foodColor,
                                new Rectangle(_food.X * Settings.Width, _food.Y * Settings.Height, Settings.Width,
                                    Settings.Height));
                            break;
                    }

                    //draw powerup

                    draw.FillRectangle(Test,
                        new Rectangle(_powerup.X * Settings.Width, _powerup.Y * Settings.Height, Settings.Width,
                            Settings.Height));
                }
            }

            else
            {
                string message;
                if (Highscore.SetHighScore(Settings.player1Name, Settings.Score))
                    message = "Reached High Score !!\nYour Score is: " + Settings.Score +
                              "\n\nPress ENTER Key to try again";
                else
                    message = _deathCause + "\n\nYour Score is: " + Settings.Score + "\n\nPress ENTER to try again";
                status_l.Text = message;
                status_l.Visible = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            GameInput.ChangeState(e.KeyCode, true);
            if (GameInput.PressedKey(Keys.U)) canvas.BackgroundImage = _background;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            GameInput.ChangeState(e.KeyCode, false);
        }


        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.IsGamePaused = true;
            _settings.ShowDialog();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.IsGamePaused = true;
            _profiles.ShowDialog();
        }

        private void mapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.IsGamePaused = true;
            _maps.ShowDialog();
        }
    }
}