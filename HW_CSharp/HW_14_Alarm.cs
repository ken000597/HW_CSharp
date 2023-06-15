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
    public partial class HW_14_Alarm : Form
    {
        public HW_14_Alarm()
        {
            InitializeComponent();
        }

        private void HW_14_Alarm_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;//1秒

            timer1.Enabled = true;
            label1.Text = DateTime.Now.ToString();
            // 設定 DateTimePicker 初始值為目前時間
            dateTimePicker1.Value = DateTime.Now;

            // 初始化 ComboBox
            InitializeComboBox();

            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
    

    }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
            



        }

        private void InitializeComboBox()
        {
            // 清除 ComboBox 的項目
            cbHour.Items.Clear();
            cbMinute.Items.Clear();

            // 填充小時選項
            for (int i = 0; i < 24; i++)
            {
                cbHour.Items.Add(i.ToString().PadLeft(2, '0')); // 格式化為兩位數，不足補零
            }

            // 填充分鐘選項
            for (int i = 0; i < 60; i++)
            {
                cbMinute.Items.Add(i.ToString().PadLeft(2, '0')); // 格式化為兩位數，不足補零
            }

            // 設定預設選擇項目
            cbHour.SelectedIndex = 0; // 選擇第一個小時
            cbMinute.SelectedIndex = 0; // 選擇第一個分鐘
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 判斷是否達到設定的時間
            int hour = 0;
            int minute = 0;

            int.TryParse(cbHour.Text, out hour);
            int.TryParse(cbMinute.Text, out minute);

            if (DateTime.Now.Hour == hour && DateTime.Now.Minute == minute)
            {
                // 停止 Timer
                timer1.Stop();

                // 彈出訊息框顯示提示
                MessageBox.Show("已達到設定的時間！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}