using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HW_CSharp
{
    public partial class HW_07 : Form
    {
        public HW_07()
        {
            InitializeComponent();
        }


        private double Num1; // 將 Num1 定義為類的成員變數，使其在類中的其他方法中可見
        private double Num2; // 將 Num2 定義為類的成員變數，使其在類中的其他方法中可見

        public void define()
        {
            if (string.IsNullOrEmpty(txtNum1.Text))
            {
                MessageBox.Show("請輸入Num1的數字");
                return; // 停止執行後續程式碼
            }
            if (!double.TryParse(txtNum1.Text, out Num1))
            {
                MessageBox.Show("Num1必須是數字");
                return; // 停止執行後續程式碼
            }

            if (string.IsNullOrEmpty(txtNum2.Text))
            {
                MessageBox.Show("請輸入Num2的數字");
                return; // 停止執行後續程式碼
            }
            if (!double.TryParse(txtNum2.Text, out Num2))
            {
                MessageBox.Show("Num2必須是數字");
                return; // 停止執行後續程式碼
            }

        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            define();

            if (Num2 == 0)
            {
                MessageBox.Show("Num2不得為0");
                return;
            }

            double LabAnswers = Num1 / Num2;

            labAnswers.Text = LabAnswers.ToString();

            labAnswers.Text = LabAnswers.ToString().PadRight(15);

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            define();

            double LabAnswers = Num1 + Num2;

            labAnswers.Text = LabAnswers.ToString();

            labAnswers.Text = LabAnswers.ToString().PadRight(15);

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            define();

        
            double LabAnswers = Num1 - Num2;

            labAnswers.Text = LabAnswers.ToString();

            labAnswers.Text = LabAnswers.ToString().PadRight(15);

        }

        private void btnCross_Click(object sender, EventArgs e)
        {
            define();

            double LabAnswers = Num1 * Num2;

            labAnswers.Text = LabAnswers.ToString();

            labAnswers.Text = LabAnswers.ToString().PadRight(15);

        }
    }
}
