using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_CSharp
{
    public partial class HW_09 : Form
    {
        char[,] board = new char[3, 3];

        public HW_09()
        {
            InitializeComponent();
            InitializeBoard();

        }

        int turnCounter = 0;

        private void btn1_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            if (string.IsNullOrEmpty(clickedButton.Text))
            {
                if (turnCounter % 2 == 0)
                {
                    clickedButton.Text = "O";
                    board[0, 0] = 'O'; // 將玩家的選擇儲存在board陣列中
                }
                else
                {
                    clickedButton.Text = "X";
                    board[0, 0] = 'X'; // 將玩家的選擇儲存在board陣列中
                }

                turnCounter++;

                if (CheckForWinner())
                {
                    ShowEndGameMessage("獲勝！");
                    RestartGame();
                }
                else if (turnCounter == 9)
                {
                    ShowEndGameMessage("平局！");
                    RestartGame();
                }
            }
        }
        // 檢查是否有玩家獲勝的方法（示例）

        private bool CheckForWinner()
        {
            // 檢查行
            for (int row = 0; row < 3; row++)
            {
                if (board[row, 0] != '\0' && board[row, 0] == board[row, 1] && board[row, 1] == board[row, 2])
                {
                    return true;
                }
            }

            // 檢查列
            for (int col = 0; col < 3; col++)
            {
                if (board[0, col] != '\0' && board[0, col] == board[1, col] && board[1, col] == board[2, col])
                {
                    return true;
                }
            }

            // 檢查對角線
            if (board[0, 0] != '\0' && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                return true;
            }

            if (board[0, 2] != '\0' && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                return true;
            }

            return false;
        }





        // 重新開始遊戲的方法（示例）
        private void RestartGame()
        {
            foreach (Control control in Controls)
    {
        if (control is Button button)
        {
            button.Text = string.Empty; // 清空按鈕的文字
        }
    }

    // 重置遊戲相關的變數
    turnCounter = 0;
    board = new char[3, 3];

            // 重新開始遊戲後的額外邏輯處理
            // ...

            // 重新設定 Restart 按鈕的文字（如果有需要）
            btnReStart.Text = "ReStart";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            if (string.IsNullOrEmpty(clickedButton.Text))
            {
                if (turnCounter % 2 == 0)
                {
                    clickedButton.Text = "O";
                    board[0, 1] = 'O'; // 將玩家的選擇儲存在board陣列中
                }
                else
                {
                    clickedButton.Text = "X";
                    board[0, 1] = 'X'; // 將玩家的選擇儲存在board陣列中
                }

                turnCounter++;

                if (CheckForWinner())
                {
                    ShowEndGameMessage("獲勝！");
                    RestartGame();
                }
                else if (turnCounter == 9)
                {
                    ShowEndGameMessage("平局！");
                    RestartGame();
                }
            }
        }


        private void btn4_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            if (string.IsNullOrEmpty(clickedButton.Text))
            {
                if (turnCounter % 2 == 0)
                {
                    clickedButton.Text = "O";
                    board[1, 0] = 'O'; // 將玩家的選擇儲存在board陣列中
                }
                else
                {
                    clickedButton.Text = "X";
                    board[1, 0] = 'X'; // 將玩家的選擇儲存在board陣列中
                }

                turnCounter++;

                if (CheckForWinner())
                {
                    ShowEndGameMessage("獲勝！");
                    RestartGame();
                }
                else if (turnCounter == 9)
                {
                    ShowEndGameMessage("平局！");
                    RestartGame();
                }
            }
        }


        private void btn6_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            if (string.IsNullOrEmpty(clickedButton.Text))
            {
                if (turnCounter % 2 == 0)
                {
                    clickedButton.Text = "O";
                    board[1, 2] = 'O'; // 將玩家的選擇儲存在board陣列中
                }
                else
                {
                    clickedButton.Text = "X";
                    board[1, 2] = 'X'; // 將玩家的選擇儲存在board陣列中
                }

                turnCounter++;

                if (CheckForWinner())
                {
                    ShowEndGameMessage("獲勝！");
                    RestartGame();
                }
                else if (turnCounter == 9)
                {
                    ShowEndGameMessage("平局！");
                    RestartGame();
                }
            }
        }


        private void btn9_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            if (string.IsNullOrEmpty(clickedButton.Text))
            {
                if (turnCounter % 2 == 0)
                {
                    clickedButton.Text = "O";
                    board[2, 2] = 'O'; // 將玩家的選擇儲存在board陣列中
                }
                else
                {
                    clickedButton.Text = "X";
                    board[2, 2] = 'X'; // 將玩家的選擇儲存在board陣列中
                }

                turnCounter++;

                if (CheckForWinner())
                {
                    ShowEndGameMessage("獲勝！");
                    RestartGame();
                }
                else if (turnCounter == 9)
                {
                    ShowEndGameMessage("平局！");
                    RestartGame();
                }
            }
        }


        private void btn8_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            if (string.IsNullOrEmpty(clickedButton.Text))
            {
                if (turnCounter % 2 == 0)
                {
                    clickedButton.Text = "O";
                    board[2, 1] = 'O'; // 將玩家的選擇儲存在board陣列中
                }
                else
                {
                    clickedButton.Text = "X";
                    board[2, 1] = 'X'; // 將玩家的選擇儲存在board陣列中
                }

                turnCounter++;

                if (CheckForWinner())
                {
                    ShowEndGameMessage("獲勝！");
                    RestartGame();
                }
                else if (turnCounter == 9)
                {
                    ShowEndGameMessage("平局！");
                    RestartGame();
                }
            }
        }


        private void btn5_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            if (string.IsNullOrEmpty(clickedButton.Text))
            {
                if (turnCounter % 2 == 0)
                {
                    clickedButton.Text = "O";
                    board[1, 1] = 'O'; // 將玩家的選擇儲存在board陣列中
                }
                else
                {
                    clickedButton.Text = "X";
                    board[1, 1] = 'X'; // 將玩家的選擇儲存在board陣列中
                }

                turnCounter++;

                if (CheckForWinner())
                {
                    ShowEndGameMessage("獲勝！");
                    RestartGame();
                }
                else if (turnCounter == 9)
                {
                    ShowEndGameMessage("平局！");
                    RestartGame();
                }
            }
        }


        private void btn7_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            if (string.IsNullOrEmpty(clickedButton.Text))
            {
                if (turnCounter % 2 == 0)
                {
                    clickedButton.Text = "O";
                    board[0, 0] = 'O'; // 將玩家的選擇儲存在board陣列中
                }
                else
                {
                    clickedButton.Text = "X";
                    board[0, 0] = 'X'; // 將玩家的選擇儲存在board陣列中
                }

                turnCounter++;

                if (CheckForWinner())
                {
                    ShowEndGameMessage("獲勝！");
                    RestartGame();
                }
                else if (turnCounter == 9)
                {
                    ShowEndGameMessage("平局！");
                    RestartGame();
                }
            }
        }


        private void btn3_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            if (string.IsNullOrEmpty(clickedButton.Text))
            {
                if (turnCounter % 2 == 0)
                {
                    clickedButton.Text = "O";
                    board[0, 2] = 'O'; // 將玩家的選擇儲存在board陣列中
                }
                else
                {
                    clickedButton.Text = "X";
                    board[0, 2] = 'X'; // 將玩家的選擇儲存在board陣列中
                }

                turnCounter++;

                if (CheckForWinner())
                {
                    ShowEndGameMessage("獲勝！");
                    RestartGame();
                }
                else if (turnCounter == 9)
                {
                    ShowEndGameMessage("平局！");
                    RestartGame();
                }
            }
        }

        private void ShowEndGameMessage(string message)
        {
            MessageBox.Show(message, "遊戲結束", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnReStart_Click(object sender, EventArgs e)
        {
            RestartGame();
        }




        private void InitializeBoard()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    board[row, col] = '\0';
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void HW_09_Load(object sender, EventArgs e)
        {

        }
    }
}    

