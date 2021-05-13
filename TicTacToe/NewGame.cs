using System;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class NewGame : Form
    {
        private string FirstPlayer { get; set; }
        private string SecondPlayer { get; set; }

        public bool IsNewNames { get; set; } = false;

        public NewGame()
        {
            InitializeComponent();
            this.Errorlabel1.Text = "";
            this.Errorlabel2.Text = "";
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    FirstPlayer = textBox1.Text;
                    SecondPlayer = textBox2.Text;
                    IsNewNames = true;
                    Close();
                }
                else
                {
                    this.Errorlabel1.Text = (textBox1.Text == "") ? "Пустое поле!" : "";
                    this.Errorlabel2.Text = (textBox2.Text == "") ? "Пустое поле!" : "";
                }                
            }
            else
            {
                throw new ArgumentNullException(nameof(sender));
            }
        }

        public void SetNewNames(ref string firstPlayer, ref string secondPlayer)
        {
            firstPlayer = FirstPlayer;
            secondPlayer = SecondPlayer;
        }
    }
}
