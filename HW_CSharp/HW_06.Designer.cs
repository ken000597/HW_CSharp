namespace HW_CSharp
{
    partial class HW_06
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
            this.sCHW_05 = new System.Windows.Forms.SplitContainer();
            this.listShow = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listSum = new System.Windows.Forms.ListBox();
            this.btnSreach = new System.Windows.Forms.Button();
            this.btnC1Data = new System.Windows.Forms.Button();
            this.btnSData = new System.Windows.Forms.Button();
            this.btnIData = new System.Windows.Forms.Button();
            this.labEnglish = new System.Windows.Forms.Label();
            this.labMath = new System.Windows.Forms.Label();
            this.labChina = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.txtChina = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnCAllData = new System.Windows.Forms.Button();
            this.labSearch = new System.Windows.Forms.Label();
            this.txtMinRange = new System.Windows.Forms.TextBox();
            this.txtMaxRange = new System.Windows.Forms.TextBox();
            this.labdesh = new System.Windows.Forms.Label();
            this.btnStatistics = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sCHW_05)).BeginInit();
            this.sCHW_05.Panel1.SuspendLayout();
            this.sCHW_05.Panel2.SuspendLayout();
            this.sCHW_05.SuspendLayout();
            this.SuspendLayout();
            // 
            // sCHW_05
            // 
            this.sCHW_05.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sCHW_05.Location = new System.Drawing.Point(248, 12);
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
            this.sCHW_05.Size = new System.Drawing.Size(520, 440);
            this.sCHW_05.SplitterDistance = 275;
            this.sCHW_05.TabIndex = 47;
            // 
            // listShow
            // 
            this.listShow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listShow.HideSelection = false;
            this.listShow.Location = new System.Drawing.Point(14, 6);
            this.listShow.Name = "listShow";
            this.listShow.Size = new System.Drawing.Size(486, 262);
            this.listShow.TabIndex = 36;
            this.listShow.UseCompatibleStateImageBehavior = false;
            this.listShow.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "姓名";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "國文";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "數學";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "英文";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "總分";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "平均";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "最高分";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "最低分";
            // 
            // listSum
            // 
            this.listSum.FormattingEnabled = true;
            this.listSum.ItemHeight = 12;
            this.listSum.Location = new System.Drawing.Point(14, 3);
            this.listSum.Name = "listSum";
            this.listSum.Size = new System.Drawing.Size(486, 148);
            this.listSum.TabIndex = 16;
            // 
            // btnSreach
            // 
            this.btnSreach.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSreach.Location = new System.Drawing.Point(77, 402);
            this.btnSreach.Name = "btnSreach";
            this.btnSreach.Size = new System.Drawing.Size(87, 23);
            this.btnSreach.TabIndex = 46;
            this.btnSreach.Text = "SREACH";
            this.btnSreach.UseVisualStyleBackColor = true;
            this.btnSreach.Click += new System.EventHandler(this.btnSreach_Click);
            // 
            // btnC1Data
            // 
            this.btnC1Data.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnC1Data.Location = new System.Drawing.Point(84, 285);
            this.btnC1Data.Name = "btnC1Data";
            this.btnC1Data.Size = new System.Drawing.Size(94, 25);
            this.btnC1Data.TabIndex = 45;
            this.btnC1Data.Text = "清除資料";
            this.btnC1Data.UseVisualStyleBackColor = true;
            this.btnC1Data.Click += new System.EventHandler(this.btnC1Data_Click);
            // 
            // btnSData
            // 
            this.btnSData.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSData.Location = new System.Drawing.Point(84, 222);
            this.btnSData.Name = "btnSData";
            this.btnSData.Size = new System.Drawing.Size(94, 25);
            this.btnSData.TabIndex = 43;
            this.btnSData.Text = "加入成績";
            this.btnSData.UseVisualStyleBackColor = true;
            this.btnSData.Click += new System.EventHandler(this.btnSData_Click);
            // 
            // btnIData
            // 
            this.btnIData.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnIData.Location = new System.Drawing.Point(84, 256);
            this.btnIData.Name = "btnIData";
            this.btnIData.Size = new System.Drawing.Size(94, 25);
            this.btnIData.TabIndex = 42;
            this.btnIData.Text = "插入成績";
            this.btnIData.UseVisualStyleBackColor = true;
            this.btnIData.Click += new System.EventHandler(this.btnIData_Click);
            // 
            // labEnglish
            // 
            this.labEnglish.AutoSize = true;
            this.labEnglish.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEnglish.Location = new System.Drawing.Point(34, 187);
            this.labEnglish.Name = "labEnglish";
            this.labEnglish.Size = new System.Drawing.Size(41, 16);
            this.labEnglish.TabIndex = 41;
            this.labEnglish.Text = "英文";
            // 
            // labMath
            // 
            this.labMath.AutoSize = true;
            this.labMath.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMath.Location = new System.Drawing.Point(34, 130);
            this.labMath.Name = "labMath";
            this.labMath.Size = new System.Drawing.Size(41, 16);
            this.labMath.TabIndex = 40;
            this.labMath.Text = "數學";
            // 
            // labChina
            // 
            this.labChina.AutoSize = true;
            this.labChina.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labChina.Location = new System.Drawing.Point(34, 77);
            this.labChina.Name = "labChina";
            this.labChina.Size = new System.Drawing.Size(41, 16);
            this.labChina.TabIndex = 39;
            this.labChina.Text = "國文";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(34, 39);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(41, 16);
            this.labName.TabIndex = 38;
            this.labName.Text = "姓名";
            // 
            // txtEnglish
            // 
            this.txtEnglish.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEnglish.Location = new System.Drawing.Point(84, 177);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(100, 27);
            this.txtEnglish.TabIndex = 37;
            // 
            // txtMath
            // 
            this.txtMath.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMath.Location = new System.Drawing.Point(84, 120);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(100, 27);
            this.txtMath.TabIndex = 36;
            // 
            // txtChina
            // 
            this.txtChina.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtChina.Location = new System.Drawing.Point(84, 67);
            this.txtChina.Name = "txtChina";
            this.txtChina.Size = new System.Drawing.Size(100, 27);
            this.txtChina.TabIndex = 35;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(84, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 27);
            this.txtName.TabIndex = 34;
            // 
            // btnCAllData
            // 
            this.btnCAllData.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCAllData.Location = new System.Drawing.Point(72, 314);
            this.btnCAllData.Name = "btnCAllData";
            this.btnCAllData.Size = new System.Drawing.Size(119, 25);
            this.btnCAllData.TabIndex = 48;
            this.btnCAllData.Text = "清除全部資料";
            this.btnCAllData.UseVisualStyleBackColor = true;
            this.btnCAllData.Click += new System.EventHandler(this.button1_Click);
            // 
            // labSearch
            // 
            this.labSearch.AutoSize = true;
            this.labSearch.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labSearch.Location = new System.Drawing.Point(69, 355);
            this.labSearch.Name = "labSearch";
            this.labSearch.Size = new System.Drawing.Size(109, 16);
            this.labSearch.TabIndex = 49;
            this.labSearch.Text = "搜尋國文成績";
            // 
            // txtMinRange
            // 
            this.txtMinRange.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMinRange.Location = new System.Drawing.Point(69, 374);
            this.txtMinRange.Name = "txtMinRange";
            this.txtMinRange.Size = new System.Drawing.Size(37, 27);
            this.txtMinRange.TabIndex = 50;
            // 
            // txtMaxRange
            // 
            this.txtMaxRange.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMaxRange.Location = new System.Drawing.Point(127, 374);
            this.txtMaxRange.Name = "txtMaxRange";
            this.txtMaxRange.Size = new System.Drawing.Size(37, 27);
            this.txtMaxRange.TabIndex = 51;
            // 
            // labdesh
            // 
            this.labdesh.AutoSize = true;
            this.labdesh.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labdesh.Location = new System.Drawing.Point(112, 379);
            this.labdesh.Name = "labdesh";
            this.labdesh.Size = new System.Drawing.Size(13, 16);
            this.labdesh.TabIndex = 52;
            this.labdesh.Text = "-";
            // 
            // btnStatistics
            // 
            this.btnStatistics.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStatistics.Location = new System.Drawing.Point(72, 452);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(92, 23);
            this.btnStatistics.TabIndex = 53;
            this.btnStatistics.Text = "各科統計";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // HW_06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HW_CSharp.Properties.Resources.HW06;
            this.ClientSize = new System.Drawing.Size(830, 508);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.labdesh);
            this.Controls.Add(this.txtMaxRange);
            this.Controls.Add(this.txtMinRange);
            this.Controls.Add(this.labSearch);
            this.Controls.Add(this.btnCAllData);
            this.Controls.Add(this.sCHW_05);
            this.Controls.Add(this.btnSreach);
            this.Controls.Add(this.btnC1Data);
            this.Controls.Add(this.btnSData);
            this.Controls.Add(this.btnIData);
            this.Controls.Add(this.labEnglish);
            this.Controls.Add(this.labMath);
            this.Controls.Add(this.labChina);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.txtEnglish);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.txtChina);
            this.Controls.Add(this.txtName);
            this.Name = "HW_06";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.HW_06_Load);
            this.sCHW_05.Panel1.ResumeLayout(false);
            this.sCHW_05.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sCHW_05)).EndInit();
            this.sCHW_05.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer sCHW_05;
        private System.Windows.Forms.ListBox listSum;
        private System.Windows.Forms.Button btnSreach;
        private System.Windows.Forms.Button btnC1Data;
        private System.Windows.Forms.Button btnSData;
        private System.Windows.Forms.Button btnIData;
        private System.Windows.Forms.Label labEnglish;
        private System.Windows.Forms.Label labMath;
        private System.Windows.Forms.Label labChina;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.TextBox txtChina;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnCAllData;
        private System.Windows.Forms.Label labSearch;
        private System.Windows.Forms.TextBox txtMinRange;
        private System.Windows.Forms.TextBox txtMaxRange;
        private System.Windows.Forms.Label labdesh;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.ListView listShow;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}