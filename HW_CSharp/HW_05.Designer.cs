namespace HW_CSharp
{
    partial class HW_05
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
            this.btnRData = new System.Windows.Forms.Button();
            this.btnSData = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnCData = new System.Windows.Forms.Button();
            this.btnRJoint = new System.Windows.Forms.Button();
            this.listSum = new System.Windows.Forms.ListBox();
            this.listShow = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colchinese = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEnglish = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColTolGrades = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAvgGrades = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaxGrades = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMinGrades = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sCHW_05 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.sCHW_05)).BeginInit();
            this.sCHW_05.Panel1.SuspendLayout();
            this.sCHW_05.Panel2.SuspendLayout();
            this.sCHW_05.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(92, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 17;
            // 
            // txtChina
            // 
            this.txtChina.Location = new System.Drawing.Point(92, 50);
            this.txtChina.Name = "txtChina";
            this.txtChina.Size = new System.Drawing.Size(100, 22);
            this.txtChina.TabIndex = 18;
            // 
            // txtMath
            // 
            this.txtMath.Location = new System.Drawing.Point(92, 103);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(100, 22);
            this.txtMath.TabIndex = 19;
            // 
            // txtEnglish
            // 
            this.txtEnglish.Location = new System.Drawing.Point(92, 160);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(100, 22);
            this.txtEnglish.TabIndex = 20;
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(31, 16);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(39, 16);
            this.labName.TabIndex = 21;
            this.labName.Text = "姓名";
            // 
            // labChina
            // 
            this.labChina.AutoSize = true;
            this.labChina.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labChina.Location = new System.Drawing.Point(31, 54);
            this.labChina.Name = "labChina";
            this.labChina.Size = new System.Drawing.Size(39, 16);
            this.labChina.TabIndex = 22;
            this.labChina.Text = "國文";
            // 
            // labMath
            // 
            this.labMath.AutoSize = true;
            this.labMath.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMath.Location = new System.Drawing.Point(31, 107);
            this.labMath.Name = "labMath";
            this.labMath.Size = new System.Drawing.Size(39, 16);
            this.labMath.TabIndex = 23;
            this.labMath.Text = "數學";
            // 
            // labEnglish
            // 
            this.labEnglish.AutoSize = true;
            this.labEnglish.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEnglish.Location = new System.Drawing.Point(31, 164);
            this.labEnglish.Name = "labEnglish";
            this.labEnglish.Size = new System.Drawing.Size(39, 16);
            this.labEnglish.TabIndex = 24;
            this.labEnglish.Text = "英文";
            // 
            // btnRData
            // 
            this.btnRData.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRData.Location = new System.Drawing.Point(92, 239);
            this.btnRData.Name = "btnRData";
            this.btnRData.Size = new System.Drawing.Size(100, 23);
            this.btnRData.TabIndex = 28;
            this.btnRData.Text = "隨機資料";
            this.btnRData.UseVisualStyleBackColor = true;
            this.btnRData.Click += new System.EventHandler(this.btnRData_Click);
            // 
            // btnSData
            // 
            this.btnSData.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSData.Location = new System.Drawing.Point(92, 205);
            this.btnSData.Name = "btnSData";
            this.btnSData.Size = new System.Drawing.Size(100, 23);
            this.btnSData.TabIndex = 29;
            this.btnSData.Text = "加入成績";
            this.btnSData.UseVisualStyleBackColor = true;
            this.btnSData.Click += new System.EventHandler(this.btnSData_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStatistics.Location = new System.Drawing.Point(92, 280);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(100, 23);
            this.btnStatistics.TabIndex = 30;
            this.btnStatistics.Text = "統計資料";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnCData
            // 
            this.btnCData.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCData.Location = new System.Drawing.Point(92, 346);
            this.btnCData.Name = "btnCData";
            this.btnCData.Size = new System.Drawing.Size(100, 23);
            this.btnCData.TabIndex = 31;
            this.btnCData.Text = "清除資料";
            this.btnCData.UseVisualStyleBackColor = true;
            this.btnCData.Click += new System.EventHandler(this.btnCData_Click);
            // 
            // btnRJoint
            // 
            this.btnRJoint.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRJoint.Location = new System.Drawing.Point(92, 385);
            this.btnRJoint.Name = "btnRJoint";
            this.btnRJoint.Size = new System.Drawing.Size(115, 23);
            this.btnRJoint.TabIndex = 32;
            this.btnRJoint.Text = "隨機加入20筆";
            this.btnRJoint.UseVisualStyleBackColor = true;
            this.btnRJoint.Click += new System.EventHandler(this.btnRJoint_Click);
            // 
            // listSum
            // 
            this.listSum.FormattingEnabled = true;
            this.listSum.ItemHeight = 12;
            this.listSum.Location = new System.Drawing.Point(3, 3);
            this.listSum.Name = "listSum";
            this.listSum.Size = new System.Drawing.Size(551, 148);
            this.listSum.TabIndex = 16;
            // 
            // listShow
            // 
            this.listShow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colchinese,
            this.colEnglish,
            this.colMath,
            this.ColTolGrades,
            this.colAvgGrades,
            this.colMaxGrades,
            this.colMinGrades});
            this.listShow.Enabled = false;
            this.listShow.HideSelection = false;
            this.listShow.Location = new System.Drawing.Point(3, 3);
            this.listShow.Name = "listShow";
            this.listShow.Size = new System.Drawing.Size(551, 265);
            this.listShow.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listShow.TabIndex = 35;
            this.listShow.UseCompatibleStateImageBehavior = false;
            this.listShow.View = System.Windows.Forms.View.Details;
            // 
            // colName
            // 
            this.colName.Text = "姓名";
            this.colName.Width = 102;
            // 
            // colchinese
            // 
            this.colchinese.Text = "國文";
            // 
            // colEnglish
            // 
            this.colEnglish.Text = "數學";
            // 
            // colMath
            // 
            this.colMath.Text = "數學";
            // 
            // ColTolGrades
            // 
            this.ColTolGrades.Text = "總分";
            // 
            // colAvgGrades
            // 
            this.colAvgGrades.Text = "平均";
            // 
            // colMaxGrades
            // 
            this.colMaxGrades.Text = "最高分";
            // 
            // colMinGrades
            // 
            this.colMinGrades.Text = "最低分";
            // 
            // sCHW_05
            // 
            this.sCHW_05.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sCHW_05.Location = new System.Drawing.Point(272, 22);
            this.sCHW_05.Name = "sCHW_05";
            this.sCHW_05.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sCHW_05.Panel1
            // 
            this.sCHW_05.Panel1.AutoScroll = true;
            this.sCHW_05.Panel1.Controls.Add(this.listShow);
            // 
            // sCHW_05.Panel2
            // 
            this.sCHW_05.Panel2.Controls.Add(this.listSum);
            this.sCHW_05.Size = new System.Drawing.Size(564, 440);
            this.sCHW_05.SplitterDistance = 275;
            this.sCHW_05.TabIndex = 33;
            // 
            // HW_05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HW_CSharp.Properties.Resources.HW05;
            this.ClientSize = new System.Drawing.Size(985, 523);
            this.Controls.Add(this.sCHW_05);
            this.Controls.Add(this.btnRJoint);
            this.Controls.Add(this.btnCData);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.btnSData);
            this.Controls.Add(this.btnRData);
            this.Controls.Add(this.labEnglish);
            this.Controls.Add(this.labMath);
            this.Controls.Add(this.labChina);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.txtEnglish);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.txtChina);
            this.Controls.Add(this.txtName);
            this.Name = "HW_05";
            this.Text = "Form1";
            this.sCHW_05.Panel1.ResumeLayout(false);
            this.sCHW_05.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sCHW_05)).EndInit();
            this.sCHW_05.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnRData;
        private System.Windows.Forms.Button btnSData;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnCData;
        private System.Windows.Forms.Button btnRJoint;
        private System.Windows.Forms.ListBox listSum;
        private System.Windows.Forms.ListView listShow;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colchinese;
        private System.Windows.Forms.ColumnHeader colEnglish;
        private System.Windows.Forms.ColumnHeader colMath;
        private System.Windows.Forms.ColumnHeader ColTolGrades;
        private System.Windows.Forms.ColumnHeader colAvgGrades;
        private System.Windows.Forms.ColumnHeader colMaxGrades;
        private System.Windows.Forms.ColumnHeader colMinGrades;
        private System.Windows.Forms.SplitContainer sCHW_05;
    }
}