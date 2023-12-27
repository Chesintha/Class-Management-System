namespace WindowsFormsApp1.Properties
{
    partial class FormRegStud
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
            this.label1 = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonStudent = new System.Windows.Forms.Button();
            this.buttonClass = new System.Windows.Forms.Button();
            this.buttonStaff = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialRadioButton1 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialRadioButton2 = new MaterialSkin.Controls.MaterialRadioButton();
            this.firstNameStd = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lastNameStd = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dateTimePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerReg = new System.Windows.Forms.DateTimePicker();
            this.emailStd = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tpNOStd = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.addressStd = new System.Windows.Forms.TextBox();
            this.btnSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panelTop.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Gray;
            this.panelTop.Controls.Add(this.materialTabSelector1);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1182, 108);
            this.panelTop.TabIndex = 8;
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
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(234, 525);
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
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.56695F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.43305F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 167F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(234, 525);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonStudent
            // 
            this.buttonStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonStudent.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStudent.Location = new System.Drawing.Point(3, 3);
            this.buttonStudent.Name = "buttonStudent";
            this.buttonStudent.Size = new System.Drawing.Size(228, 178);
            this.buttonStudent.TabIndex = 3;
            this.buttonStudent.Text = "Manage Students";
            this.buttonStudent.UseVisualStyleBackColor = true;
            // 
            // buttonClass
            // 
            this.buttonClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonClass.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClass.Location = new System.Drawing.Point(3, 360);
            this.buttonClass.Name = "buttonClass";
            this.buttonClass.Size = new System.Drawing.Size(228, 162);
            this.buttonClass.TabIndex = 4;
            this.buttonClass.Text = "Manage Classes";
            this.buttonClass.UseVisualStyleBackColor = true;
            // 
            // buttonStaff
            // 
            this.buttonStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonStaff.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStaff.Location = new System.Drawing.Point(3, 187);
            this.buttonStaff.Name = "buttonStaff";
            this.buttonStaff.Size = new System.Drawing.Size(228, 167);
            this.buttonStaff.TabIndex = 5;
            this.buttonStaff.Text = "Manage Staff";
            this.buttonStaff.UseVisualStyleBackColor = true;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelContent.Controls.Add(this.materialTabControl1);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(234, 108);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(948, 525);
            this.panelContent.TabIndex = 10;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(3, 84);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1179, 23);
            this.materialTabSelector1.TabIndex = 2;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(3, -24);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(945, 546);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(937, 517);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "View All Students";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(937, 517);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Register Student";
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(925, 484);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Students";
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
            this.materialLabel1.Size = new System.Drawing.Size(104, 24);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "First Name";
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
            this.materialLabel2.Size = new System.Drawing.Size(102, 24);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Last Name";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(19, 104);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(70, 24);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Gender";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(443, 104);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(115, 24);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "Date of Birth";
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
            this.materialLabel5.Size = new System.Drawing.Size(58, 24);
            this.materialLabel5.TabIndex = 4;
            this.materialLabel5.Text = "Email";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(443, 162);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(116, 24);
            this.materialLabel6.TabIndex = 5;
            this.materialLabel6.Text = "T.P. Number";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(19, 225);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(155, 24);
            this.materialLabel7.TabIndex = 6;
            this.materialLabel7.Text = "Registration Date";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(443, 225);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(80, 24);
            this.materialLabel8.TabIndex = 7;
            this.materialLabel8.Text = "Address";
            // 
            // materialRadioButton1
            // 
            this.materialRadioButton1.AutoSize = true;
            this.materialRadioButton1.Depth = 0;
            this.materialRadioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.materialRadioButton1.Location = new System.Drawing.Point(102, 104);
            this.materialRadioButton1.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton1.Name = "materialRadioButton1";
            this.materialRadioButton1.Ripple = true;
            this.materialRadioButton1.Size = new System.Drawing.Size(68, 30);
            this.materialRadioButton1.TabIndex = 8;
            this.materialRadioButton1.TabStop = true;
            this.materialRadioButton1.Text = "Male";
            this.materialRadioButton1.UseVisualStyleBackColor = true;
            // 
            // materialRadioButton2
            // 
            this.materialRadioButton2.AutoSize = true;
            this.materialRadioButton2.Depth = 0;
            this.materialRadioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.materialRadioButton2.Location = new System.Drawing.Point(214, 104);
            this.materialRadioButton2.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton2.Name = "materialRadioButton2";
            this.materialRadioButton2.Ripple = true;
            this.materialRadioButton2.Size = new System.Drawing.Size(87, 30);
            this.materialRadioButton2.TabIndex = 9;
            this.materialRadioButton2.TabStop = true;
            this.materialRadioButton2.Text = "Female";
            this.materialRadioButton2.UseVisualStyleBackColor = true;
            // 
            // firstNameStd
            // 
            this.firstNameStd.Depth = 0;
            this.firstNameStd.Hint = "";
            this.firstNameStd.Location = new System.Drawing.Point(132, 48);
            this.firstNameStd.MouseState = MaterialSkin.MouseState.HOVER;
            this.firstNameStd.Name = "firstNameStd";
            this.firstNameStd.PasswordChar = '\0';
            this.firstNameStd.SelectedText = "";
            this.firstNameStd.SelectionLength = 0;
            this.firstNameStd.SelectionStart = 0;
            this.firstNameStd.Size = new System.Drawing.Size(248, 28);
            this.firstNameStd.TabIndex = 10;
            this.firstNameStd.UseSystemPasswordChar = false;
            // 
            // lastNameStd
            // 
            this.lastNameStd.Depth = 0;
            this.lastNameStd.Hint = "";
            this.lastNameStd.Location = new System.Drawing.Point(585, 48);
            this.lastNameStd.MouseState = MaterialSkin.MouseState.HOVER;
            this.lastNameStd.Name = "lastNameStd";
            this.lastNameStd.PasswordChar = '\0';
            this.lastNameStd.SelectedText = "";
            this.lastNameStd.SelectionLength = 0;
            this.lastNameStd.SelectionStart = 0;
            this.lastNameStd.Size = new System.Drawing.Size(248, 28);
            this.lastNameStd.TabIndex = 11;
            this.lastNameStd.UseSystemPasswordChar = false;
            // 
            // dateTimePickerDOB
            // 
            this.dateTimePickerDOB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerDOB.Location = new System.Drawing.Point(585, 105);
            this.dateTimePickerDOB.Name = "dateTimePickerDOB";
            this.dateTimePickerDOB.Size = new System.Drawing.Size(248, 34);
            this.dateTimePickerDOB.TabIndex = 12;
            // 
            // dateTimePickerReg
            // 
            this.dateTimePickerReg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerReg.Location = new System.Drawing.Point(180, 223);
            this.dateTimePickerReg.Name = "dateTimePickerReg";
            this.dateTimePickerReg.Size = new System.Drawing.Size(248, 34);
            this.dateTimePickerReg.TabIndex = 13;
            this.dateTimePickerReg.ValueChanged += new System.EventHandler(this.dateTimePickerReg_ValueChanged);
            // 
            // emailStd
            // 
            this.emailStd.Depth = 0;
            this.emailStd.Hint = "";
            this.emailStd.Location = new System.Drawing.Point(132, 162);
            this.emailStd.MouseState = MaterialSkin.MouseState.HOVER;
            this.emailStd.Name = "emailStd";
            this.emailStd.PasswordChar = '\0';
            this.emailStd.SelectedText = "";
            this.emailStd.SelectionLength = 0;
            this.emailStd.SelectionStart = 0;
            this.emailStd.Size = new System.Drawing.Size(248, 28);
            this.emailStd.TabIndex = 14;
            this.emailStd.UseSystemPasswordChar = false;
            // 
            // tpNOStd
            // 
            this.tpNOStd.Depth = 0;
            this.tpNOStd.Hint = "";
            this.tpNOStd.Location = new System.Drawing.Point(585, 158);
            this.tpNOStd.MouseState = MaterialSkin.MouseState.HOVER;
            this.tpNOStd.Name = "tpNOStd";
            this.tpNOStd.PasswordChar = '\0';
            this.tpNOStd.SelectedText = "";
            this.tpNOStd.SelectionLength = 0;
            this.tpNOStd.SelectionStart = 0;
            this.tpNOStd.Size = new System.Drawing.Size(248, 28);
            this.tpNOStd.TabIndex = 15;
            this.tpNOStd.UseSystemPasswordChar = false;
            // 
            // addressStd
            // 
            this.addressStd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addressStd.Location = new System.Drawing.Point(585, 226);
            this.addressStd.Multiline = true;
            this.addressStd.Name = "addressStd";
            this.addressStd.Size = new System.Drawing.Size(248, 119);
            this.addressStd.TabIndex = 16;
            // 
            // btnSave
            // 
            this.btnSave.Depth = 0;
            this.btnSave.Location = new System.Drawing.Point(683, 429);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = true;
            this.btnSave.Size = new System.Drawing.Size(150, 50);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.addressStd);
            this.groupBox2.Controls.Add(this.tpNOStd);
            this.groupBox2.Controls.Add(this.emailStd);
            this.groupBox2.Controls.Add(this.dateTimePickerReg);
            this.groupBox2.Controls.Add(this.dateTimePickerDOB);
            this.groupBox2.Controls.Add(this.lastNameStd);
            this.groupBox2.Controls.Add(this.firstNameStd);
            this.groupBox2.Controls.Add(this.materialRadioButton2);
            this.groupBox2.Controls.Add(this.materialRadioButton1);
            this.groupBox2.Controls.Add(this.materialLabel8);
            this.groupBox2.Controls.Add(this.materialLabel7);
            this.groupBox2.Controls.Add(this.materialLabel6);
            this.groupBox2.Controls.Add(this.materialLabel5);
            this.groupBox2.Controls.Add(this.materialLabel4);
            this.groupBox2.Controls.Add(this.materialLabel3);
            this.groupBox2.Controls.Add(this.materialLabel2);
            this.groupBox2.Controls.Add(this.materialLabel1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(928, 495);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Register";
            // 
            // FormRegStud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 633);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.Name = "FormRegStud";
            this.Text = "Students";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialRaisedButton btnSave;
        private System.Windows.Forms.TextBox addressStd;
        private MaterialSkin.Controls.MaterialSingleLineTextField tpNOStd;
        private MaterialSkin.Controls.MaterialSingleLineTextField emailStd;
        private System.Windows.Forms.DateTimePicker dateTimePickerReg;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOB;
        private MaterialSkin.Controls.MaterialSingleLineTextField lastNameStd;
        private MaterialSkin.Controls.MaterialSingleLineTextField firstNameStd;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton2;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}