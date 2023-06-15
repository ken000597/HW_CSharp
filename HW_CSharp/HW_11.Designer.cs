namespace HW_CSharp
{
    partial class HW_11
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
            this.btnSS1 = new System.Windows.Forms.Button();
            this.btnSS2 = new System.Windows.Forms.Button();
            this.btnSS3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSS1
            // 
            this.btnSS1.Location = new System.Drawing.Point(116, 44);
            this.btnSS1.Name = "btnSS1";
            this.btnSS1.Size = new System.Drawing.Size(134, 23);
            this.btnSS1.TabIndex = 0;
            this.btnSS1.Text = "Screen Saver1";
            this.btnSS1.UseVisualStyleBackColor = true;
            this.btnSS1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSS2
            // 
            this.btnSS2.Location = new System.Drawing.Point(116, 117);
            this.btnSS2.Name = "btnSS2";
            this.btnSS2.Size = new System.Drawing.Size(134, 23);
            this.btnSS2.TabIndex = 1;
            this.btnSS2.Text = "Screen Saver2";
            this.btnSS2.UseVisualStyleBackColor = true;
            this.btnSS2.Click += new System.EventHandler(this.btnSS2_Click);
            // 
            // btnSS3
            // 
            this.btnSS3.Location = new System.Drawing.Point(116, 187);
            this.btnSS3.Name = "btnSS3";
            this.btnSS3.Size = new System.Drawing.Size(134, 23);
            this.btnSS3.TabIndex = 2;
            this.btnSS3.Text = "Screen Saver3";
            this.btnSS3.UseVisualStyleBackColor = true;
            this.btnSS3.Click += new System.EventHandler(this.btnSS3_Click);
            // 
            // HW_11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 274);
            this.Controls.Add(this.btnSS3);
            this.Controls.Add(this.btnSS2);
            this.Controls.Add(this.btnSS1);
            this.Name = "HW_11";
            this.Text = "HW11";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSS1;
        private System.Windows.Forms.Button btnSS2;
        private System.Windows.Forms.Button btnSS3;
    }
}