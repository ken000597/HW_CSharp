using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace HW_CSharp
{
    public partial class HW_04 : Form
    {
        public HW_04()
        {
            InitializeComponent();
        }
        private string name;
        private string China;
        private string Math;
        private string English;

  
       

        private void btnMM_Click(object sender, EventArgs e)
        {
            int china = int.Parse(txtChina.Text);
            int math = int.Parse(txtMath.Text);
            int english = int.Parse(txtEnglish.Text);

            string[] subjects = { "國文", "數學", "英文" };
            int[] grade = new int[] { china, math, english };

            // 找出最大值

            int maxGrade = grade.Max();
            int minGrade = grade.Min();
            int maxIndex = Array.IndexOf(grade, maxGrade);
            int minIndex = Array.IndexOf(grade, minGrade);

            listMM.Items.Add(subjects[maxIndex] + "是最高分科目，分數是：" + maxGrade);
            listMM.Items.Add(subjects[minIndex] + "的最低分科目，分數是：" + minGrade);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            name = txtName.Text;
            int china = int.Parse(txtChina.Text);
            int math = int.Parse(txtMath.Text);
            int english = int.Parse(txtEnglish.Text);
            MessageBox.Show("成績已儲存成功！");
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            name = txtName.Text;
            int china = int.Parse(txtChina.Text);
            int math = int.Parse(txtMath.Text);
            int english = int.Parse(txtEnglish.Text);
            listShow.Items.Add("\n姓名：" + name + "\n");
                listShow.Items.Add("\n國文：" + china + "\n");
                listShow.Items.Add("\n數學：" + math + "\n");
                listShow.Items.Add("\n英文：" + english + "\n");
            
        }

        private void HW_04_Load(object sender, EventArgs e)
        {

        }
    }
}
