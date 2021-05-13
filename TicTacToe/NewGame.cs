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
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                FirstPlayer = textBox1.Text;
                SecondPlayer = textBox2.Text;
                IsNewNames = true;
                Close();     
            }
            else
            {
                throw new ArgumentNullException(nameof(sender));
            }
        }

        public void SetNewNames(ref string firstPlayer, ref string secondPlayer)
        {
            firstPlayer = (string.IsNullOrWhiteSpace(FirstPlayer)) ? "NoName_1" : FirstPlayer; 
            secondPlayer = (string.IsNullOrWhiteSpace(SecondPlayer)) ? "NoName_2" : SecondPlayer; 
        }
    }
}
