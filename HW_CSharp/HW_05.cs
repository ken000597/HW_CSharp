using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace HW_CSharp
{
    public partial class HW_05 : Form
    {
        public HW_05()
        {
            InitializeComponent();
        }

                     

        private void btnSData_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("請輸入姓名");
                return; // 停止執行後續程式碼
            }
            if (string.IsNullOrEmpty(txtChina.Text))
            {
                MessageBox.Show("請輸入國文成績");
                return; // 停止執行後續程式碼
            }
            if (!int.TryParse(txtChina.Text, out int chinaGrade))
            {
                MessageBox.Show("國文成績必須為數字");
                return; // 停止執行後續程式碼
            }
            if (string.IsNullOrEmpty(txtMath.Text))
            {
                MessageBox.Show("請輸入數學成績");
                return; // 停止執行後續程式碼
            }
            if (!int.TryParse(txtMath.Text, out int mathGrade))
            {
                MessageBox.Show("數學成績必須為數字");
                return; // 停止執行後續程式碼
            }
            if (string.IsNullOrEmpty(txtEnglish.Text))
            {
                MessageBox.Show("請輸入英文成績");
                return; // 停止執行後續程式碼
            }
            if (!int.TryParse(txtEnglish.Text, out int englishGrade))
            {
                MessageBox.Show("英文成績必須為數字");
                return; // 停止執行後續程式碼
            }
            string name = txtName.Text;
            int ChinaGrades = int.Parse(txtChina.Text);
            int MathGrades = int.Parse(txtMath.Text);
            int EnglishGrades = int.Parse(txtEnglish.Text);

            string[] subjects = { "國文", "數學", "英文" };
            int[] grades = { ChinaGrades, MathGrades, EnglishGrades };

            int sumgrades = grades.Sum();
            double avggardes1 = (double)sumgrades / grades.Length;
            double avggardes2 = Math.Round(avggardes1, 2);

            int maxGrade = grades.Max();
            int minGrade = grades.Min();
            int maxIndex = Array.IndexOf(grades, maxGrade);
            int minIndex = Array.IndexOf(grades, minGrade); 

            ListViewItem item = new ListViewItem(name);
            item.SubItems.Add(ChinaGrades.ToString());
            item.SubItems.Add(MathGrades.ToString());
            item.SubItems.Add(EnglishGrades.ToString());
            item.SubItems.Add(sumgrades.ToString());
            item.SubItems.Add(avggardes2.ToString());
            item.SubItems.Add(subjects[maxIndex] + maxGrade.ToString());
            item.SubItems.Add(subjects[minIndex] + minGrade.ToString());
            listShow.Items.Add(item);
        }





        int count = 1; // 計數器變數，起始值為 1

        private void btnRData_Click(object sender, EventArgs e)
        {


            Random RandomR = new Random();
            string nameR = "S" + count.ToString(); // 根據計數器生成學生編號
            count++; // 計數器增加
            int ChinaR = RandomR.Next(101); // 生成介於 0 到 100 之間的隨機數字
            int MathR = RandomR.Next(101); // 生成介於 0 到 100 之間的隨機數字
            int EnglishR = RandomR.Next(101); // 生成介於 0 到 100 之間的隨機數字
            int[] grades = { ChinaR, MathR, EnglishR };
            int sumgradesR = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                sumgradesR += grades[i];
            }
            double avggardesR = (double)sumgradesR / grades.Length;
            double avggardesR1 = Math.Round(avggardesR, 2);
            string[] subjects = { "國文", "數學", "英文" };
            int maxGrade = grades.Max();
            int minGrade = grades.Min();
            int maxIndex = Array.IndexOf(grades, maxGrade);
            int minIndex = Array.IndexOf(grades, minGrade);
            ListViewItem item = new ListViewItem(nameR);
            item.SubItems.Add(ChinaR.ToString());
            item.SubItems.Add(MathR.ToString());
            item.SubItems.Add(EnglishR.ToString());
            item.SubItems.Add(sumgradesR.ToString());
            item.SubItems.Add(avggardesR1.ToString());
            item.SubItems.Add(subjects[maxIndex] + maxGrade.ToString());
            item.SubItems.Add(subjects[minIndex] + minGrade.ToString());
            listShow.Items.Add(item);



        }

        private void btnCData_Click(object sender, EventArgs e)
        {
          
                listShow.Items.Clear(); 

            listSum.Items.Clear(); // 清空 ListSum 中的項目

        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            if (listShow.Items.Count <= 1)
            {
                MessageBox.Show("請至少輸入一筆資料");
                return;
            }
            else
            {
                List<int> chineseGrades = new List<int>();
                List<int> mathGrades = new List<int>();
                List<int> englishGrades = new List<int>();

                bool isFirstRow = true;

                foreach (ListViewItem item in listShow.Items)
                {
                    if (isFirstRow)
                    {
                        isFirstRow = false;
                        continue; // 跳過表頭行
                    }

                    int chineseGrade = int.Parse(item.SubItems[1].Text); // 國文成績在第二個子項（索引為 1）
                    int mathGrade = int.Parse(item.SubItems[2].Text); // 數學成績在第三個子項（索引為 2）
                    int englishGrade = int.Parse(item.SubItems[3].Text); // 英文成績在第四個子項（索引為 3）

                    // 將成績加入到對應的列表中
                    mathGrades.Add(mathGrade);
                    englishGrades.Add(englishGrade);
                    chineseGrades.Add(chineseGrade);
                }

                int totalChineseGrade = chineseGrades.Sum();
                int totalMathGrade = mathGrades.Sum();
                int totalEnglishGrade = englishGrades.Sum();

                double avgChineseGrade = Math.Round(chineseGrades.Average(), 2);
                double avgMathGrade = Math.Round(mathGrades.Average(), 2);
                double avgEnglishGrade = Math.Round(englishGrades.Average(), 2);

                int maxChineseGrade = chineseGrades.Max();
                int minChineseGrade = chineseGrades.Min();
                int maxMathGrade = mathGrades.Max();
                int minMathGrade = mathGrades.Min();
                int maxEnglishGrade = englishGrades.Max();
                int minEnglishGrade = englishGrades.Min();

                listSum.Items.Clear(); // 清除舊的資料
                listSum.Items.Add("國文總分：" + totalChineseGrade + "  平均成績：" + avgChineseGrade + "  最高分：" + maxChineseGrade + "  最低分：" + minChineseGrade);
                listSum.Items.Add("數學總分：" + totalMathGrade + "  平均成績：" + avgMathGrade + "  最高分：" + maxMathGrade + "  最低分：" + minMathGrade);
                listSum.Items.Add("英文總分：" + totalEnglishGrade + "  平均成績：" + avgEnglishGrade + "  最高分：" + maxEnglishGrade + "  最低分：" + minEnglishGrade);
            }
        }




        ///////////////////////////////////////////////////



    

    private void btnRJoint_Click(object sender, EventArgs e)
        {

            Random RandomR = new Random();

            for (int j = 0; j < 20; j++)
            {
                string name = "S" + count.ToString("D2"); // 根據計數器生成學生編號
                count++; // 計數器增加
                int ChinaR = RandomR.Next(101); // 生成介於 0 到 100 之間的隨機數字
                int MathR = RandomR.Next(101); // 生成介於 0 到 100 之間的隨機數字
                int EnglishR = RandomR.Next(101); // 生成介於 0 到 100 之間的隨機數字
                int[] grades = { ChinaR, MathR, EnglishR };
                int sumgradesR = 0;
                for (int i = 0; i < grades.Length; i++)
                {
                    sumgradesR += grades[i];
                }
                double avggardesR = (double)sumgradesR / grades.Length;
                double avggardesR1 = Math.Round(avggardesR, 2);
                string[] subjects = { "國文", "數學", "英文" };
                int maxGrade = grades.Max();
                int minGrade = grades.Min();
                int maxIndex = Array.IndexOf(grades, maxGrade);
                int minIndex = Array.IndexOf(grades, minGrade);
                ListViewItem item = new ListViewItem(name);
                item.SubItems.Add(ChinaR.ToString());
                item.SubItems.Add(MathR.ToString());
                item.SubItems.Add(EnglishR.ToString());
                item.SubItems.Add(sumgradesR.ToString());
                item.SubItems.Add(avggardesR1.ToString());
                item.SubItems.Add(subjects[maxIndex] + maxGrade.ToString());
                item.SubItems.Add(subjects[minIndex] + minGrade.ToString());
                listShow.Items.Add(item);
            }
        }
    }
}
