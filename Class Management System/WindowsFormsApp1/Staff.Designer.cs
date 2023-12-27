namespace WindowsFormsApp1
{
    partial class FormStaff
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
            this.components = new System.ComponentModel.Container();
            this.panelTop = new System.Windows.Forms.Panel();
            this.linkLabelLogout = new System.Windows.Forms.LinkLabel();
            this.materialTabSelectorStaff = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageViewStaff = new System.Windows.Forms.TabPage();
            this.groupBoxStaffAll = new System.Windows.Forms.GroupBox();
            this.tabPageRegStf = new System.Windows.Forms.TabPage();
            this.groupBoxRegStaff = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.materialRadioButton2 = new MaterialSkin.Controls.MaterialRadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialRadioButton1 = new MaterialSkin.Controls.MaterialRadioButton();
            this.subjectStf = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.subjectlbl = new MaterialSkin.Controls.MaterialLabel();
            this.btnSaveStf = new MaterialSkin.Controls.MaterialRaisedButton();
            this.addressStf = new System.Windows.Forms.TextBox();
            this.tpNOStf = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.emailStf = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dateTimePickerRegStf = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDOBStf = new System.Windows.Forms.DateTimePicker();
            this.lastNameStf = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.firstNameStf = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonStudent = new System.Windows.Forms.Button();
            this.buttonClass = new System.Windows.Forms.Button();
            this.buttonStaff = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelTop.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.tabPageViewStaff.SuspendLayout();
            this.tabPageRegStf.SuspendLayout();
            this.groupBoxRegStaff.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Gray;
            this.panelTop.Controls.Add(this.linkLabelLogout);
            this.panelTop.Controls.Add(this.materialTabSelectorStaff);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1181, 108);
            this.panelTop.TabIndex = 8;
            // 
            // linkLabelLogout
            // 
            this.linkLabelLogout.AutoSize = true;
            this.linkLabelLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelLogout.Location = new System.Drawing.Point(1096, 20);
            this.linkLabelLogout.Name = "linkLabelLogout";
            this.linkLabelLogout.Size = new System.Drawing.Size(74, 28);
            this.linkLabelLogout.TabIndex = 4;
            this.linkLabelLogout.TabStop = true;
            this.linkLabelLogout.Text = "Logout";
            this.linkLabelLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogout_LinkClicked);
            // 
            // materialTabSelectorStaff
            // 
            this.materialTabSelectorStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelectorStaff.BaseTabControl = this.materialTabControl1;
            this.materialTabSelectorStaff.Depth = 0;
            this.materialTabSelectorStaff.Location = new System.Drawing.Point(1, 84);
            this.materialTabSelectorStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialTabSelectorStaff.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelectorStaff.Name = "materialTabSelectorStaff";
            this.materialTabSelectorStaff.Size = new System.Drawing.Size(1179, 23);
            this.materialTabSelectorStaff.TabIndex = 3;
            this.materialTabSelectorStaff.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPageViewStaff);
            this.materialTabControl1.Controls.Add(this.tabPageRegStf);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(3, -23);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(945, 546);
            this.materialTabControl1.TabIndex = 1;
            // 
            // tabPageViewStaff
            // 
            this.tabPageViewStaff.BackColor = System.Drawing.Color.White;
            this.tabPageViewStaff.Controls.Add(this.groupBoxStaffAll);
            this.tabPageViewStaff.Location = new System.Drawing.Point(4, 25);
            this.tabPageViewStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageViewStaff.Name = "tabPageViewStaff";
            this.tabPageViewStaff.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageViewStaff.Size = new System.Drawing.Size(937, 517);
            this.tabPageViewStaff.TabIndex = 0;
            this.tabPageViewStaff.Text = "View All Staff";
            // 
            // groupBoxStaffAll
            // 
            this.groupBoxStaffAll.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxStaffAll.Location = new System.Drawing.Point(5, 27);
            this.groupBoxStaffAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxStaffAll.Name = "groupBoxStaffAll";
            this.groupBoxStaffAll.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxStaffAll.Size = new System.Drawing.Size(925, 484);
            this.groupBoxStaffAll.TabIndex = 0;
            this.groupBoxStaffAll.TabStop = false;
            this.groupBoxStaffAll.Text = "Staff";
            // 
            // tabPageRegStf
            // 
            this.tabPageRegStf.BackColor = System.Drawing.Color.White;
            this.tabPageRegStf.Controls.Add(this.groupBoxRegStaff);
            this.tabPageRegStf.Location = new System.Drawing.Point(4, 25);
            this.tabPageRegStf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageRegStf.Name = "tabPageRegStf";
            this.tabPageRegStf.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageRegStf.Size = new System.Drawing.Size(937, 517);
            this.tabPageRegStf.TabIndex = 1;
            this.tabPageRegStf.Text = "Register Staff";
            // 
            // groupBoxRegStaff
            // 
            this.groupBoxRegStaff.Controls.Add(this.groupBox3);
            this.groupBoxRegStaff.Controls.Add(this.groupBox1);
            this.groupBoxRegStaff.Controls.Add(this.subjectStf);
            this.groupBoxRegStaff.Controls.Add(this.subjectlbl);
            this.groupBoxRegStaff.Controls.Add(this.btnSaveStf);
            this.groupBoxRegStaff.Controls.Add(this.addressStf);
            this.groupBoxRegStaff.Controls.Add(this.tpNOStf);
            this.groupBoxRegStaff.Controls.Add(this.emailStf);
            this.groupBoxRegStaff.Controls.Add(this.dateTimePickerRegStf);
            this.groupBoxRegStaff.Controls.Add(this.dateTimePickerDOBStf);
            this.groupBoxRegStaff.Controls.Add(this.lastNameStf);
            this.groupBoxRegStaff.Controls.Add(this.firstNameStf);
            this.groupBoxRegStaff.Controls.Add(this.materialLabel8);
            this.groupBoxRegStaff.Controls.Add(this.materialLabel7);
            this.groupBoxRegStaff.Controls.Add(this.materialLabel6);
            this.groupBoxRegStaff.Controls.Add(this.materialLabel5);
            this.groupBoxRegStaff.Controls.Add(this.materialLabel4);
            this.groupBoxRegStaff.Controls.Add(this.materialLabel3);
            this.groupBoxRegStaff.Controls.Add(this.materialLabel2);
            this.groupBoxRegStaff.Controls.Add(this.materialLabel1);
            this.groupBoxRegStaff.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRegStaff.Location = new System.Drawing.Point(5, 30);
            this.groupBoxRegStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxRegStaff.Name = "groupBoxRegStaff";
            this.groupBoxRegStaff.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxRegStaff.Size = new System.Drawing.Size(928, 495);
            this.groupBoxRegStaff.TabIndex = 0;
            this.groupBoxRegStaff.TabStop = false;
            this.groupBoxRegStaff.Text = "Register";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.materialRadioButton2);
            this.groupBox3.ForeColor = System.Drawing.Color.Transparent;
            this.groupBox3.Location = new System.Drawing.Point(252, 75);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(128, 76);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            // 
            // materialRadioButton2
            // 
            this.materialRadioButton2.AutoSize = true;
            this.materialRadioButton2.Depth = 0;
            this.materialRadioButton2.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialRadioButton2.ForeColor = System.Drawing.Color.Black;
            this.materialRadioButton2.Location = new System.Drawing.Point(4, 26);
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.materialRadioButton1);
            this.groupBox1.ForeColor = System.Drawing.Color.Transparent;
            this.groupBox1.Location = new System.Drawing.Point(100, 75);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(128, 76);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // materialRadioButton1
            // 
            this.materialRadioButton1.AutoSize = true;
            this.materialRadioButton1.Depth = 0;
            this.materialRadioButton1.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialRadioButton1.ForeColor = System.Drawing.Color.Black;
            this.materialRadioButton1.Location = new System.Drawing.Point(7, 26);
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
            // subjectStf
            // 
            this.subjectStf.Depth = 0;
            this.subjectStf.Hint = "";
            this.subjectStf.Location = new System.Drawing.Point(132, 294);
            this.subjectStf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.subjectStf.MouseState = MaterialSkin.MouseState.HOVER;
            this.subjectStf.Name = "subjectStf";
            this.subjectStf.PasswordChar = '\0';
            this.subjectStf.SelectedText = "";
            this.subjectStf.SelectionLength = 0;
            this.subjectStf.SelectionStart = 0;
            this.subjectStf.Size = new System.Drawing.Size(248, 28);
            this.subjectStf.TabIndex = 19;
            this.subjectStf.UseSystemPasswordChar = false;
            // 
            // subjectlbl
            // 
            this.subjectlbl.AutoSize = true;
            this.subjectlbl.Depth = 0;
            this.subjectlbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.subjectlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.subjectlbl.Location = new System.Drawing.Point(19, 298);
            this.subjectlbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.subjectlbl.Name = "subjectlbl";
            this.subjectlbl.Size = new System.Drawing.Size(73, 24);
            this.subjectlbl.TabIndex = 18;
            this.subjectlbl.Text = "Subject";
            // 
            // btnSaveStf
            // 
            this.btnSaveStf.Depth = 0;
            this.btnSaveStf.Location = new System.Drawing.Point(683, 430);
            this.btnSaveStf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveStf.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveStf.Name = "btnSaveStf";
            this.btnSaveStf.Primary = true;
            this.btnSaveStf.Size = new System.Drawing.Size(149, 50);
            this.btnSaveStf.TabIndex = 17;
            this.btnSaveStf.Text = "Save";
            this.btnSaveStf.UseVisualStyleBackColor = true;
            this.btnSaveStf.Click += new System.EventHandler(this.btnSaveStf_Click);
            // 
            // addressStf
            // 
            this.addressStf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addressStf.Location = new System.Drawing.Point(585, 226);
            this.addressStf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addressStf.Multiline = true;
            this.addressStf.Name = "addressStf";
            this.addressStf.Size = new System.Drawing.Size(248, 119);
            this.addressStf.TabIndex = 16;
            // 
            // tpNOStf
            // 
            this.tpNOStf.Depth = 0;
            this.tpNOStf.Hint = "";
            this.tpNOStf.Location = new System.Drawing.Point(585, 158);
            this.tpNOStf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpNOStf.MouseState = MaterialSkin.MouseState.HOVER;
            this.tpNOStf.Name = "tpNOStf";
            this.tpNOStf.PasswordChar = '\0';
            this.tpNOStf.SelectedText = "";
            this.tpNOStf.SelectionLength = 0;
            this.tpNOStf.SelectionStart = 0;
            this.tpNOStf.Size = new System.Drawing.Size(248, 28);
            this.tpNOStf.TabIndex = 15;
            this.tpNOStf.UseSystemPasswordChar = false;
            // 
            // emailStf
            // 
            this.emailStf.Depth = 0;
            this.emailStf.Hint = "";
            this.emailStf.Location = new System.Drawing.Point(132, 162);
            this.emailStf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailStf.MouseState = MaterialSkin.MouseState.HOVER;
            this.emailStf.Name = "emailStf";
            this.emailStf.PasswordChar = '\0';
            this.emailStf.SelectedText = "";
            this.emailStf.SelectionLength = 0;
            this.emailStf.SelectionStart = 0;
            this.emailStf.Size = new System.Drawing.Size(248, 28);
            this.emailStf.TabIndex = 14;
            this.emailStf.UseSystemPasswordChar = false;
            // 
            // dateTimePickerRegStf
            // 
            this.dateTimePickerRegStf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerRegStf.Location = new System.Drawing.Point(180, 223);
            this.dateTimePickerRegStf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerRegStf.Name = "dateTimePickerRegStf";
            this.dateTimePickerRegStf.Size = new System.Drawing.Size(248, 34);
            this.dateTimePickerRegStf.TabIndex = 13;
            // 
            // dateTimePickerDOBStf
            // 
            this.dateTimePickerDOBStf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerDOBStf.Location = new System.Drawing.Point(585, 105);
            this.dateTimePickerDOBStf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerDOBStf.Name = "dateTimePickerDOBStf";
            this.dateTimePickerDOBStf.Size = new System.Drawing.Size(248, 34);
            this.dateTimePickerDOBStf.TabIndex = 12;
            // 
            // lastNameStf
            // 
            this.lastNameStf.Depth = 0;
            this.lastNameStf.Hint = "";
            this.lastNameStf.Location = new System.Drawing.Point(585, 48);
            this.lastNameStf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lastNameStf.MouseState = MaterialSkin.MouseState.HOVER;
            this.lastNameStf.Name = "lastNameStf";
            this.lastNameStf.PasswordChar = '\0';
            this.lastNameStf.SelectedText = "";
            this.lastNameStf.SelectionLength = 0;
            this.lastNameStf.SelectionStart = 0;
            this.lastNameStf.Size = new System.Drawing.Size(248, 28);
            this.lastNameStf.TabIndex = 11;
            this.lastNameStf.UseSystemPasswordChar = false;
            // 
            // firstNameStf
            // 
            this.firstNameStf.Depth = 0;
            this.firstNameStf.Hint = "";
            this.firstNameStf.Location = new System.Drawing.Point(132, 48);
            this.firstNameStf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstNameStf.MouseState = MaterialSkin.MouseState.HOVER;
            this.firstNameStf.Name = "firstNameStf";
            this.firstNameStf.PasswordChar = '\0';
            this.firstNameStf.SelectedText = "";
            this.firstNameStf.SelectionLength = 0;
            this.firstNameStf.SelectionStart = 0;
            this.firstNameStf.Size = new System.Drawing.Size(248, 28);
            this.firstNameStf.TabIndex = 10;
            this.firstNameStf.UseSystemPasswordChar = false;
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
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(443, 103);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(115, 24);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "Date of Birth";
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
            this.materialLabel3.Size = new System.Drawing.Size(70, 24);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Gender";
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
            this.buttonClass.Click += new System.EventHandler(this.buttonClass_Click);
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
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panelContent.Controls.Add(this.materialTabControl1);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(235, 108);
            this.panelContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(946, 525);
            this.panelContent.TabIndex = 10;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 633);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.FormStaff_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.materialTabControl1.ResumeLayout(false);
            this.tabPageViewStaff.ResumeLayout(false);
            this.tabPageRegStf.ResumeLayout(false);
            this.groupBoxRegStaff.ResumeLayout(false);
            this.groupBoxRegStaff.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPageViewStaff;
        private System.Windows.Forms.GroupBox groupBoxStaffAll;
        private System.Windows.Forms.TabPage tabPageRegStf;
        private System.Windows.Forms.GroupBox groupBoxRegStaff;
        private MaterialSkin.Controls.MaterialRaisedButton btnSaveStf;
        private System.Windows.Forms.TextBox addressStf;
        private MaterialSkin.Controls.MaterialSingleLineTextField tpNOStf;
        private MaterialSkin.Controls.MaterialSingleLineTextField emailStf;
        private System.Windows.Forms.DateTimePicker dateTimePickerRegStf;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOBStf;
        private MaterialSkin.Controls.MaterialSingleLineTextField lastNameStf;
        private MaterialSkin.Controls.MaterialSingleLineTextField firstNameStf;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelectorStaff;
        private MaterialSkin.Controls.MaterialSingleLineTextField subjectStf;
        private MaterialSkin.Controls.MaterialLabel subjectlbl;
        private System.Windows.Forms.LinkLabel linkLabelLogout;
        private System.Windows.Forms.GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}