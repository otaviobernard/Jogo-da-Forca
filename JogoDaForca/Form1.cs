using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaForca
{
    public partial class Form1 : Form
    {
        ForkGame novoJogo;
        public Form1()
        {
            InitializeComponent();
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            novoJogo = new ForkGame();
            labelForca.Text = novoJogo.StringJogo();
            labelForca.Visible = true;
            groupButton.Visible = true;
        }

        private void youWin()
        {
            MessageBox.Show("Você venceu!!!!!!");
            labelForca.Text = novoJogo.StringReal();
        }

        private void inputButton_Click(object sender, EventArgs e)
        {
            if (textBoxInput.Text == novoJogo.StringReal())
            {
                youWin();
            }
            textBoxInput.Text = "";
        }

        private void letterButton_Click(object sender, EventArgs e)
        {
            labelForca.Text = novoJogo.RunArray(char.Parse(textBoxLetter.Text), labelForca.Text, novoJogo.StringReal());
            if (novoJogo.checkIfWin(labelForca.Text, novoJogo.StringReal()))
            {
                youWin();
            }
            textBoxLetter.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cleanButton_Click(object sender, EventArgs e)
        {
            textBoxLetter.Text = "";
        }
    }
}
