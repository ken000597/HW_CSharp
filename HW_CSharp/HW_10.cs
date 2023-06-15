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
    public partial class HW_10 : Form
    {
        private PictureBox pictureBox;  // 主要的 PictureBox 控制項

        public HW_10()
        {
            InitializeComponent();
        }

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

                PictureBox clickedPictureBox = (PictureBox)sender; // 取得被點擊的PictureBox

                Form pictureBoxForm = new Form();
                pictureBoxForm.Text = "彈出Form";
                pictureBoxForm.StartPosition = FormStartPosition.CenterParent;

                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = new Bitmap(clickedPictureBox.Image);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Dock = DockStyle.Fill;

                pictureBoxForm.Controls.Add(pictureBox);

                // 綁定Closed事件處理程式，當Form被關閉時釋放資源
                pictureBoxForm.Closed += (s, args) => pictureBox.Dispose();

                pictureBoxForm.Show();

            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = (PictureBox)sender; // 取得被點擊的PictureBox

            Form pictureBoxForm = new Form();
            pictureBoxForm.Text = "彈出Form";
            pictureBoxForm.StartPosition = FormStartPosition.CenterParent;

            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = new Bitmap(clickedPictureBox.Image);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Dock = DockStyle.Fill;

            pictureBoxForm.Controls.Add(pictureBox);

            // 綁定Closed事件處理程式，當Form被關閉時釋放資源
            pictureBoxForm.Closed += (s, args) => pictureBox.Dispose();

            pictureBoxForm.Show();
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = (PictureBox)sender; // 取得被點擊的PictureBox

            Form pictureBoxForm = new Form();
            pictureBoxForm.Text = "彈出Form";
            pictureBoxForm.StartPosition = FormStartPosition.CenterParent;

            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = new Bitmap(clickedPictureBox.Image);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Dock = DockStyle.Fill;

            pictureBoxForm.Controls.Add(pictureBox);

            // 綁定Closed事件處理程式，當Form被關閉時釋放資源
            pictureBoxForm.Closed += (s, args) => pictureBox.Dispose();

            pictureBoxForm.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = (PictureBox)sender; // 取得被點擊的PictureBox

            Form pictureBoxForm = new Form();
            pictureBoxForm.Text = "彈出Form";
            pictureBoxForm.StartPosition = FormStartPosition.CenterParent;

            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = new Bitmap(clickedPictureBox.Image);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Dock = DockStyle.Fill;

            pictureBoxForm.Controls.Add(pictureBox);

            // 綁定Closed事件處理程式，當Form被關閉時釋放資源
            pictureBoxForm.Closed += (s, args) => pictureBox.Dispose();

            pictureBoxForm.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = (PictureBox)sender; // 取得被點擊的PictureBox

            Form pictureBoxForm = new Form();
            pictureBoxForm.Text = "彈出Form";
            pictureBoxForm.StartPosition = FormStartPosition.CenterParent;

            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = new Bitmap(clickedPictureBox.Image);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Dock = DockStyle.Fill;

            pictureBoxForm.Controls.Add(pictureBox);

            // 綁定Closed事件處理程式，當Form被關閉時釋放資源
            pictureBoxForm.Closed += (s, args) => pictureBox.Dispose();

            pictureBoxForm.Show();
        }

        
    }
}