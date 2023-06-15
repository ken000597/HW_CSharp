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
    public partial class HW_11_02 : Form
    {
        public HW_11_02()
        {
            InitializeComponent();
        }
        //點螢幕關閉

        private void HW_11_02Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //隨機變數R
        Random R = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            //做出時鐘
            labTime.Text = DateTime.Now.ToString();
            // 向左移動5個像素，每0.1秒1個TIMER
            labTime.Left -= 5;


            //當labTime位置在右邊<0時，也就是出左邊外
            if (labTime.Right < 0)
            {
                //拉回原來位置
                labTime.Left = this.ClientSize.Width;
                //隨機指定高度
                labTime.Top = R.Next(this.Height - labTime.Height);
            }

        }

        private void HW_11_02_Load(object sender, EventArgs e)
        {
            labTime.Text= DateTime.Now.ToString();
            timer1.Start();
            this.KeyPreview = true; // 啟用按鍵預覽

            // 新增 KeyDown 事件處理方法
            this.KeyDown += HW_11_02_KeyDown;
        }
        private void HW_11_02_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) // 檢查是否按下 ESC 鍵
            {
                this.Close();
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            //設定隨機圓參數
            int D = R.Next(this.Height);
            int X = R.Next(this.Width-D);
            int Y=  R.Next(this.Height-D);
            //實作一個點圖陣
            Bitmap bg = new Bitmap(this.Width, this.Height);
            //建立繪圖物件 將橢圓畫在bg上(實心橢圓)
            //把bg貼到背景裡
            Graphics g = Graphics.FromImage(bg);
            //設定隨機顏色 ARGB A透明度0全透 只寫三個默認RGB
            Color C= Color.FromArgb(R.Next(256), R.Next(256), R.Next(256), R.Next(256));
            //改變筆刷的顏色設定B
            SolidBrush B = new SolidBrush(C);
            g.FillEllipse(B, X, Y, D,D);
            this.BackgroundImage = bg;
        }

    }
}
