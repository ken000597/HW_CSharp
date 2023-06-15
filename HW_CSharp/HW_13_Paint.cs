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
    public partial class HW_13_Paint : Form
    {


        public HW_13_Paint()
        {
            InitializeComponent();
           
        }

        private void 開新檔案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(800, 600);
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);             
        }

        private void 開啟舊檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK) { pictureBox1.Load(openFileDialog1.FileName); }
        }

        private void 另存新檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Image);
                bmp.Save(saveFileDialog1.FileName);
            }
        }

        private void 結束ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();    
        }

        private void 色彩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        if(colorDialog1.ShowDialog() == DialogResult.OK)
        色彩ToolStripMenuItem.BackColor = colorDialog1.Color;  
   }

        private void 筆刷ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trackBar1.Visible = true; // 顯示 TrackBar
            label1.Visible = true;

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int value = trackBar1.Value;
            label1.Text = value.ToString();
        }

        private void HW_13_Paint_Load(object sender, EventArgs e)
        {
            //隱藏lable1
            label1.Visible = false;
            int value = trackBar1.Value;
            label1.Text = value.ToString();
            開新檔案ToolStripMenuItem_Click(sender, e);
        }
        private int trackBarValue; // 用於保存 trackBar 的數值
        private bool isTrackBarVisible; // 追蹤 trackBar 是否可見

        private void trackBar1_MouseDown(object sender, MouseEventArgs e)
        {
            isTrackBarVisible = true; // 標記 trackBar 為可見狀態
        }

        private void HW_13_Paint_MouseDown(object sender, MouseEventArgs e)
        {
           
            trackBar1.Hide(); // 點擊其他地方時隱藏 trackBar
            label1.Hide();  
        }

        //座標定義


        int x0, y0;
        int lastX, lastY;

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            x0 = e.X;
            y0 = e.Y;
            lastX = e.X;
            lastY = e.Y;

            trackBar1.Hide(); // 點擊其他地方時隱藏 trackBar
            label1.Hide();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Graphics g = Graphics.FromImage(pictureBox1.Image);
                Pen p = new Pen(colorDialog1.Color, int.Parse(label1.Text));

                g.DrawLine(p, lastX, lastY, e.X, e.Y);
                lastX = e.X;
                lastY = e.Y;
                pictureBox1.Refresh();
            }
        }



    }
}
