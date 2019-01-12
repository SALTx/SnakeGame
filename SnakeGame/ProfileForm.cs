using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class ProfileForm : Form
    {
        
        public ProfileForm()
        {
            InitializeComponent();
            player1nameTB.Text = Settings.player1Name;
            player2nameTB.Text = Settings.player2Name;
            player1highscoreLBL.Text = Highscore.GetHighScore(player1nameTB.Text) + "";
            player2highscoreLBL.Text = Highscore.GetHighScore(player2nameTB.Text) + "";
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            Settings.player1Name = player1nameTB.Text;
            Settings.player2Name = player2nameTB.Text;
            player1highscoreLBL.Text = Highscore.GetHighScore(player1nameTB.Text) + "";
            player2highscoreLBL.Text = Highscore.GetHighScore(player2nameTB.Text) + "";
            Highscore.addRecord(player1nameTB.Text);
        }
    }
}
