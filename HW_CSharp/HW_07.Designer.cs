namespace HW_CSharp
{
    partial class HW_07
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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.labNum1 = new System.Windows.Forms.Label();
            this.labNum2 = new System.Windows.Forms.Label();
            this.labAnswers = new System.Windows.Forms.Label();
            this.labAnswer = new System.Windows.Forms.Label();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnCross = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(119, 58);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 22);
            this.txtNum1.TabIndex = 0;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(119, 112);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 22);
            this.txtNum2.TabIndex = 1;
            // 
            // labNum1
            // 
            this.labNum1.AutoSize = true;
            this.labNum1.BackColor = System.Drawing.Color.Transparent;
            this.labNum1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labNum1.Location = new System.Drawing.Point(47, 61);
            this.labNum1.Name = "labNum1";
            this.labNum1.Size = new System.Drawing.Size(66, 24);
            this.labNum1.TabIndex = 2;
            this.labNum1.Text = "Num1";
            // 
            // labNum2
            // 
            this.labNum2.AutoSize = true;
            this.labNum2.BackColor = System.Drawing.Color.Transparent;
            this.labNum2.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labNum2.Location = new System.Drawing.Point(47, 115);
            this.labNum2.Name = "labNum2";
            this.labNum2.Size = new System.Drawing.Size(66, 24);
            this.labNum2.TabIndex = 3;
            this.labNum2.Text = "Num2";
            // 
            // labAnswers
            // 
            this.labAnswers.AutoSize = true;
            this.labAnswers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labAnswers.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labAnswers.Location = new System.Drawing.Point(119, 184);
            this.labAnswers.Name = "labAnswers";
            this.labAnswers.Size = new System.Drawing.Size(102, 26);
            this.labAnswers.TabIndex = 4;
            this.labAnswers.Text = "               ";
            // 
            // labAnswer
            // 
            this.labAnswer.AutoSize = true;
            this.labAnswer.BackColor = System.Drawing.Color.Transparent;
            this.labAnswer.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labAnswer.Location = new System.Drawing.Point(38, 184);
            this.labAnswer.Name = "labAnswer";
            this.labAnswer.Size = new System.Drawing.Size(80, 24);
            this.labAnswer.TabIndex = 5;
            this.labAnswer.Text = "Answer";
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(103, 93);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(75, 23);
            this.btnDivision.TabIndex = 6;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(103, 29);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(75, 23);
            this.btnMinus.TabIndex = 7;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnCross
            // 
            this.btnCross.Location = new System.Drawing.Point(11, 93);
            this.btnCross.Name = "btnCross";
            this.btnCross.Size = new System.Drawing.Size(75, 23);
            this.btnCross.TabIndex = 8;
            this.btnCross.Text = "*";
            this.btnCross.UseVisualStyleBackColor = true;
            this.btnCross.Click += new System.EventHandler(this.btnCross_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(11, 29);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 23);
            this.btnPlus.TabIndex = 9;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPlus);
            this.groupBox1.Controls.Add(this.btnMinus);
            this.groupBox1.Controls.Add(this.btnDivision);
            this.groupBox1.Controls.Add(this.btnCross);
            this.groupBox1.Location = new System.Drawing.Point(256, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 147);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "運算符號";
            // 
            // HW_07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HW_CSharp.Properties.Resources.HW07;
            this.ClientSize = new System.Drawing.Size(548, 307);
            this.Controls.Add(this.labAnswer);
            this.Controls.Add(this.labAnswers);
            this.Controls.Add(this.labNum2);
            this.Controls.Add(this.labNum1);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.groupBox1);
            this.Name = "HW_07";
            this.Tag = "";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label labNum1;
        private System.Windows.Forms.Label labNum2;
        private System.Windows.Forms.Label labAnswers;
        private System.Windows.Forms.Label labAnswer;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnCross;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}