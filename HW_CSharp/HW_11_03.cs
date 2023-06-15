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
    public partial class HW_11_03 : Form
    {
        public HW_11_03()
        {
            InitializeComponent();
        }

        private void HW_11_03_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true; // 啟用按鍵預覽
            this.KeyDown += HW_11_03_KeyDown;
        }

        private int velocityX = 30; // X轴速度
        private int velocityY = 30; // Y轴速度

        private void timer1_Tick(object sender, EventArgs e)
        {
            // 移动标签
            PBSS.Left += velocityX;
            PBSS.Top += velocityY;

            // 检查是否触碰到窗体边界
            if (PBSS.Left <= 0 || PBSS.Right >= this.ClientSize.Width)
            {
                velocityX = -velocityX; // 反转X轴速度
            }

            if (PBSS.Top <= 0 || PBSS.Bottom >= this.ClientSize.Height)
            {
                velocityY = -velocityY; // 反转Y轴速度
            }



        }

        private void HW_11_03_Click(object sender, EventArgs e)
        {

            this.Close();


        }

        private void HW_11_03_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) // 檢查是否按下 ESC 鍵
            {
                this.Close();
            }
        }

    }
}
