namespace HW_CSharp
{
    partial class HW_01
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HW_01));
            this.txtSex = new System.Windows.Forms.TextBox();
            this.textBloodType = new System.Windows.Forms.TextBox();
            this.txtZodiac = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labSex = new System.Windows.Forms.Label();
            this.labBloodType = new System.Windows.Forms.Label();
            this.labZodiac = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.btnHi = new System.Windows.Forms.Button();
            this.btnhello = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(130, 156);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(100, 22);
            this.txtSex.TabIndex = 19;
            // 
            // textBloodType
            // 
            this.textBloodType.Location = new System.Drawing.Point(130, 109);
            this.textBloodType.Name = "textBloodType";
            this.textBloodType.Size = new System.Drawing.Size(100, 22);
            this.textBloodType.TabIndex = 18;
            // 
            // txtZodiac
            // 
            this.txtZodiac.Location = new System.Drawing.Point(130, 58);
            this.txtZodiac.Name = "txtZodiac";
            this.txtZodiac.Size = new System.Drawing.Size(100, 22);
            this.txtZodiac.TabIndex = 17;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(130, 11);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 16;
            // 
            // labSex
            // 
            this.labSex.AutoSize = true;
            this.labSex.Location = new System.Drawing.Point(34, 166);
            this.labSex.Name = "labSex";
            this.labSex.Size = new System.Drawing.Size(29, 12);
            this.labSex.TabIndex = 15;
            this.labSex.Text = "性別";
            // 
            // labBloodType
            // 
            this.labBloodType.AutoSize = true;
            this.labBloodType.Location = new System.Drawing.Point(34, 119);
            this.labBloodType.Name = "labBloodType";
            this.labBloodType.Size = new System.Drawing.Size(29, 12);
            this.labBloodType.TabIndex = 14;
            this.labBloodType.Text = "血型";
            // 
            // labZodiac
            // 
            this.labZodiac.AutoSize = true;
            this.labZodiac.Location = new System.Drawing.Point(34, 68);
            this.labZodiac.Name = "labZodiac";
            this.labZodiac.Size = new System.Drawing.Size(29, 12);
            this.labZodiac.TabIndex = 13;
            this.labZodiac.Text = "星座";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(34, 21);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(29, 12);
            this.labName.TabIndex = 12;
            this.labName.Text = "姓名";
            // 
            // btnHi
            // 
            this.btnHi.Location = new System.Drawing.Point(130, 222);
            this.btnHi.Name = "btnHi";
            this.btnHi.Size = new System.Drawing.Size(75, 23);
            this.btnHi.TabIndex = 11;
            this.btnHi.Text = "Say Hi";
            this.btnHi.UseVisualStyleBackColor = true;
            this.btnHi.Click += new System.EventHandler(this.btnHi_Click);
            // 
            // btnhello
            // 
            this.btnhello.Location = new System.Drawing.Point(17, 222);
            this.btnhello.Name = "btnhello";
            this.btnhello.Size = new System.Drawing.Size(75, 23);
            this.btnhello.TabIndex = 10;
            this.btnhello.Text = "Say Hello";
            this.btnhello.UseVisualStyleBackColor = true;
            this.btnhello.Click += new System.EventHandler(this.btnhello_Click);
            // 
            // HW_01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.textBloodType);
            this.Controls.Add(this.txtZodiac);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labSex);
            this.Controls.Add(this.labBloodType);
            this.Controls.Add(this.labZodiac);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.btnHi);
            this.Controls.Add(this.btnhello);
            this.Name = "HW_01";
            this.Text = "Hello World";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.TextBox textBloodType;
        private System.Windows.Forms.TextBox txtZodiac;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labSex;
        private System.Windows.Forms.Label labBloodType;
        private System.Windows.Forms.Label labZodiac;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Button btnHi;
        private System.Windows.Forms.Button btnhello;
    }
}

