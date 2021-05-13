using System;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Main : Form
    {
        private string FirstPlayer;
        private string SecondPlayer;
        private bool IsFirstPlayer { get; set; }

        private Button[,] buttons = new Button[3, 3];        

        public Main()
        {
            InitializeComponent();
            var formNewGame = new NewGame();
            formNewGame.ShowDialog();

            if (formNewGame.DialogResult == DialogResult.OK && formNewGame.IsNewNames)
            {
                formNewGame.SetNewNames(ref FirstPlayer, ref SecondPlayer);
            }            
            this.Width = 400;
            this.Height = 500;
            CreateButtons(buttons);
            SetButtons(buttons);
            IsFirstPlayer = true;
            PlayerTurnlabel.Text = FirstPlayer;
        }

        private void CreateButtons(Button[,] buttons)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Size = new Size(90, 90);
                    buttons[i, j].Enabled = true;
                    buttons[i, j].Location = new Point(50 + i * 100, 150 + j * 100);
                    buttons[i, j].Font = new Font("Microsoft Sans Serif", 24, FontStyle.Bold);
                    buttons[i, j].BackColor = Color.White;
                    buttons[i, j].Click += Button_Click;
                }
            }
        }

        private void SetButtons(Button[,] buttons)
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    this.Controls.Add(buttons[i, j]);  
        }

        private bool CheckGame(string playedPlayer)
        {
            if (string.IsNullOrWhiteSpace(playedPlayer))
            {
                throw new ArgumentException($"{nameof(playedPlayer)} не может быть пустым или содержать только пробел", nameof(playedPlayer));
            }
            var winner = "Победил - " + playedPlayer;

            // Проверка столбцов.
            for (int i = 0; i < 3; i++)
            {  
                if (buttons[i, 0].Text == buttons[i, 1].Text && buttons[i, 1].Text == buttons[i, 2].Text)
                {
                    if (buttons[i, 0].Text != "")
                    {
                        MessageBox.Show(winner);
                        return true;
                    }
                }                               
            }
            
            // Проверка строк.
            for (int i = 0; i < 3; i++)
            {
                if (buttons[0, i].Text == buttons[1, i].Text && buttons[1, i].Text == buttons[2, i].Text)
                {
                    if (buttons[0, i].Text != "")
                    {
                        MessageBox.Show(winner);
                        return true;
                    }
                }
            }

            // Проверка по диагоналям.
            if (buttons[0, 0].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[2, 2].Text)
            {
                if (buttons[0, 0].Text != "")
                {
                    MessageBox.Show(winner);
                    return true;
                }
            }
            if (buttons[0, 2].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[2, 0].Text)
            {
                if (buttons[0, 2].Text != "")
                {
                    MessageBox.Show(winner);
                    return true;
                }
            }
            return false;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void ResetButtons()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    buttons[i, j].Text = "";
                }
            }
                
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                if (button.Text != "")
                    return;
                if (IsFirstPlayer)
                {
                    button.Text = "X";
                    IsFirstPlayer = false;
                    PlayerTurnlabel.Text = SecondPlayer;
                }
                else
                {
                    button.Text = "O";
                    IsFirstPlayer = true;
                    PlayerTurnlabel.Text = FirstPlayer;
                }
                if (CheckGame(IsFirstPlayer ? SecondPlayer : FirstPlayer))
                {
                    var formContinue = new ContinueGame();
                    if (formContinue.ShowDialog() == DialogResult.Yes)
                    {
                        // TODO: Переделать.
                        var formNewGame = new NewGame();
                        formNewGame.ShowDialog();

                        if (formNewGame.DialogResult == DialogResult.OK && formNewGame.IsNewNames)
                        {
                            formNewGame.SetNewNames(ref FirstPlayer, ref SecondPlayer);
                            ResetButtons();
                        }
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }
            else
            {
                throw new ArgumentNullException(nameof(sender));
            }
        }
    }
}
