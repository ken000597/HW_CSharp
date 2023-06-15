using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_CSharp
{
    public partial class HW_08 : Form
    {
        public HW_08()
        {
            InitializeComponent();
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNotepad.Clear();
        }

        private void 結束ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private string file = "";
        private void 開啟檔案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "Text Files |*.txt";
            if (dr == DialogResult.OK) 
            {
                StreamReader read = new StreamReader(openFileDialog1.FileName);
                read.Close();
                file = openFileDialog1.FileName;
            }

        }

        private void 儲存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = saveFileDialog1.ShowDialog();
            saveFileDialog1.Filter = "Text Files |*.txt";
            if (dr == DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(saveFileDialog1.FileName);
                write.Write(txtNotepad.Text);
                write.Close();
            }
            else 
            {
                try 
                {
                    StreamWriter write = new StreamWriter(saveFileDialog1.FileName);
                    write.Write(txtNotepad.Text);
                    write.Close();
                }
                catch 
                {

                }
            }
        }

        private void 列印ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = printDialog1.ShowDialog();
            if (dr == DialogResult.OK) { }

        }

        private void 復原ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtNotepad.CanUndo == true)
            { 
            txtNotepad.Undo();
            }
        }

        private void 剪下ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtNotepad.SelectedText != "") 
            {
                txtNotepad.Cut();
            }
        }

        private void 複製ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtNotepad.SelectionLength > 0 ) 
            {
                txtNotepad.Copy();
            }
        }

        private void 貼上ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                txtNotepad.Paste();
            }
        }

        private void 刪除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNotepad.Clear(); 
        }

        private void 全選ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNotepad.SelectAll();
        }

        private void 時間日期ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now; 
            txtNotepad.Text = dt.ToString();    
        }

        private void 字形ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = fontDialog1.ShowDialog();
            if (dr == DialogResult.OK) 
            {
                txtNotepad.Font = fontDialog1.Font;
            }



        }

        private void 自動換行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNotepad.WordWrap = !txtNotepad.WordWrap; // 切換 WordWrap 屬性

            自動換行ToolStripMenuItem.Checked = txtNotepad.WordWrap; // 根據 WordWrap 屬性的值設置 Checked 屬性
        }

        private void 關於記事本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("課堂作業Notepad練習");
        }

        private void 放大ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChangeTextSize(2);

        }

        private void 縮小ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeTextSize(-2);
        }

        private void ChangeTextSize(int delta)
        {
            // 調整文字大小
            float newSize = txtNotepad.Font.Size + delta;
            txtNotepad.Font = new Font(txtNotepad.Font.FontFamily, newSize);
        }

        private void 預設ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNotepad.Font = SystemFonts.DefaultFont;

        }
    }
}
