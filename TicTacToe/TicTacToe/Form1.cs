using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Player Player1=new Player();
        Player Player2=new Player();

        public void EnableButton()
        {
            Position11_button.Enabled = true;
            Position11_button.Text = "    ";
            Position12_button.Enabled = true;
            Position12_button.Text = "    ";
            Position13_button.Enabled = true;
            Position13_button.Text = "   ";
            position21_button.Enabled = true;
            position21_button.Text = "    ";
            position22_button.Enabled = true;
            position22_button.Text = "    ";
            position23_button.Enabled = true;
            position23_button.Text = "    ";
            position31_button.Enabled = true;
            position31_button.Text = "    ";
            position32_button.Enabled = true;
            position32_button.Text = "    ";
            position33_button.Enabled = true;
            position33_button.Text = "    ";
        }
        public void DisableButton()
        {
            Position11_button.Enabled = false;
            Position11_button.Text = "    ";
            Position12_button.Enabled = false;
            Position12_button.Text = "    ";
            Position13_button.Enabled =false;
            Position13_button.Text = "   ";
            position21_button.Enabled = false;
            position21_button.Text = "    ";
            position22_button.Enabled = false;
            position22_button.Text = "    ";
            position23_button.Enabled = false;
            position23_button.Text = "    ";
            position31_button.Enabled = false;
            position31_button.Text = "    ";
            position32_button.Enabled = false;
            position32_button.Text = "    ";
            position33_button.Enabled = false;
            position33_button.Text = "    ";
        }
        private void Position11_button_Click(object sender, EventArgs e)
        {
            if (TictacToe.Check_Game())
            {
                if (PlayersMoveLabel.Text == "Player 1's Move")
                {
                    PlayersMoveLabel.Text = "Player 2's Move";
                    Position11_button.Text = "X";
                    TictacToe.arr[0, 0] = "X";
                    if (TictacToe.WinGame(0, 0))
                    {
                        Player1.AddPoint(Player1);
                        DisableButton();
                        MessageBox.Show("Game Won by Player1");
                    }
                    Position11_button.Enabled = false;

                }
                else if (PlayersMoveLabel.Text == "Player 2's Move")
                {
                    PlayersMoveLabel.Text = "Player 1's Move";
                    Position11_button.Text = "O";
                    TictacToe.arr[0, 0] = "O";
                    if (TictacToe.WinGame(0, 0))
                    {
                        Player2.AddPoint(Player2);
                        DisableButton();
                        MessageBox.Show("Game Won by Player2");
                    }
                    Position11_button.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Game Ended");
            }
        }

        private void Position12_button_Click(object sender, EventArgs e)
        {
            if (TictacToe.Check_Game())
            {
                if (PlayersMoveLabel.Text == "Player 1's Move")
                {
                    PlayersMoveLabel.Text = "Player 2's Move";
                    Position12_button.Text = "X";
                    TictacToe.arr[0, 1] = "X";
                    if (TictacToe.WinGame(0, 1))
                    {
                        Player1.AddPoint(Player1);
                        DisableButton();
                        MessageBox.Show("Game Won by Player1");
                    }
                    Position12_button.Enabled = false;
                }
                else if (PlayersMoveLabel.Text == "Player 2's Move")
                {
                    PlayersMoveLabel.Text = "Player 1's Move";
                    Position12_button.Text = "O";
                    TictacToe.arr[0, 1] = "O";
                    if (TictacToe.WinGame(0, 1))
                    {
                        Player2.AddPoint(Player2);
                        DisableButton();
                        MessageBox.Show("Game Won by Player2");
                    }
                    Position12_button.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Game Ended");
            }
        }

        private void Position13_button_Click(object sender, EventArgs e)
        {
            if (TictacToe.Check_Game())
            {
                if (PlayersMoveLabel.Text == "Player 1's Move")
                {
                    PlayersMoveLabel.Text = "Player 2's Move";
                    Position13_button.Text = "X";
                    TictacToe.arr[0, 2] = "X";
                    if (TictacToe.WinGame(0, 2))
                    {
                        Player1.AddPoint(Player1);
                        DisableButton();
                        MessageBox.Show("Game Won by Player1");
                    }
                    Position13_button.Enabled = false;
                }
                else if (PlayersMoveLabel.Text == "Player 2's Move")
                {
                    PlayersMoveLabel.Text = "Player 1's Move";
                    Position13_button.Text = "O";
                    TictacToe.arr[0, 2] = "O";
                    if (TictacToe.WinGame(0, 2))
                    {
                        Player2.AddPoint(Player2);
                        DisableButton();
                        MessageBox.Show("Game Won by Player2");
                    }
                    Position13_button.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Game Ended");
            }
        }

        private void position21_button_Click(object sender, EventArgs e)
        {
            if (TictacToe.Check_Game())
            {
                if (PlayersMoveLabel.Text == "Player 1's Move")
                {
                    PlayersMoveLabel.Text = "Player 2's Move";
                    position21_button.Text = "X";
                    TictacToe.arr[1, 0] = "X";
                    if (TictacToe.WinGame(1, 0))
                    {
                        Player1.AddPoint(Player1);
                        DisableButton();
                        MessageBox.Show("Game Won by Player1");
                    }
                    position21_button.Enabled = false;
                }
                else if (PlayersMoveLabel.Text == "Player 2's Move")
                {
                    PlayersMoveLabel.Text = "Player 1's Move";
                    position21_button.Text = "O";
                    TictacToe.arr[1, 0] = "O";
                    if (TictacToe.WinGame(1, 0))
                    {
                        Player1.AddPoint(Player2);
                        DisableButton();
                        MessageBox.Show("Game Won by Player2");
                    }
                    position21_button.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Game Ended");
            }
        }

        private void position22_button_Click(object sender, EventArgs e)
        {
            if (TictacToe.Check_Game())
            {
                if (PlayersMoveLabel.Text == "Player 1's Move")
                {
                    PlayersMoveLabel.Text = "Player 2's Move";
                    position22_button.Text = "X";
                    TictacToe.arr[1, 1] = "X";
                    if (TictacToe.WinGame(1, 1))
                    {
                        Player1.AddPoint(Player1);
                        DisableButton();
                        MessageBox.Show("Game Won by Player1");
                    }
                    position22_button.Enabled = false;
                }
                else if (PlayersMoveLabel.Text == "Player 2's Move")
                {
                    PlayersMoveLabel.Text = "Player 1's Move";
                    position22_button.Text = "O";
                    TictacToe.arr[1, 1] = "O";
                    if (TictacToe.WinGame(1, 1))
                    {
                        Player2.AddPoint(Player2);
                        DisableButton();
                        MessageBox.Show("Game Won by Player2");
                    }
                    position22_button.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Game Ended");
            }
        }

        private void position23_button_Click(object sender, EventArgs e)
        {
            if (TictacToe.Check_Game())
            {
                if (PlayersMoveLabel.Text == "Player 1's Move")
                {
                    PlayersMoveLabel.Text = "Player 2's Move";
                    position23_button.Text = "X";
                    TictacToe.arr[1, 2] = "X";
                    if (TictacToe.WinGame(1, 2))
                    {
                        Player1.AddPoint(Player1);
                        DisableButton();
                        MessageBox.Show("Game Won by Player1");
                    }
                    position23_button.Enabled = false;
                }
                else if (PlayersMoveLabel.Text == "Player 2's Move")
                {
                    PlayersMoveLabel.Text = "Player 1's Move";
                    position23_button.Text = "O";
                    TictacToe.arr[1, 2] = "O";
                    if (TictacToe.WinGame(1, 2))
                    {
                        Player2.AddPoint(Player2);
                        DisableButton();
                        MessageBox.Show("Game Won by Player2");
                    }
                    position23_button.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Game Ended");
            }
        }

        private void position31_button_Click(object sender, EventArgs e){
            if (TictacToe.Check_Game())
            {
                if (PlayersMoveLabel.Text == "Player 1's Move")
                {
                    PlayersMoveLabel.Text = "Player 2's Move";
                    position31_button.Text = "X";
                    TictacToe.arr[2, 0] = "X";
                    if (TictacToe.WinGame(2, 0))
                    {
                        Player1.AddPoint(Player1);
                        DisableButton();
                        MessageBox.Show("Game Won by Player1");
                    }
                    position31_button.Enabled = false;
                }
                else if (PlayersMoveLabel.Text == "Player 2's Move")
                {
                    PlayersMoveLabel.Text = "Player 1's Move";
                    position31_button.Text = "O";
                    TictacToe.arr[2, 0] = "O";
                    if (TictacToe.WinGame(2, 0))
                    {
                        Player2.AddPoint(Player2);
                        DisableButton();
                        MessageBox.Show("Game Won by Player2");
                    }
                    position31_button.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Game Ended");
            }

        }

        private void position32_button_Click(object sender, EventArgs e) {
            if (TictacToe.Check_Game())
            {
                if (PlayersMoveLabel.Text == "Player 1's Move")
                {
                    PlayersMoveLabel.Text = "Player 2's Move";
                    position32_button.Text = "X";
                    TictacToe.arr[2, 1] = "X";
                    if (TictacToe.WinGame(2, 1))
                    {
                        Player1.AddPoint(Player1);
                        DisableButton();
                        MessageBox.Show("Game Won by Player1");
                    }
                    position32_button.Enabled = false;
                }
                else if (PlayersMoveLabel.Text == "Player 2's Move")
                {
                    PlayersMoveLabel.Text = "Player 2's Move";
                    position32_button.Text = "O";
                    TictacToe.arr[2, 1] = "O";
                    if (TictacToe.WinGame(2, 1))
                    {
                        Player2.AddPoint(Player2);
                        DisableButton();
                        MessageBox.Show("Game Won by Player2");
                    }
                    position32_button.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Game Ended");
            }
        }

        private void position33_button_Click(object sender, EventArgs e){
            if (TictacToe.Check_Game())
            {
                if (PlayersMoveLabel.Text == "Player 1's Move")
                {
                    PlayersMoveLabel.Text = "Player 2's Move";
                    position33_button.Text = "X";
                    TictacToe.arr[2, 2] = "X";
                    if (TictacToe.WinGame(2, 2))
                    {
                        Player1.AddPoint(Player1);
                        MessageBox.Show("Game Won by Player1");
                    }
                    position33_button.Enabled = false;
                }
                else if (PlayersMoveLabel.Text == "Player 2's Move")
                {
                    PlayersMoveLabel.Text = "Player 1's Move";
                    position33_button.Text = "O";
                    TictacToe.arr[2, 2] = "O";
                    if (TictacToe.WinGame(2, 2))
                    {
                        Player1.AddPoint(Player2);
                        DisableButton();
                        MessageBox.Show("Game Won by Player2");
                    }
                    position33_button.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Game Ended");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void reset_button_Click(object sender, EventArgs e)
        {   
            Player1_point.Text="Player 1 :   "+Convert.ToString(Player1.point);
            Player2_point.Text="Player 2 :   "+Convert.ToString(Player2.point);
            TictacToe.ArrayRefresh();
            EnableButton();
            PlayersMoveLabel.Text= "Player 1's Move";
        }

        private void END_Click(object sender, EventArgs e)
        {
           int l= TictacToe.Winner(Player1, Player2);
            if (l == 0)
            {
                Player1_point.Text = "Player 1 :   " + Convert.ToString(Player1.point);
                Player2_point.Text = "Player 2 :   " + Convert.ToString(Player2.point);
                MessageBox.Show("Draw");
            }
            else if (l == 1)
            {
                Player1_point.Text = "Player 1 :   " + Convert.ToString(Player1.point);
                Player2_point.Text = "Player 2 :   " + Convert.ToString(Player2.point);
                MessageBox.Show("Player 1 won it");
            }
            else
            {
                Player1_point.Text = "Player 1 :   " + Convert.ToString(Player1.point);
                Player2_point.Text = "Player 2 :   " + Convert.ToString(Player2.point);
                MessageBox.Show("Player 2 won it");
            }
            Player1.point = 0;
            Player2.point = 0;
            TictacToe.ArrayRefresh();
            EnableButton();
            PlayersMoveLabel.Text = "Player 1's Move";
        }
    }
}
