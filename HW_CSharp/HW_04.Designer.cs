namespace HW_CSharp
{
    partial class HW_04
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtChina = new System.Windows.Forms.TextBox();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.labName = new System.Windows.Forms.Label();
            this.labChina = new System.Windows.Forms.Label();
            this.labMath = new System.Windows.Forms.Label();
            this.labEnglish = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listShow = new System.Windows.Forms.ListBox();
            this.btnMM = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listMM = new System.Windows.Forms.ListBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(220, 93);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 33);
            this.txtName.TabIndex = 2;
            // 
            // txtChina
            // 
            this.txtChina.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtChina.Location = new System.Drawing.Point(220, 131);
            this.txtChina.Name = "txtChina";
            this.txtChina.Size = new System.Drawing.Size(100, 33);
            this.txtChina.TabIndex = 3;
            // 
            // txtMath
            // 
            this.txtMath.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMath.Location = new System.Drawing.Point(220, 184);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(100, 33);
            this.txtMath.TabIndex = 4;
            // 
            // txtEnglish
            // 
            this.txtEnglish.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEnglish.Location = new System.Drawing.Point(220, 241);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(100, 33);
            this.txtEnglish.TabIndex = 5;
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(145, 103);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(52, 21);
            this.labName.TabIndex = 6;
            this.labName.Text = "姓名";
            // 
            // labChina
            // 
            this.labChina.AutoSize = true;
            this.labChina.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labChina.Location = new System.Drawing.Point(145, 141);
            this.labChina.Name = "labChina";
            this.labChina.Size = new System.Drawing.Size(52, 21);
            this.labChina.TabIndex = 7;
            this.labChina.Text = "國文";
            // 
            // labMath
            // 
            this.labMath.AutoSize = true;
            this.labMath.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMath.Location = new System.Drawing.Point(145, 194);
            this.labMath.Name = "labMath";
            this.labMath.Size = new System.Drawing.Size(52, 21);
            this.labMath.TabIndex = 8;
            this.labMath.Text = "數學";
            // 
            // labEnglish
            // 
            this.labEnglish.AutoSize = true;
            this.labEnglish.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEnglish.Location = new System.Drawing.Point(145, 251);
            this.labEnglish.Name = "labEnglish";
            this.labEnglish.Size = new System.Drawing.Size(52, 21);
            this.labEnglish.TabIndex = 9;
            this.labEnglish.Text = "英文";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.listShow);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(348, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 200);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "成績";
            // 
            // listShow
            // 
            this.listShow.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listShow.FormattingEnabled = true;
            this.listShow.ItemHeight = 16;
            this.listShow.Location = new System.Drawing.Point(24, 28);
            this.listShow.Name = "listShow";
            this.listShow.Size = new System.Drawing.Size(324, 148);
            this.listShow.TabIndex = 15;
            // 
            // btnMM
            // 
            this.btnMM.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMM.Location = new System.Drawing.Point(581, 379);
            this.btnMM.Name = "btnMM";
            this.btnMM.Size = new System.Drawing.Size(181, 45);
            this.btnMM.TabIndex = 14;
            this.btnMM.Text = "最高分與最低分";
            this.btnMM.UseVisualStyleBackColor = true;
            this.btnMM.Click += new System.EventHandler(this.btnMM_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.listMM);
            this.groupBox2.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(348, 278);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 95);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "最高分與最低分成績";
            // 
            // listMM
            // 
            this.listMM.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listMM.FormattingEnabled = true;
            this.listMM.ItemHeight = 16;
            this.listMM.Location = new System.Drawing.Point(30, 32);
            this.listMM.Name = "listMM";
            this.listMM.Size = new System.Drawing.Size(313, 36);
            this.listMM.TabIndex = 16;
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShow.Location = new System.Drawing.Point(245, 284);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 31);
            this.btnShow.TabIndex = 17;
            this.btnShow.Text = "顯示成績";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSave.Location = new System.Drawing.Point(147, 284);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 31);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "儲存成績";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // HW_04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HW_CSharp.Properties.Resources.HW04;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnMM);
            this.Controls.Add(this.labEnglish);
            this.Controls.Add(this.labMath);
            this.Controls.Add(this.labChina);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.txtEnglish);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.txtChina);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "HW_04";
            this.Text = "HW_04";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtChina;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labChina;
        private System.Windows.Forms.Label labMath;
        private System.Windows.Forms.Label labEnglish;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMM;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listShow;
        private System.Windows.Forms.ListBox listMM;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnSave;
    }
}