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
    public partial class HW_11 : Form
    {
        public HW_11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HW_11_01 Frm_HW11_01 = new HW_11_01();

            Frm_HW11_01.ShowDialog();
        }

        private void btnSS2_Click(object sender, EventArgs e)
        {
            HW_11_02 Frm_HW11_02 = new HW_11_02();

            Frm_HW11_02.ShowDialog();
        }

        private void btnSS3_Click(object sender, EventArgs e)
        {
            HW_11_03 Frm_HW11_03 = new HW_11_03();

            Frm_HW11_03.ShowDialog();
        }
    }
}
