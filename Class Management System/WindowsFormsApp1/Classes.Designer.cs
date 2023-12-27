namespace WindowsFormsApp1
{
    partial class FormClasses
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.materialTabSelectorStaff = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControlAddClass = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageViewCls = new System.Windows.Forms.TabPage();
            this.groupBoxClassAll = new System.Windows.Forms.GroupBox();
            this.tabPageRegCls = new System.Windows.Forms.TabPage();
            this.groupBoxAddClass = new System.Windows.Forms.GroupBox();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.teacher = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.year = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.grade = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.subName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPageAttendance = new System.Windows.Forms.TabPage();
            this.groupBoxAttendance = new System.Windows.Forms.GroupBox();
            this.linkLabelLogout = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonStudent = new System.Windows.Forms.Button();
            this.buttonClass = new System.Windows.Forms.Button();
            this.buttonStaff = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.materialTabControlAddClass.SuspendLayout();
            this.tabPageViewCls.SuspendLayout();
            this.tabPageRegCls.SuspendLayout();
            this.groupBoxAddClass.SuspendLayout();
            this.tabPageAttendance.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Gray;
            this.panelTop.Controls.Add(this.materialTabSelectorStaff);
            this.panelTop.Controls.Add(this.linkLabelLogout);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1181, 108);
            this.panelTop.TabIndex = 8;
            // 
            // materialTabSelectorStaff
            // 
            this.materialTabSelectorStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelectorStaff.BaseTabControl = this.materialTabControlAddClass;
            this.materialTabSelectorStaff.Depth = 0;
            this.materialTabSelectorStaff.Location = new System.Drawing.Point(3, 85);
            this.materialTabSelectorStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialTabSelectorStaff.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelectorStaff.Name = "materialTabSelectorStaff";
            this.materialTabSelectorStaff.Size = new System.Drawing.Size(1179, 23);
            this.materialTabSelectorStaff.TabIndex = 4;
            this.materialTabSelectorStaff.Text = "materialTabSelector1";
            // 
            // materialTabControlAddClass
            // 
            this.materialTabControlAddClass.Controls.Add(this.tabPageViewCls);
            this.materialTabControlAddClass.Controls.Add(this.tabPageRegCls);
            this.materialTabControlAddClass.Controls.Add(this.tabPageAttendance);
            this.materialTabControlAddClass.Depth = 0;
            this.materialTabControlAddClass.Location = new System.Drawing.Point(3, -23);
            this.materialTabControlAddClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialTabControlAddClass.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControlAddClass.Name = "materialTabControlAddClass";
            this.materialTabControlAddClass.SelectedIndex = 0;
            this.materialTabControlAddClass.Size = new System.Drawing.Size(945, 546);
            this.materialTabControlAddClass.TabIndex = 1;
            // 
            // tabPageViewCls
            // 
            this.tabPageViewCls.BackColor = System.Drawing.Color.White;
            this.tabPageViewCls.Controls.Add(this.groupBoxClassAll);
            this.tabPageViewCls.Location = new System.Drawing.Point(4, 25);
            this.tabPageViewCls.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageViewCls.Name = "tabPageViewCls";
            this.tabPageViewCls.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageViewCls.Size = new System.Drawing.Size(937, 517);
            this.tabPageViewCls.TabIndex = 0;
            this.tabPageViewCls.Text = "View All Classes";
            // 
            // groupBoxClassAll
            // 
            this.groupBoxClassAll.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxClassAll.Location = new System.Drawing.Point(5, 27);
            this.groupBoxClassAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxClassAll.Name = "groupBoxClassAll";
            this.groupBoxClassAll.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxClassAll.Size = new System.Drawing.Size(925, 484);
            this.groupBoxClassAll.TabIndex = 0;
            this.groupBoxClassAll.TabStop = false;
            this.groupBoxClassAll.Text = "Classes";
            this.groupBoxClassAll.Enter += new System.EventHandler(this.groupBoxClassAll_Enter);
            // 
            // tabPageRegCls
            // 
            this.tabPageRegCls.BackColor = System.Drawing.Color.White;
            this.tabPageRegCls.Controls.Add(this.groupBoxAddClass);
            this.tabPageRegCls.Location = new System.Drawing.Point(4, 25);
            this.tabPageRegCls.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageRegCls.Name = "tabPageRegCls";
            this.tabPageRegCls.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageRegCls.Size = new System.Drawing.Size(937, 517);
            this.tabPageRegCls.TabIndex = 1;
            this.tabPageRegCls.Text = "Add Class";
            // 
            // groupBoxAddClass
            // 
            this.groupBoxAddClass.Controls.Add(this.comboBoxMonth);
            this.groupBoxAddClass.Controls.Add(this.teacher);
            this.groupBoxAddClass.Controls.Add(this.year);
            this.groupBoxAddClass.Controls.Add(this.btnAdd);
            this.groupBoxAddClass.Controls.Add(this.grade);
            this.groupBoxAddClass.Controls.Add(this.subName);
            this.groupBoxAddClass.Controls.Add(this.materialLabel5);
            this.groupBoxAddClass.Controls.Add(this.materialLabel4);
            this.groupBoxAddClass.Controls.Add(this.materialLabel3);
            this.groupBoxAddClass.Controls.Add(this.materialLabel2);
            this.groupBoxAddClass.Controls.Add(this.materialLabel1);
            this.groupBoxAddClass.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAddClass.Location = new System.Drawing.Point(5, 30);
            this.groupBoxAddClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxAddClass.Name = "groupBoxAddClass";
            this.groupBoxAddClass.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxAddClass.Size = new System.Drawing.Size(928, 495);
            this.groupBoxAddClass.TabIndex = 0;
            this.groupBoxAddClass.TabStop = false;
            this.groupBoxAddClass.Text = "Add Class";
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.comboBoxMonth.Location = new System.Drawing.Point(132, 150);
            this.comboBoxMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(248, 36);
            this.comboBoxMonth.TabIndex = 20;
            // 
            // teacher
            // 
            this.teacher.Depth = 0;
            this.teacher.Hint = "";
            this.teacher.Location = new System.Drawing.Point(132, 100);
            this.teacher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.teacher.MouseState = MaterialSkin.MouseState.HOVER;
            this.teacher.Name = "teacher";
            this.teacher.PasswordChar = '\0';
            this.teacher.SelectedText = "";
            this.teacher.SelectionLength = 0;
            this.teacher.SelectionStart = 0;
            this.teacher.Size = new System.Drawing.Size(248, 28);
            this.teacher.TabIndex = 19;
            this.teacher.UseSystemPasswordChar = false;
            // 
            // year
            // 
            this.year.Depth = 0;
            this.year.Hint = "";
            this.year.Location = new System.Drawing.Point(585, 100);
            this.year.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.year.MouseState = MaterialSkin.MouseState.HOVER;
            this.year.Name = "year";
            this.year.PasswordChar = '\0';
            this.year.SelectedText = "";
            this.year.SelectionLength = 0;
            this.year.SelectionStart = 0;
            this.year.Size = new System.Drawing.Size(248, 28);
            this.year.TabIndex = 18;
            this.year.UseSystemPasswordChar = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Depth = 0;
            this.btnAdd.Location = new System.Drawing.Point(683, 398);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Primary = true;
            this.btnAdd.Size = new System.Drawing.Size(149, 50);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grade
            // 
            this.grade.Depth = 0;
            this.grade.Hint = "";
            this.grade.Location = new System.Drawing.Point(585, 48);
            this.grade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grade.MouseState = MaterialSkin.MouseState.HOVER;
            this.grade.Name = "grade";
            this.grade.PasswordChar = '\0';
            this.grade.SelectedText = "";
            this.grade.SelectionLength = 0;
            this.grade.SelectionStart = 0;
            this.grade.Size = new System.Drawing.Size(248, 28);
            this.grade.TabIndex = 11;
            this.grade.UseSystemPasswordChar = false;
            // 
            // subName
            // 
            this.subName.Depth = 0;
            this.subName.Hint = "";
            this.subName.Location = new System.Drawing.Point(132, 48);
            this.subName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.subName.MouseState = MaterialSkin.MouseState.HOVER;
            this.subName.Name = "subName";
            this.subName.PasswordChar = '\0';
            this.subName.SelectedText = "";
            this.subName.SelectionLength = 0;
            this.subName.SelectionStart = 0;
            this.subName.Size = new System.Drawing.Size(248, 28);
            this.subName.TabIndex = 10;
            this.subName.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(19, 162);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(64, 24);
            this.materialLabel5.TabIndex = 4;
            this.materialLabel5.Text = "Month";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(443, 103);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(47, 24);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "Year";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(19, 103);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(99, 24);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Teacher ID";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(443, 48);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(60, 24);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Grade";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(19, 48);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(73, 24);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Subject";
            // 
            // tabPageAttendance
            // 
            this.tabPageAttendance.Controls.Add(this.groupBoxAttendance);
            this.tabPageAttendance.Location = new System.Drawing.Point(4, 25);
            this.tabPageAttendance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageAttendance.Name = "tabPageAttendance";
            this.tabPageAttendance.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageAttendance.Size = new System.Drawing.Size(937, 517);
            this.tabPageAttendance.TabIndex = 2;
            this.tabPageAttendance.Text = "Attendance";
            this.tabPageAttendance.UseVisualStyleBackColor = true;
            // 
            // groupBoxAttendance
            // 
            this.groupBoxAttendance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAttendance.Location = new System.Drawing.Point(5, 25);
            this.groupBoxAttendance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxAttendance.Name = "groupBoxAttendance";
            this.groupBoxAttendance.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxAttendance.Size = new System.Drawing.Size(925, 484);
            this.groupBoxAttendance.TabIndex = 1;
            this.groupBoxAttendance.TabStop = false;
            this.groupBoxAttendance.Text = "Attendance";
            // 
            // linkLabelLogout
            // 
            this.linkLabelLogout.AutoSize = true;
            this.linkLabelLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelLogout.Location = new System.Drawing.Point(1085, 9);
            this.linkLabelLogout.Name = "linkLabelLogout";
            this.linkLabelLogout.Size = new System.Drawing.Size(74, 28);
            this.linkLabelLogout.TabIndex = 2;
            this.linkLabelLogout.TabStop = true;
            this.linkLabelLogout.Text = "Logout";
            this.linkLabelLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogout_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(561, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Class Management System";
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.LightGray;
            this.panelLeft.Controls.Add(this.tableLayoutPanel1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 108);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(235, 525);
            this.panelLeft.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.buttonStudent, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonClass, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonStaff, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.56695F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.43305F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 167F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(235, 525);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonStudent
            // 
            this.buttonStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonStudent.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStudent.Location = new System.Drawing.Point(3, 2);
            this.buttonStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStudent.Name = "buttonStudent";
            this.buttonStudent.Size = new System.Drawing.Size(229, 180);
            this.buttonStudent.TabIndex = 3;
            this.buttonStudent.Text = "Manage Students";
            this.buttonStudent.UseVisualStyleBackColor = true;
            this.buttonStudent.Click += new System.EventHandler(this.buttonStudent_Click);
            // 
            // buttonClass
            // 
            this.buttonClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonClass.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClass.Location = new System.Drawing.Point(3, 359);
            this.buttonClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClass.Name = "buttonClass";
            this.buttonClass.Size = new System.Drawing.Size(229, 164);
            this.buttonClass.TabIndex = 4;
            this.buttonClass.Text = "Manage Classes";
            this.buttonClass.UseVisualStyleBackColor = true;
            // 
            // buttonStaff
            // 
            this.buttonStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonStaff.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStaff.Location = new System.Drawing.Point(3, 186);
            this.buttonStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStaff.Name = "buttonStaff";
            this.buttonStaff.Size = new System.Drawing.Size(229, 169);
            this.buttonStaff.TabIndex = 5;
            this.buttonStaff.Text = "Manage Staff";
            this.buttonStaff.UseVisualStyleBackColor = true;
            this.buttonStaff.Click += new System.EventHandler(this.buttonStaff_Click);
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panelContent.Controls.Add(this.materialTabControlAddClass);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(235, 108);
            this.panelContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(946, 525);
            this.panelContent.TabIndex = 10;
            // 
            // FormClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 633);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormClasses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Classes";
            this.Load += new System.EventHandler(this.FormClasses_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.materialTabControlAddClass.ResumeLayout(false);
            this.tabPageViewCls.ResumeLayout(false);
            this.tabPageRegCls.ResumeLayout(false);
            this.groupBoxAddClass.ResumeLayout(false);
            this.groupBoxAddClass.PerformLayout();
            this.tabPageAttendance.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonStudent;
        private System.Windows.Forms.Button buttonClass;
        private System.Windows.Forms.Button buttonStaff;
        private System.Windows.Forms.Panel panelContent;
        private MaterialSkin.Controls.MaterialTabControl materialTabControlAddClass;
        private System.Windows.Forms.TabPage tabPageViewCls;
        private System.Windows.Forms.GroupBox groupBoxClassAll;
        private System.Windows.Forms.TabPage tabPageRegCls;
        private System.Windows.Forms.GroupBox groupBoxAddClass;
        private MaterialSkin.Controls.MaterialRaisedButton btnAdd;
        private MaterialSkin.Controls.MaterialSingleLineTextField grade;
        private MaterialSkin.Controls.MaterialSingleLineTextField subName;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TabPage tabPageAttendance;
        private System.Windows.Forms.ComboBox comboBoxMonth;
        private MaterialSkin.Controls.MaterialSingleLineTextField teacher;
        private MaterialSkin.Controls.MaterialSingleLineTextField year;
        private System.Windows.Forms.GroupBox groupBoxAttendance;
        private System.Windows.Forms.LinkLabel linkLabelLogout;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelectorStaff;
    }
}