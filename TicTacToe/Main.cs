using System;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Main : Form
    {
        // TODO: Написать никнеймы для 2 игроков и запрос для этого.
        private string FirstPlayer { get; set; }
        private string SecondPlayer { get; set; }
        private bool IsFirstPlayer { get; set; }

        private Button[,] buttons = new Button[3, 3];        

        public Main()
        {
            InitializeComponent();
            this.Width = 400;
            this.Height = 500;
            CreateButtons(buttons);
            SetButtons(buttons);
            IsFirstPlayer = true;
            FirstPlayer = "Игрок_1";
            SecondPlayer = "Игрок_2";
            PlayerTurnlabel.Text = FirstPlayer;
        }

        private void CreateButtons(Button[,] buttons)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Size = new System.Drawing.Size(90, 90);
                    buttons[i, j].Enabled = true;
                    buttons[i, j].Location = new System.Drawing.Point(50 + i * 100, 150 + j * 100);
                    buttons[i, j].Font = new System.Drawing.Font("Microsoft Sans Serif", 24, System.Drawing.FontStyle.Bold);
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

        private void CheckGame(string currentPlayer)
        {
            if (string.IsNullOrWhiteSpace(currentPlayer))
            {
                throw new ArgumentException($"{nameof(currentPlayer)} не может быть пустым или содержать только пробел", nameof(currentPlayer));
            }

            // Проверка строк.
            for (int i = 0; i < 3; i++)
            {  
                if (buttons[i, 0].Text == buttons[i, 1].Text && buttons[i, 1].Text == buttons[i, 2].Text)
                {
                    if (buttons[i, 0].Text != "")
                    {
                        MessageBox.Show("Win!!!");
                        return;
                    }
                }                               
            }

            // Проверка столбцов.
            for (int i = 0; i < 3; i++)
            {
                if (buttons[0, i].Text == buttons[1, i].Text && buttons[1, i].Text == buttons[2, i].Text)
                {
                    if (buttons[i, 0].Text != "")
                    {
                        MessageBox.Show("Win!!!");
                        return;
                    }
                }
            }

            // Проверка по диагоналям.
            if (buttons[0, 0].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[2, 2].Text)
            {
                if (buttons[0, 0].Text != "")
                {
                    MessageBox.Show("Win!!!");
                    return;
                }
            }
            if (buttons[0, 2].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[2, 0].Text)
            {
                if (buttons[0, 2].Text != "")
                {
                    MessageBox.Show("Win!!!");
                    return;
                }
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
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
                button.Enabled = false;
                CheckGame(IsFirstPlayer ? FirstPlayer : SecondPlayer);
            }
            else
            {
                throw new ArgumentNullException(nameof(sender));
            }
        }
    }
}
