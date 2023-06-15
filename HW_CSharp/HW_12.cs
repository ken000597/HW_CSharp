using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace HW_CSharp
{
    public partial class HW_12 : Form
    {
        private Button startButton;
        private int targetNumber;
        private int attempts;
        private int minNumber = 1; // 最小數字範圍
        private int maxNumber = 100; // 最大數字範圍

        public HW_12()
        {
            InitializeComponent();
        
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void StartGame()
        {
            Random random = new Random();
            targetNumber = random.Next(1, 101);
            attempts = 0;
            minNumber = 1;
            maxNumber = 100;
            GuessNumber();
        }

        private void HW_12_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 按下關閉按鈕時結束遊戲
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Close();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // 按下Enter鍵時執行猜數字的邏輯
            if (keyData == Keys.Enter)
            {
                GuessNumber();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void GuessNumber()
        {
            int number;
            bool isNumberValid = false;

            string input = Interaction.InputBox("請輸入一個數字（" + minNumber + "-" + maxNumber + "）：", "猜數字遊戲");

            if (string.IsNullOrEmpty(input))
            {
                Close();
                return;
            }

            isNumberValid = int.TryParse(input, out number);
            if (!isNumberValid || number < minNumber || number > maxNumber)
            {
                MessageBox.Show("請輸入有效的數字（" + minNumber + "-" + maxNumber + "）！", "猜數字遊戲", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GuessNumber();
                return;
            }

            attempts++;
            if (number < targetNumber)
            {
                minNumber = number + 1;
            }
            else if (number > targetNumber)
            {
                maxNumber = number - 1;
            }
            else
            {
                MessageBox.Show("恭喜你猜對了！答案是 " + targetNumber, "猜數字遊戲", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("你總共猜了 " + attempts + " 次。", "猜數字遊戲", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            GuessNumber();
        }
    }
}