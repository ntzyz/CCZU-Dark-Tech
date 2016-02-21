namespace CCZU_Dark_Tech
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblClasse = new System.Windows.Forms.Label();
            this.tbxClasse = new System.Windows.Forms.TextBox();
            this.tbxMaxID = new System.Windows.Forms.TextBox();
            this.lblMaxID = new System.Windows.Forms.Label();
            this.tbxCourse = new System.Windows.Forms.TextBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnViewPhoto = new System.Windows.Forms.Button();
            this.btnSingleScore = new System.Windows.Forms.Button();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.tbxStudentID = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.queryType = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnGetPageByName = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.llblSrc = new System.Windows.Forms.LinkLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClasse
            // 
            this.lblClasse.AutoSize = true;
            this.lblClasse.Location = new System.Drawing.Point(6, 8);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(53, 12);
            this.lblClasse.TabIndex = 0;
            this.lblClasse.Text = "班级前缀";
            // 
            // tbxClasse
            // 
            this.tbxClasse.Location = new System.Drawing.Point(65, 5);
            this.tbxClasse.Name = "tbxClasse";
            this.tbxClasse.Size = new System.Drawing.Size(135, 21);
            this.tbxClasse.TabIndex = 1;
            // 
            // tbxMaxID
            // 
            this.tbxMaxID.Location = new System.Drawing.Point(65, 32);
            this.tbxMaxID.Name = "tbxMaxID";
            this.tbxMaxID.Size = new System.Drawing.Size(135, 21);
            this.tbxMaxID.TabIndex = 2;
            // 
            // lblMaxID
            // 
            this.lblMaxID.AutoSize = true;
            this.lblMaxID.Location = new System.Drawing.Point(6, 35);
            this.lblMaxID.Name = "lblMaxID";
            this.lblMaxID.Size = new System.Drawing.Size(53, 12);
            this.lblMaxID.TabIndex = 3;
            this.lblMaxID.Text = "最大学号";
            // 
            // tbxCourse
            // 
            this.tbxCourse.Location = new System.Drawing.Point(65, 59);
            this.tbxCourse.Name = "tbxCourse";
            this.tbxCourse.Size = new System.Drawing.Size(135, 21);
            this.tbxCourse.TabIndex = 4;
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(6, 62);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(53, 12);
            this.lblCourse.TabIndex = 5;
            this.lblCourse.Text = "课程代码";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.Location = new System.Drawing.Point(138, 86);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(62, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "狗带";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(8, 114);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(192, 20);
            this.progressBar1.TabIndex = 7;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 11);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(217, 169);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnViewPhoto);
            this.tabPage1.Controls.Add(this.btnSingleScore);
            this.tabPage1.Controls.Add(this.lblStudentID);
            this.tabPage1.Controls.Add(this.tbxStudentID);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(209, 143);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "个人查询";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnViewPhoto
            // 
            this.btnViewPhoto.Location = new System.Drawing.Point(108, 75);
            this.btnViewPhoto.Name = "btnViewPhoto";
            this.btnViewPhoto.Size = new System.Drawing.Size(95, 23);
            this.btnViewPhoto.TabIndex = 3;
            this.btnViewPhoto.Text = "查看个人照片";
            this.btnViewPhoto.UseVisualStyleBackColor = true;
            this.btnViewPhoto.Click += new System.EventHandler(this.btnViewPhoto_Click);
            // 
            // btnSingleScore
            // 
            this.btnSingleScore.Location = new System.Drawing.Point(108, 46);
            this.btnSingleScore.Name = "btnSingleScore";
            this.btnSingleScore.Size = new System.Drawing.Size(95, 23);
            this.btnSingleScore.TabIndex = 2;
            this.btnSingleScore.Text = "查询个人成绩";
            this.btnSingleScore.UseVisualStyleBackColor = true;
            this.btnSingleScore.Click += new System.EventHandler(this.btnSingleScore_Click);
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(6, 22);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(29, 12);
            this.lblStudentID.TabIndex = 1;
            this.lblStudentID.Text = "学号";
            // 
            // tbxStudentID
            // 
            this.tbxStudentID.Location = new System.Drawing.Point(44, 19);
            this.tbxStudentID.Name = "tbxStudentID";
            this.tbxStudentID.Size = new System.Drawing.Size(159, 21);
            this.tbxStudentID.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.queryType);
            this.tabPage2.Controls.Add(this.lblClasse);
            this.tabPage2.Controls.Add(this.btnStart);
            this.tabPage2.Controls.Add(this.progressBar1);
            this.tabPage2.Controls.Add(this.tbxClasse);
            this.tabPage2.Controls.Add(this.tbxMaxID);
            this.tabPage2.Controls.Add(this.lblCourse);
            this.tabPage2.Controls.Add(this.tbxCourse);
            this.tabPage2.Controls.Add(this.lblMaxID);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(209, 143);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "班级查询";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // queryType
            // 
            this.queryType.FormattingEnabled = true;
            this.queryType.Items.AddRange(new object[] {
            "查询全班成绩",
            "查询全班挂科情况"});
            this.queryType.Location = new System.Drawing.Point(8, 88);
            this.queryType.Name = "queryType";
            this.queryType.Size = new System.Drawing.Size(124, 20);
            this.queryType.TabIndex = 8;
            this.queryType.SelectedValueChanged += new System.EventHandler(this.queryType_SelectedValueChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnGetPageByName);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(209, 143);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "按姓名查询";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnGetPageByName
            // 
            this.btnGetPageByName.Location = new System.Drawing.Point(49, 57);
            this.btnGetPageByName.Name = "btnGetPageByName";
            this.btnGetPageByName.Size = new System.Drawing.Size(109, 23);
            this.btnGetPageByName.TabIndex = 0;
            this.btnGetPageByName.Text = "在新页面中打开";
            this.btnGetPageByName.UseVisualStyleBackColor = true;
            this.btnGetPageByName.Click += new System.EventHandler(this.btnGetPageByName_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(154, 185);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "离开";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // llblSrc
            // 
            this.llblSrc.AutoSize = true;
            this.llblSrc.Location = new System.Drawing.Point(10, 190);
            this.llblSrc.Name = "llblSrc";
            this.llblSrc.Size = new System.Drawing.Size(125, 12);
            this.llblSrc.TabIndex = 10;
            this.llblSrc.TabStop = true;
            this.llblSrc.Text = "Source Code && Update";
            this.llblSrc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblSrc_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 216);
            this.ControlBox = false;
            this.Controls.Add(this.llblSrc);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CCZU Dark Tech";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClasse;
        private System.Windows.Forms.TextBox tbxClasse;
        private System.Windows.Forms.TextBox tbxMaxID;
        private System.Windows.Forms.Label lblMaxID;
        private System.Windows.Forms.TextBox tbxCourse;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.LinkLabel llblSrc;
        private System.Windows.Forms.Button btnViewPhoto;
        private System.Windows.Forms.Button btnSingleScore;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.TextBox tbxStudentID;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnGetPageByName;
        private System.Windows.Forms.ComboBox queryType;
    }
}

