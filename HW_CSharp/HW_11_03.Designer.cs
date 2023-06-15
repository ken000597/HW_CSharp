namespace HW_CSharp
{
    partial class HW_11_03
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PBSS = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PBSS)).BeginInit();
            this.SuspendLayout();
            // 
            // PBSS
            // 
            this.PBSS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PBSS.Image = global::HW_CSharp.Properties.Resources.SS01;
            this.PBSS.Location = new System.Drawing.Point(12, 12);
            this.PBSS.Name = "PBSS";
            this.PBSS.Size = new System.Drawing.Size(278, 285);
            this.PBSS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBSS.TabIndex = 0;
            this.PBSS.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // HW_11_03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(956, 565);
            this.Controls.Add(this.PBSS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HW_11_03";
            this.Text = "HW_11_03";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HW_11_03_Load);
            this.Click += new System.EventHandler(this.HW_11_03_Click);
            ((System.ComponentModel.ISupportInitialize)(this.PBSS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PBSS;
        private System.Windows.Forms.Timer timer1;
    }
}