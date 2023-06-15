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
    public partial class HW_14 : Form
    {
        private Timer timerA;
        private int alarmHour;
        private int alarmMinute;
        public HW_14()
        {
            InitializeComponent();
        }

        private void HW_14_Load(object sender, EventArgs e)
        {
            labTime.Text = DateTime.Now.ToString("HH:mm:ss");
            timerA.Start(); // 停用定時器

        }
        private bool alarmTriggered = false; // 鬧鐘是否已觸發的標記

        private void timer1_Tick(object sender, EventArgs e)
        {
            labTime.Text = DateTime.Now.ToString("HH:mm:ss");

            if (checkBox1.Checked && !alarmTriggered)
            {
                // 檢查鬧鐘時間
                if (DateTime.Now.Hour == alarmHour && DateTime.Now.Minute == alarmMinute)
                {
                    // 在指定的時間觸發鬧鐘
                    MessageBox.Show("鬧鐘時間到了！");
                    alarmTriggered = true; // 標記鬧鐘已觸發
                    checkBox1.Checked = false; // 停用鬧鐘功能
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                alarmHour = int.Parse(cbHours.SelectedItem.ToString());
                alarmMinute = int.Parse(cbMinutes.SelectedItem.ToString());
                alarmTriggered = true; // 標記鬧鐘已觸發

                // 啟動定時器
                timerA = new Timer();
                timerA.Interval = 1000; // 每隔 1 秒觸發一次
                timerA.Tick += timer1_Tick;
                timerA.Start();

                MessageBox.Show("鬧鐘已啟動！");
            }
            else
            {
                // 停止定時器
                timerA.Stop();
                timerA.Dispose();
                timerA = null;
            }
        }
    }
}
