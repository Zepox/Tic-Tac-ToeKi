using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OwnTicTacToe
{
    public partial class Form1 : Form
    {
        public int player = 2;
        public int turn = 0;
        public int s1 = 0;
        public int s2 = 0;
        public int sd = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (player % 2 == 0)
            {
                button.Text = "X";
                turn++;
                player++;
            }
            else
            {
                button.Text = "O";
                turn++;
                player--;
            }
            if (CheckDraw() == true)
            {
                MessageBox.Show("Draw");
                sd++;
                newGame();
            }
            if (CheckWinner() == true)
            {
                if (button.Text == "X")
                {
                    MessageBox.Show("X Won!");
                    s1++;
                    newGame();
                }
                else
                {
                    MessageBox.Show("O Won!");
                    s2++;
                    newGame();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XWin.Text = "X Won " + s1;
            OWin.Text = "O Won " + s2;
            Draw.Text = "Draws " + sd;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            newGame();
        }

        void newGame()
        {
            player = 2;
            A1.Text = A2.Text = A3.Text = B1.Text = B2.Text = B3.Text = C1.Text = C2.Text = C3.Text = "";
            turn = 0;
            XWin.Text = "X Won " + s1;
            OWin.Text = "O Won " + s2;
            Draw.Text = "Draws " + sd;
        }
        public bool CheckDraw()
        {
            if (turn == 9)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckWinner()
        {
            // Horizontal
            if (A1.Text == A2.Text && A2.Text == A3.Text && A3.Text != "")
            {
                return true;
            }
            else if (B1.Text == B2.Text && B2.Text == B3.Text && B3.Text != "")
            {
                return true;
            }
            else if (C1.Text == C2.Text && C2.Text == C3.Text && C3.Text != "")
            {
                return true;
            }
            //Check Verticle
            else if (A1.Text == B1.Text && B1.Text == C1.Text && C1.Text != "")
            {
                return true;
            }
            else if (A2.Text == B2.Text && B2.Text == C2.Text && C2.Text != "")
            {
                return true;
            }
            else if (A3.Text == B3.Text && B3.Text == C3.Text && C3.Text != "")
            {
                return true;
            }
            //Check diagonal
            else if (A1.Text == B2.Text && B2.Text == C3.Text && C3.Text != "")
            {
                return true;
            }
            else if (A3.Text == B2.Text && B2.Text == C1.Text && C1.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            s1 = s2 = sd = 0;
            newGame();
        }
    }
}
