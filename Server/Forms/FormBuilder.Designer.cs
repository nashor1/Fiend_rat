namespace Server.Forms
{
    partial class FormBuilder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuilder));
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label17 = new System.Windows.Forms.Label();
            this.numDelay = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.chkBsod = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxFolder = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuild = new System.Windows.Forms.Button();
            this.chkIcon = new System.Windows.Forms.CheckBox();
            this.txtIcon = new System.Windows.Forms.TextBox();
            this.btnIcon = new System.Windows.Forms.Button();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.btnClone = new System.Windows.Forms.Button();
            this.btnAssembly = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRemoveIP = new System.Windows.Forms.Button();
            this.btnAddIP = new System.Windows.Forms.Button();
            this.textIP = new System.Windows.Forms.TextBox();
            this.listBoxIP = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemovePort = new System.Windows.Forms.Button();
            this.btnAddPort = new System.Windows.Forms.Button();
            this.chkPaste_bin = new System.Windows.Forms.CheckBox();
            this.listBoxPort = new System.Windows.Forms.ListBox();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.txtMutex = new System.Windows.Forms.TextBox();
            this.textFilename = new System.Windows.Forms.TextBox();
            this.txtFileVersion = new System.Windows.Forms.TextBox();
            this.txtProductVersion = new System.Windows.Forms.TextBox();
            this.txtOriginalFilename = new System.Windows.Forms.TextBox();
            this.txtTrademarks = new System.Windows.Forms.TextBox();
            this.txtCopyright = new System.Windows.Forms.TextBox();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.txtPaste_bin = new System.Windows.Forms.TextBox();
            this.chkAnti = new System.Windows.Forms.CheckBox();
            this.chkAntiProcess = new System.Windows.Forms.CheckBox();
            this.btnShellcode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(291, 292);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 18);
            this.label17.TabIndex = 109;
            this.label17.Text = "分组";
            // 
            // numDelay
            // 
            this.numDelay.Location = new System.Drawing.Point(518, 540);
            this.numDelay.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numDelay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDelay.Name = "numDelay";
            this.numDelay.Size = new System.Drawing.Size(84, 28);
            this.numDelay.TabIndex = 108;
            this.numDelay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(291, 543);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(143, 18);
            this.label16.TabIndex = 107;
            this.label16.Text = "开启延迟上线(S)";
            // 
            // chkBsod
            // 
            this.chkBsod.AutoSize = true;
            this.chkBsod.Location = new System.Drawing.Point(470, 321);
            this.chkBsod.Name = "chkBsod";
            this.chkBsod.Size = new System.Drawing.Size(169, 22);
            this.chkBsod.TabIndex = 105;
            this.chkBsod.Text = "BSOD(蓝屏死机?)";
            this.chkBsod.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(291, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 103;
            this.label5.Text = "互相排斥";
            // 
            // comboBoxFolder
            // 
            this.comboBoxFolder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFolder.Enabled = false;
            this.comboBoxFolder.FormattingEnabled = true;
            this.comboBoxFolder.Items.AddRange(new object[] {
            "%AppData%",
            "%Temp%"});
            this.comboBoxFolder.Location = new System.Drawing.Point(734, 470);
            this.comboBoxFolder.Name = "comboBoxFolder";
            this.comboBoxFolder.Size = new System.Drawing.Size(302, 26);
            this.comboBoxFolder.TabIndex = 101;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(644, 372);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 22);
            this.checkBox1.TabIndex = 100;
            this.checkBox1.Text = "启动项";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(640, 472);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 97;
            this.label3.Text = "文件路径:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(640, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 18);
            this.label4.TabIndex = 98;
            this.label4.Text = "文件名字:";
            // 
            // btnBuild
            // 
            this.btnBuild.Location = new System.Drawing.Point(856, 524);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(182, 68);
            this.btnBuild.TabIndex = 95;
            this.btnBuild.Text = "生成exe\r\n";
            this.btnBuild.UseVisualStyleBackColor = true;
            this.btnBuild.Click += new System.EventHandler(this.BtnBuild_Click);
            // 
            // chkIcon
            // 
            this.chkIcon.AutoSize = true;
            this.chkIcon.Location = new System.Drawing.Point(294, 20);
            this.chkIcon.Name = "chkIcon";
            this.chkIcon.Size = new System.Drawing.Size(70, 22);
            this.chkIcon.TabIndex = 94;
            this.chkIcon.Text = "图标";
            this.chkIcon.UseVisualStyleBackColor = true;
            this.chkIcon.CheckedChanged += new System.EventHandler(this.ChkIcon_CheckedChanged);
            // 
            // txtIcon
            // 
            this.txtIcon.Enabled = false;
            this.txtIcon.Location = new System.Drawing.Point(294, 50);
            this.txtIcon.Name = "txtIcon";
            this.txtIcon.Size = new System.Drawing.Size(306, 28);
            this.txtIcon.TabIndex = 93;
            // 
            // btnIcon
            // 
            this.btnIcon.Enabled = false;
            this.btnIcon.Location = new System.Drawing.Point(470, 104);
            this.btnIcon.Name = "btnIcon";
            this.btnIcon.Size = new System.Drawing.Size(132, 57);
            this.btnIcon.TabIndex = 92;
            this.btnIcon.Text = "选择图标";
            this.btnIcon.UseVisualStyleBackColor = true;
            this.btnIcon.Click += new System.EventHandler(this.BtnIcon_Click);
            // 
            // picIcon
            // 
            this.picIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picIcon.ErrorImage = null;
            this.picIcon.InitialImage = null;
            this.picIcon.Location = new System.Drawing.Point(294, 104);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(164, 164);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIcon.TabIndex = 91;
            this.picIcon.TabStop = false;
            // 
            // btnClone
            // 
            this.btnClone.Enabled = false;
            this.btnClone.Location = new System.Drawing.Point(934, 12);
            this.btnClone.Name = "btnClone";
            this.btnClone.Size = new System.Drawing.Size(104, 34);
            this.btnClone.TabIndex = 90;
            this.btnClone.Text = "克隆";
            this.btnClone.UseVisualStyleBackColor = true;
            this.btnClone.Click += new System.EventHandler(this.BtnClone_Click);
            // 
            // btnAssembly
            // 
            this.btnAssembly.AutoSize = true;
            this.btnAssembly.Location = new System.Drawing.Point(644, 18);
            this.btnAssembly.Name = "btnAssembly";
            this.btnAssembly.Size = new System.Drawing.Size(160, 22);
            this.btnAssembly.TabIndex = 89;
            this.btnAssembly.Text = "生成的程序信息";
            this.btnAssembly.UseVisualStyleBackColor = true;
            this.btnAssembly.CheckedChanged += new System.EventHandler(this.BtnAssembly_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(640, 296);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 18);
            this.label14.TabIndex = 82;
            this.label14.Text = "产品版本号:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(640, 334);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 18);
            this.label13.TabIndex = 81;
            this.label13.Text = "文件版本号:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(640, 258);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 18);
            this.label12.TabIndex = 80;
            this.label12.Text = "原始文件名:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(640, 220);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 18);
            this.label11.TabIndex = 79;
            this.label11.Text = "商标:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(640, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 18);
            this.label10.TabIndex = 78;
            this.label10.Text = "版权:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(640, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 18);
            this.label9.TabIndex = 77;
            this.label9.Text = "公司:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(640, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 18);
            this.label7.TabIndex = 75;
            this.label7.Text = "描述:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(640, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 18);
            this.label8.TabIndex = 73;
            this.label8.Text = "产品:";
            // 
            // btnRemoveIP
            // 
            this.btnRemoveIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveIP.Location = new System.Drawing.Point(190, 178);
            this.btnRemoveIP.Name = "btnRemoveIP";
            this.btnRemoveIP.Size = new System.Drawing.Size(44, 33);
            this.btnRemoveIP.TabIndex = 72;
            this.btnRemoveIP.Text = "-";
            this.btnRemoveIP.UseVisualStyleBackColor = true;
            this.btnRemoveIP.Click += new System.EventHandler(this.BtnRemoveIP_Click);
            // 
            // btnAddIP
            // 
            this.btnAddIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddIP.Location = new System.Drawing.Point(72, 178);
            this.btnAddIP.Name = "btnAddIP";
            this.btnAddIP.Size = new System.Drawing.Size(44, 33);
            this.btnAddIP.TabIndex = 71;
            this.btnAddIP.Text = "+";
            this.btnAddIP.UseVisualStyleBackColor = true;
            this.btnAddIP.Click += new System.EventHandler(this.BtnAddIP_Click);
            // 
            // textIP
            // 
            this.textIP.Location = new System.Drawing.Point(72, 16);
            this.textIP.Name = "textIP";
            this.textIP.Size = new System.Drawing.Size(162, 28);
            this.textIP.TabIndex = 69;
            // 
            // listBoxIP
            // 
            this.listBoxIP.FormattingEnabled = true;
            this.listBoxIP.ItemHeight = 18;
            this.listBoxIP.Location = new System.Drawing.Point(72, 46);
            this.listBoxIP.Name = "listBoxIP";
            this.listBoxIP.Size = new System.Drawing.Size(162, 112);
            this.listBoxIP.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 61;
            this.label2.Text = "端口";
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(72, 254);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(162, 28);
            this.textPort.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 18);
            this.label1.TabIndex = 68;
            this.label1.Text = "IP";
            // 
            // btnRemovePort
            // 
            this.btnRemovePort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemovePort.Location = new System.Drawing.Point(190, 418);
            this.btnRemovePort.Name = "btnRemovePort";
            this.btnRemovePort.Size = new System.Drawing.Size(44, 36);
            this.btnRemovePort.TabIndex = 67;
            this.btnRemovePort.Text = "-";
            this.btnRemovePort.UseVisualStyleBackColor = true;
            this.btnRemovePort.Click += new System.EventHandler(this.BtnRemovePort_Click);
            // 
            // btnAddPort
            // 
            this.btnAddPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPort.Location = new System.Drawing.Point(72, 418);
            this.btnAddPort.Name = "btnAddPort";
            this.btnAddPort.Size = new System.Drawing.Size(44, 33);
            this.btnAddPort.TabIndex = 66;
            this.btnAddPort.Text = "+";
            this.btnAddPort.UseVisualStyleBackColor = true;
            this.btnAddPort.Click += new System.EventHandler(this.BtnAddPort_Click);
            // 
            // chkPaste_bin
            // 
            this.chkPaste_bin.AutoSize = true;
            this.chkPaste_bin.Location = new System.Drawing.Point(21, 489);
            this.chkPaste_bin.Name = "chkPaste_bin";
            this.chkPaste_bin.Size = new System.Drawing.Size(124, 22);
            this.chkPaste_bin.TabIndex = 64;
            this.chkPaste_bin.Text = "自动获取IP";
            this.chkPaste_bin.UseVisualStyleBackColor = true;
            this.chkPaste_bin.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // listBoxPort
            // 
            this.listBoxPort.FormattingEnabled = true;
            this.listBoxPort.ItemHeight = 18;
            this.listBoxPort.Location = new System.Drawing.Point(72, 282);
            this.listBoxPort.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.listBoxPort.Name = "listBoxPort";
            this.listBoxPort.Size = new System.Drawing.Size(162, 112);
            this.listBoxPort.TabIndex = 65;
            // 
            // txtGroup
            // 
            this.txtGroup.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Server.Properties.Settings.Default, "Group", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtGroup.Location = new System.Drawing.Point(294, 321);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(163, 28);
            this.txtGroup.TabIndex = 110;
            this.txtGroup.Text = global::Server.Properties.Settings.Default.Group;
            // 
            // txtMutex
            // 
            this.txtMutex.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Server.Properties.Settings.Default, "Mutex", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtMutex.Location = new System.Drawing.Point(294, 400);
            this.txtMutex.Name = "txtMutex";
            this.txtMutex.Size = new System.Drawing.Size(306, 28);
            this.txtMutex.TabIndex = 104;
            this.txtMutex.Text = global::Server.Properties.Settings.Default.Mutex;
            // 
            // textFilename
            // 
            this.textFilename.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Server.Properties.Settings.Default, "Filename", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textFilename.Enabled = false;
            this.textFilename.Location = new System.Drawing.Point(734, 418);
            this.textFilename.Name = "textFilename";
            this.textFilename.Size = new System.Drawing.Size(302, 28);
            this.textFilename.TabIndex = 99;
            this.textFilename.Text = global::Server.Properties.Settings.Default.Filename;
            // 
            // txtFileVersion
            // 
            this.txtFileVersion.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Server.Properties.Settings.Default, "txtFileVersion", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtFileVersion.Enabled = false;
            this.txtFileVersion.Location = new System.Drawing.Point(812, 330);
            this.txtFileVersion.Name = "txtFileVersion";
            this.txtFileVersion.Size = new System.Drawing.Size(224, 28);
            this.txtFileVersion.TabIndex = 88;
            this.txtFileVersion.Text = global::Server.Properties.Settings.Default.txtFileVersion;
            // 
            // txtProductVersion
            // 
            this.txtProductVersion.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Server.Properties.Settings.Default, "txtProductVersion", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtProductVersion.Enabled = false;
            this.txtProductVersion.Location = new System.Drawing.Point(812, 292);
            this.txtProductVersion.Name = "txtProductVersion";
            this.txtProductVersion.Size = new System.Drawing.Size(224, 28);
            this.txtProductVersion.TabIndex = 87;
            this.txtProductVersion.Text = global::Server.Properties.Settings.Default.txtProductVersion;
            // 
            // txtOriginalFilename
            // 
            this.txtOriginalFilename.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Server.Properties.Settings.Default, "txtOriginalFilename", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtOriginalFilename.Enabled = false;
            this.txtOriginalFilename.Location = new System.Drawing.Point(812, 254);
            this.txtOriginalFilename.Name = "txtOriginalFilename";
            this.txtOriginalFilename.Size = new System.Drawing.Size(224, 28);
            this.txtOriginalFilename.TabIndex = 86;
            this.txtOriginalFilename.Text = global::Server.Properties.Settings.Default.txtOriginalFilename;
            // 
            // txtTrademarks
            // 
            this.txtTrademarks.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Server.Properties.Settings.Default, "txtTrademarks", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtTrademarks.Enabled = false;
            this.txtTrademarks.Location = new System.Drawing.Point(812, 216);
            this.txtTrademarks.Name = "txtTrademarks";
            this.txtTrademarks.Size = new System.Drawing.Size(224, 28);
            this.txtTrademarks.TabIndex = 85;
            this.txtTrademarks.Text = global::Server.Properties.Settings.Default.txtTrademarks;
            // 
            // txtCopyright
            // 
            this.txtCopyright.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Server.Properties.Settings.Default, "txtCopyright", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtCopyright.Enabled = false;
            this.txtCopyright.Location = new System.Drawing.Point(812, 178);
            this.txtCopyright.Name = "txtCopyright";
            this.txtCopyright.Size = new System.Drawing.Size(224, 28);
            this.txtCopyright.TabIndex = 84;
            this.txtCopyright.Text = global::Server.Properties.Settings.Default.txtCopyright;
            // 
            // txtCompany
            // 
            this.txtCompany.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Server.Properties.Settings.Default, "txtCompany", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtCompany.Enabled = false;
            this.txtCompany.Location = new System.Drawing.Point(812, 141);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(224, 28);
            this.txtCompany.TabIndex = 83;
            this.txtCompany.Text = global::Server.Properties.Settings.Default.txtCompany;
            // 
            // txtDescription
            // 
            this.txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Server.Properties.Settings.Default, "txtDescription", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtDescription.Enabled = false;
            this.txtDescription.Location = new System.Drawing.Point(812, 104);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(224, 28);
            this.txtDescription.TabIndex = 76;
            this.txtDescription.Text = global::Server.Properties.Settings.Default.txtDescription;
            // 
            // txtProduct
            // 
            this.txtProduct.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Server.Properties.Settings.Default, "ProductName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtProduct.Enabled = false;
            this.txtProduct.Location = new System.Drawing.Point(812, 64);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(224, 28);
            this.txtProduct.TabIndex = 74;
            this.txtProduct.Text = global::Server.Properties.Settings.Default.ProductName;
            // 
            // txtPaste_bin
            // 
            this.txtPaste_bin.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Server.Properties.Settings.Default, "Paste_bin", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtPaste_bin.Enabled = false;
            this.txtPaste_bin.Location = new System.Drawing.Point(21, 540);
            this.txtPaste_bin.Name = "txtPaste_bin";
            this.txtPaste_bin.Size = new System.Drawing.Size(208, 28);
            this.txtPaste_bin.TabIndex = 63;
            this.txtPaste_bin.Text = global::Server.Properties.Settings.Default.Paste_bin;
            // 
            // chkAnti
            // 
            this.chkAnti.AutoSize = true;
            this.chkAnti.Location = new System.Drawing.Point(268, 471);
            this.chkAnti.Margin = new System.Windows.Forms.Padding(4);
            this.chkAnti.Name = "chkAnti";
            this.chkAnti.Size = new System.Drawing.Size(160, 22);
            this.chkAnti.TabIndex = 111;
            this.chkAnti.Text = "禁止虚拟机运行";
            this.chkAnti.UseVisualStyleBackColor = true;
            // 
            // chkAntiProcess
            // 
            this.chkAntiProcess.AutoSize = true;
            this.chkAntiProcess.Location = new System.Drawing.Point(440, 472);
            this.chkAntiProcess.Margin = new System.Windows.Forms.Padding(4);
            this.chkAntiProcess.Name = "chkAntiProcess";
            this.chkAntiProcess.Size = new System.Drawing.Size(160, 22);
            this.chkAntiProcess.TabIndex = 112;
            this.chkAntiProcess.Text = "关闭任务管理器\r\n";
            this.chkAntiProcess.UseVisualStyleBackColor = true;
            // 
            // btnShellcode
            // 
            this.btnShellcode.Location = new System.Drawing.Point(644, 524);
            this.btnShellcode.Margin = new System.Windows.Forms.Padding(4);
            this.btnShellcode.Name = "btnShellcode";
            this.btnShellcode.Size = new System.Drawing.Size(182, 68);
            this.btnShellcode.TabIndex = 113;
            this.btnShellcode.Text = "生成shellcode";
            this.btnShellcode.UseVisualStyleBackColor = true;
            this.btnShellcode.Click += new System.EventHandler(this.btnShellcode_Click);
            // 
            // FormBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 604);
            this.Controls.Add(this.btnShellcode);
            this.Controls.Add(this.chkAntiProcess);
            this.Controls.Add(this.chkAnti);
            this.Controls.Add(this.txtGroup);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.numDelay);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.chkBsod);
            this.Controls.Add(this.txtMutex);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxFolder);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textFilename);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBuild);
            this.Controls.Add(this.chkIcon);
            this.Controls.Add(this.txtIcon);
            this.Controls.Add(this.btnIcon);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.btnClone);
            this.Controls.Add(this.btnAssembly);
            this.Controls.Add(this.txtFileVersion);
            this.Controls.Add(this.txtProductVersion);
            this.Controls.Add(this.txtOriginalFilename);
            this.Controls.Add(this.txtTrademarks);
            this.Controls.Add(this.txtCopyright);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnRemoveIP);
            this.Controls.Add(this.btnAddIP);
            this.Controls.Add(this.textIP);
            this.Controls.Add(this.listBoxIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemovePort);
            this.Controls.Add(this.txtPaste_bin);
            this.Controls.Add(this.btnAddPort);
            this.Controls.Add(this.chkPaste_bin);
            this.Controls.Add(this.listBoxPort);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBuilder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Builder";
            this.Load += new System.EventHandler(this.Builder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown numDelay;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox chkBsod;
        private System.Windows.Forms.TextBox txtMutex;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxFolder;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textFilename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.CheckBox chkIcon;
        private System.Windows.Forms.TextBox txtIcon;
        private System.Windows.Forms.Button btnIcon;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Button btnClone;
        private System.Windows.Forms.CheckBox btnAssembly;
        private System.Windows.Forms.TextBox txtFileVersion;
        private System.Windows.Forms.TextBox txtProductVersion;
        private System.Windows.Forms.TextBox txtOriginalFilename;
        private System.Windows.Forms.TextBox txtTrademarks;
        private System.Windows.Forms.TextBox txtCopyright;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRemoveIP;
        private System.Windows.Forms.Button btnAddIP;
        private System.Windows.Forms.TextBox textIP;
        private System.Windows.Forms.ListBox listBoxIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemovePort;
        private System.Windows.Forms.TextBox txtPaste_bin;
        private System.Windows.Forms.Button btnAddPort;
        private System.Windows.Forms.CheckBox chkPaste_bin;
        private System.Windows.Forms.ListBox listBoxPort;
        private System.Windows.Forms.CheckBox chkAnti;
        private System.Windows.Forms.CheckBox chkAntiProcess;
        private System.Windows.Forms.Button btnShellcode;
    }
}
