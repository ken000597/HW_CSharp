using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_CSharp
{
    public partial class HW_11_01 : Form
    {
        public HW_11_01()
        {
            InitializeComponent();
        }

        private void HW_11_01_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true; // 啟用按鍵預覽
            this.KeyDown += HW_11_01_KeyDown;
            /////////////////////////
            timer1.Start();
        }
        private void HW_11_01_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) // 檢查是否按下 ESC 鍵
            {
                this.Close();
            }
        }
        private void HW_11_01_Click(object sender, EventArgs e)
        {

            this.Close();
        }


        int curP = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            curP += 1;
            if (curP > 20)
            {
                curP = 1;
            }
            switch (curP) 
            {
                case 1:
                    this.BackgroundImage = Properties.Resources.SD01;
                    break;
                case 2:
                    this.BackgroundImage = Properties.Resources.SD02;
                    break;
                case 3:
                    this.BackgroundImage = Properties.Resources.SD03;
                    break;
                case 4:
                    this.BackgroundImage = Properties.Resources.SD04;
                    break;
                case 5:
                    this.BackgroundImage = Properties.Resources.SD05;
                    break;
                case 6:
                    this.BackgroundImage = Properties.Resources.SD06;
                    break;
                case 7:
                    this.BackgroundImage = Properties.Resources.SD07;
                    break;
                case 8:
                    this.BackgroundImage = Properties.Resources.SD08;
                    break;
                case 9:
                    this.BackgroundImage = Properties.Resources.SD09;
                    break;
                case 10:
                    this.BackgroundImage = Properties.Resources.SD10;
                    break;
                case 11:
                    this.BackgroundImage = Properties.Resources.SD11;
                    break;
                case 12:
                    this.BackgroundImage = Properties.Resources.SD12;
                    break;
                case 13:
                    this.BackgroundImage = Properties.Resources.SD13;
                    break;
                case 14:
                    this.BackgroundImage = Properties.Resources.SD14;
                    break;
                case 15:
                    this.BackgroundImage = Properties.Resources.SD15;
                    break;
                case 16:
                    this.BackgroundImage = Properties.Resources.SD16;
                    break;
                case 17:
                    this.BackgroundImage = Properties.Resources.SD17;
                    break;
                case 18:
                    this.BackgroundImage = Properties.Resources.SD18;
                    break;
                case 19:
                    this.BackgroundImage = Properties.Resources.SD19;
                    break;
                case 20:
                    this.BackgroundImage = Properties.Resources.SD20;
                    break;


            }
        }
    }
}
