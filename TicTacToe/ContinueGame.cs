using System;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class ContinueGame : Form
    {
        public ContinueGame()
        {
            InitializeComponent();
        }

        private void GetChoiceButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
