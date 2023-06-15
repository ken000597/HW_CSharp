namespace HW_CSharp
{
    partial class HW_02_01
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
            this.labYears = new System.Windows.Forms.Label();
            this.labMoney = new System.Windows.Forms.Label();
            this.labRate = new System.Windows.Forms.Label();
            this.labFM = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.txtYears = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtFM = new System.Windows.Forms.TextBox();
            this.btnMM = new System.Windows.Forms.Button();
            this.btnTM = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labYears
            // 
            this.labYears.AutoSize = true;
            this.labYears.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labYears.Location = new System.Drawing.Point(44, 56);
            this.labYears.Name = "labYears";
            this.labYears.Size = new System.Drawing.Size(106, 24);
            this.labYears.TabIndex = 0;
            this.labYears.Text = "還款年限";
            // 
            // labMoney
            // 
            this.labMoney.AutoSize = true;
            this.labMoney.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMoney.Location = new System.Drawing.Point(44, 19);
            this.labMoney.Name = "labMoney";
            this.labMoney.Size = new System.Drawing.Size(106, 24);
            this.labMoney.TabIndex = 1;
            this.labMoney.Text = "房子金額";
            // 
            // labRate
            // 
            this.labRate.AutoSize = true;
            this.labRate.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labRate.Location = new System.Drawing.Point(67, 93);
            this.labRate.Name = "labRate";
            this.labRate.Size = new System.Drawing.Size(58, 24);
            this.labRate.TabIndex = 2;
            this.labRate.Text = "利率";
            // 
            // labFM
            // 
            this.labFM.AutoSize = true;
            this.labFM.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labFM.Location = new System.Drawing.Point(55, 126);
            this.labFM.Name = "labFM";
            this.labFM.Size = new System.Drawing.Size(82, 24);
            this.labFM.TabIndex = 3;
            this.labFM.Text = "頭期款";
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(214, 19);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(100, 22);
            this.txtMoney.TabIndex = 4;
            // 
            // txtYears
            // 
            this.txtYears.Location = new System.Drawing.Point(214, 62);
            this.txtYears.Name = "txtYears";
            this.txtYears.Size = new System.Drawing.Size(100, 22);
            this.txtYears.TabIndex = 5;
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(214, 99);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(100, 22);
            this.txtRate.TabIndex = 6;
            // 
            // txtFM
            // 
            this.txtFM.Location = new System.Drawing.Point(214, 132);
            this.txtFM.Name = "txtFM";
            this.txtFM.Size = new System.Drawing.Size(100, 22);
            this.txtFM.TabIndex = 7;
            // 
            // btnMM
            // 
            this.btnMM.Location = new System.Drawing.Point(38, 204);
            this.btnMM.Name = "btnMM";
            this.btnMM.Size = new System.Drawing.Size(75, 23);
            this.btnMM.TabIndex = 8;
            this.btnMM.Text = "PMT月付";
            this.btnMM.UseVisualStyleBackColor = true;
            this.btnMM.Click += new System.EventHandler(this.btnMM_Click);
            // 
            // btnTM
            // 
            this.btnTM.Location = new System.Drawing.Point(132, 204);
            this.btnTM.Name = "btnTM";
            this.btnTM.Size = new System.Drawing.Size(75, 23);
            this.btnTM.TabIndex = 9;
            this.btnTM.Text = "總額";
            this.btnTM.UseVisualStyleBackColor = true;
            this.btnTM.Click += new System.EventHandler(this.btnTM_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(239, 204);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 23);
            this.btnReport.TabIndex = 10;
            this.btnReport.Text = "表單";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // HW_02_01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HW_CSharp.Properties.Resources.HL;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnTM);
            this.Controls.Add(this.btnMM);
            this.Controls.Add(this.txtFM);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtYears);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.labFM);
            this.Controls.Add(this.labRate);
            this.Controls.Add(this.labMoney);
            this.Controls.Add(this.labYears);
            this.Name = "HW_02_01";
            this.Text = "Laon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labYears;
        private System.Windows.Forms.Label labMoney;
        private System.Windows.Forms.Label labRate;
        private System.Windows.Forms.Label labFM;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.TextBox txtYears;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtFM;
        private System.Windows.Forms.Button btnMM;
        private System.Windows.Forms.Button btnTM;
        private System.Windows.Forms.Button btnReport;
    }
}