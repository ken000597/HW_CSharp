namespace HW_CSharp
{
    partial class HW_12
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
            this.StartButton = new System.Windows.Forms.Button();
            this.labtitles = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.Transparent;
            this.StartButton.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.StartButton.Location = new System.Drawing.Point(170, 291);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(230, 66);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Guess Numbers";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // labtitles
            // 
            this.labtitles.AutoSize = true;
            this.labtitles.BackColor = System.Drawing.Color.Transparent;
            this.labtitles.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labtitles.Location = new System.Drawing.Point(129, 9);
            this.labtitles.Name = "labtitles";
            this.labtitles.Size = new System.Drawing.Size(310, 47);
            this.labtitles.TabIndex = 1;
            this.labtitles.Text = "終極密碼(1~100)";
            // 
            // HW_12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HW_CSharp.Properties.Resources.HW12;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(607, 538);
            this.Controls.Add(this.labtitles);
            this.Controls.Add(this.StartButton);
            this.Name = "HW_12";
            this.Text = "HW12";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label labtitles;
    }
}