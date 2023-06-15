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
    public partial class HW_01 : Form
    {
        public HW_01()
        {
            InitializeComponent();
        }

        private string Name1;
        private string BT;
        private string Zodiac;
        private string Sex;

        private void btnhello_Click(object sender, EventArgs e)
        {
         MessageBox.Show("Hello，我是：" + Name1 + "\n血型是：" + BT + "\n星座是：" + Zodiac + "\n性別是：" + Sex);
        }

        private void btnHi_Click(object sender, EventArgs e)
        {
           MessageBox.Show("Hi，我是：" + Name1 + "\n血型是：" + BT + "\n星座是：" + Zodiac + "\n性別是：" + Sex);
        }
    }
}
