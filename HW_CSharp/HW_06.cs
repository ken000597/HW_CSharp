using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HW_CSharp
{
    public partial class HW_06 : Form
    {
        public HW_06()
        {
            InitializeComponent();
        }

        private void HW_06_Load(object sender, EventArgs e)
        {

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

        private void btnIData_Click(object sender, EventArgs e)
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

            ListViewItem newItem = new ListViewItem(name);
            newItem.SubItems.Add(ChinaGrades.ToString());
            newItem.SubItems.Add(MathGrades.ToString());
            newItem.SubItems.Add(EnglishGrades.ToString());
            newItem.SubItems.Add(sumgrades.ToString());
            newItem.SubItems.Add(avggardes2.ToString());
            newItem.SubItems.Add(subjects[maxIndex] + maxGrade.ToString());
            newItem.SubItems.Add(subjects[minIndex] + minGrade.ToString());

            listShow.Items.Insert(0, newItem); // 插入到索引為 0 的位置

            // 其他程式碼...
        }
    

        private void button1_Click(object sender, EventArgs e)
        {
            listSum.Items.Clear(); // 清空 ListSum 中的項目
            listShow.Items.Clear();
        }

        private void btnC1Data_Click(object sender, EventArgs e)
        {
            if (listShow.Items.Count > 0)
            {
                int lastIndex = listShow.Items.Count - 1;
                listShow.Items.RemoveAt(lastIndex);
            }
            else
            {
                MessageBox.Show("請至少輸入一筆資料");
            }
        }

        private void btnSreach_Click(object sender, EventArgs e)
        {
            int minRange = int.Parse(txtMinRange.Text);
            int maxRange = int.Parse(txtMaxRange.Text);
            List<string> studentsInRange = new List<string>();

            foreach (ListViewItem item in listShow.Items)
            {
                int chinaGrade = int.Parse(item.SubItems[1].Text); // 國文成績在第二個子項目（索引為 1）

                if (chinaGrade >= minRange && chinaGrade <= maxRange)
                {
                    string studentName = item.SubItems[0].Text; // 學生姓名在第一個子項目（索引為 0）
                    studentsInRange.Add(studentName);
                }
            }

            listShow.Items.Clear();

            foreach (string studentName in studentsInRange)
            {
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
                ListViewItem item = new ListViewItem(studentName);
                item.SubItems.Add(ChinaGrades.ToString());
                item.SubItems.Add(MathGrades.ToString());
                item.SubItems.Add(EnglishGrades.ToString());
                item.SubItems.Add(sumgrades.ToString());
                item.SubItems.Add(avggardes2.ToString());
                item.SubItems.Add(subjects[maxIndex] + maxGrade.ToString());
                item.SubItems.Add(subjects[minIndex] + minGrade.ToString());
                listShow.Items.Add(item);
            }
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
                btnSData.Enabled = false;
                btnIData.Enabled = false;
                btnC1Data.Enabled = false;

            }
        }
    }

}
