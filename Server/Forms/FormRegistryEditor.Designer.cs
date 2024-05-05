﻿using Server.Helper;

namespace Server.Forms
{
    partial class FormRegistryEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistryEditor));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.selectedStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyBinaryDataToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyNewtoolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.newToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.keyToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.stringValueToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryValueToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dWORD32bitValueToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.qWORD64bitValueToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.multiStringValueToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.expandableStringValueToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.imageRegistryDirectoryList = new System.Windows.Forms.ImageList(this.components);
            this.hName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageRegistryKeyTypeList = new System.Windows.Forms.ImageList(this.components);
            this.tv_ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.stringValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dWORD32bitValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qWORD64bitValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiStringValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expandableStringValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedItem_ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyBinaryDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lst_ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.keyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.stringValueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryValueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dWORD32bitValueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.qWORD64bitValueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.multiStringValueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.expandableStringValueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.tv_ContextMenuStrip.SuspendLayout();
            this.selectedItem_ContextMenuStrip.SuspendLayout();
            this.lst_ContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.splitContainer, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.statusStrip, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.menuStrip, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1176, 842);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(4, 42);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Size = new System.Drawing.Size(1168, 763);
            this.splitContainer.SplitterDistance = 388;
            this.splitContainer.SplitterWidth = 6;
            this.splitContainer.TabIndex = 0;
            // 
            // statusStrip
            // 
            this.statusStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectedStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 809);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip.Size = new System.Drawing.Size(1176, 33);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip";
            // 
            // selectedStripStatusLabel
            // 
            this.selectedStripStatusLabel.Name = "selectedStripStatusLabel";
            this.selectedStripStatusLabel.Size = new System.Drawing.Size(0, 26);
            // 
            // menuStrip
            // 
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(132, 32);
            this.menuStrip.TabIndex = 2;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.fileToolStripMenuItem.Text = "文件";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 34);
            this.exitToolStripMenuItem.Text = "退出";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.menuStripExit_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifyToolStripMenuItem1,
            this.modifyBinaryDataToolStripMenuItem1,
            this.modifyNewtoolStripSeparator,
            this.newToolStripMenuItem2,
            this.toolStripSeparator6,
            this.deleteToolStripMenuItem2,
            this.renameToolStripMenuItem2});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.editToolStripMenuItem.Text = "编辑";
            this.editToolStripMenuItem.DropDownOpening += new System.EventHandler(this.editToolStripMenuItem_DropDownOpening);
            // 
            // modifyToolStripMenuItem1
            // 
            this.modifyToolStripMenuItem1.Enabled = false;
            this.modifyToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyToolStripMenuItem1.Name = "modifyToolStripMenuItem1";
            this.modifyToolStripMenuItem1.Size = new System.Drawing.Size(253, 34);
            this.modifyToolStripMenuItem1.Text = "修改？...";
            this.modifyToolStripMenuItem1.Visible = false;
            this.modifyToolStripMenuItem1.Click += new System.EventHandler(this.modifyRegistryValue_Click);
            // 
            // modifyBinaryDataToolStripMenuItem1
            // 
            this.modifyBinaryDataToolStripMenuItem1.Enabled = false;
            this.modifyBinaryDataToolStripMenuItem1.Name = "modifyBinaryDataToolStripMenuItem1";
            this.modifyBinaryDataToolStripMenuItem1.Size = new System.Drawing.Size(253, 34);
            this.modifyBinaryDataToolStripMenuItem1.Text = "修改二进制数据... ";
            this.modifyBinaryDataToolStripMenuItem1.Visible = false;
            this.modifyBinaryDataToolStripMenuItem1.Click += new System.EventHandler(this.modifyBinaryDataRegistryValue_Click);
            // 
            // modifyNewtoolStripSeparator
            // 
            this.modifyNewtoolStripSeparator.Name = "modifyNewtoolStripSeparator";
            this.modifyNewtoolStripSeparator.Size = new System.Drawing.Size(250, 6);
            this.modifyNewtoolStripSeparator.Visible = false;
            // 
            // newToolStripMenuItem2
            // 
            this.newToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keyToolStripMenuItem2,
            this.toolStripSeparator7,
            this.stringValueToolStripMenuItem2,
            this.binaryValueToolStripMenuItem2,
            this.dWORD32bitValueToolStripMenuItem2,
            this.qWORD64bitValueToolStripMenuItem2,
            this.multiStringValueToolStripMenuItem2,
            this.expandableStringValueToolStripMenuItem2});
            this.newToolStripMenuItem2.Name = "newToolStripMenuItem2";
            this.newToolStripMenuItem2.Size = new System.Drawing.Size(253, 34);
            this.newToolStripMenuItem2.Text = "新建";
            // 
            // keyToolStripMenuItem2
            // 
            this.keyToolStripMenuItem2.Name = "keyToolStripMenuItem2";
            this.keyToolStripMenuItem2.Size = new System.Drawing.Size(273, 34);
            this.keyToolStripMenuItem2.Text = "key";
            this.keyToolStripMenuItem2.Click += new System.EventHandler(this.createNewRegistryKey_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(270, 6);
            // 
            // stringValueToolStripMenuItem2
            // 
            this.stringValueToolStripMenuItem2.Name = "stringValueToolStripMenuItem2";
            this.stringValueToolStripMenuItem2.Size = new System.Drawing.Size(273, 34);
            this.stringValueToolStripMenuItem2.Text = "字符串值";
            this.stringValueToolStripMenuItem2.Click += new System.EventHandler(this.createStringRegistryValue_Click);
            // 
            // binaryValueToolStripMenuItem2
            // 
            this.binaryValueToolStripMenuItem2.Name = "binaryValueToolStripMenuItem2";
            this.binaryValueToolStripMenuItem2.Size = new System.Drawing.Size(273, 34);
            this.binaryValueToolStripMenuItem2.Text = "二进制值 ";
            this.binaryValueToolStripMenuItem2.Click += new System.EventHandler(this.createBinaryRegistryValue_Click);
            // 
            // dWORD32bitValueToolStripMenuItem2
            // 
            this.dWORD32bitValueToolStripMenuItem2.Name = "dWORD32bitValueToolStripMenuItem2";
            this.dWORD32bitValueToolStripMenuItem2.Size = new System.Drawing.Size(273, 34);
            this.dWORD32bitValueToolStripMenuItem2.Text = "DWORD (32-bit)值";
            this.dWORD32bitValueToolStripMenuItem2.Click += new System.EventHandler(this.createDwordRegistryValue_Click);
            // 
            // qWORD64bitValueToolStripMenuItem2
            // 
            this.qWORD64bitValueToolStripMenuItem2.Name = "qWORD64bitValueToolStripMenuItem2";
            this.qWORD64bitValueToolStripMenuItem2.Size = new System.Drawing.Size(273, 34);
            this.qWORD64bitValueToolStripMenuItem2.Text = "QWORD (64-bit)值";
            this.qWORD64bitValueToolStripMenuItem2.Click += new System.EventHandler(this.createQwordRegistryValue_Click);
            // 
            // multiStringValueToolStripMenuItem2
            // 
            this.multiStringValueToolStripMenuItem2.Name = "multiStringValueToolStripMenuItem2";
            this.multiStringValueToolStripMenuItem2.Size = new System.Drawing.Size(273, 34);
            this.multiStringValueToolStripMenuItem2.Text = "多字符串值";
            this.multiStringValueToolStripMenuItem2.Click += new System.EventHandler(this.createMultiStringRegistryValue_Click);
            // 
            // expandableStringValueToolStripMenuItem2
            // 
            this.expandableStringValueToolStripMenuItem2.Name = "expandableStringValueToolStripMenuItem2";
            this.expandableStringValueToolStripMenuItem2.Size = new System.Drawing.Size(273, 34);
            this.expandableStringValueToolStripMenuItem2.Text = "可扩展的字符串值 ";
            this.expandableStringValueToolStripMenuItem2.Click += new System.EventHandler(this.createExpandStringRegistryValue_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(250, 6);
            // 
            // deleteToolStripMenuItem2
            // 
            this.deleteToolStripMenuItem2.Enabled = false;
            this.deleteToolStripMenuItem2.Name = "deleteToolStripMenuItem2";
            this.deleteToolStripMenuItem2.ShortcutKeyDisplayString = "Del";
            this.deleteToolStripMenuItem2.Size = new System.Drawing.Size(253, 34);
            this.deleteToolStripMenuItem2.Text = "删除";
            this.deleteToolStripMenuItem2.Click += new System.EventHandler(this.menuStripDelete_Click);
            // 
            // renameToolStripMenuItem2
            // 
            this.renameToolStripMenuItem2.Enabled = false;
            this.renameToolStripMenuItem2.Name = "renameToolStripMenuItem2";
            this.renameToolStripMenuItem2.Size = new System.Drawing.Size(253, 34);
            this.renameToolStripMenuItem2.Text = "重命名";
            this.renameToolStripMenuItem2.Click += new System.EventHandler(this.menuStripRename_Click);
            // 
            // imageRegistryDirectoryList
            // 
            this.imageRegistryDirectoryList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageRegistryDirectoryList.ImageStream")));
            this.imageRegistryDirectoryList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageRegistryDirectoryList.Images.SetKeyName(0, "folder.png");
            // 
            // hName
            // 
            this.hName.Text = "Name";
            this.hName.Width = 173;
            // 
            // hType
            // 
            this.hType.Text = "Type";
            this.hType.Width = 104;
            // 
            // hValue
            // 
            this.hValue.Text = "Value";
            this.hValue.Width = 214;
            // 
            // imageRegistryKeyTypeList
            // 
            this.imageRegistryKeyTypeList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageRegistryKeyTypeList.ImageStream")));
            this.imageRegistryKeyTypeList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageRegistryKeyTypeList.Images.SetKeyName(0, "reg_string.png");
            this.imageRegistryKeyTypeList.Images.SetKeyName(1, "reg_binary.png");
            // 
            // tv_ContextMenuStrip
            // 
            this.tv_ContextMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tv_ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripSeparator1,
            this.deleteToolStripMenuItem,
            this.renameToolStripMenuItem});
            this.tv_ContextMenuStrip.Name = "contextMenuStrip";
            this.tv_ContextMenuStrip.Size = new System.Drawing.Size(151, 100);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keyToolStripMenuItem,
            this.toolStripSeparator2,
            this.stringValueToolStripMenuItem,
            this.binaryValueToolStripMenuItem,
            this.dWORD32bitValueToolStripMenuItem,
            this.qWORD64bitValueToolStripMenuItem,
            this.multiStringValueToolStripMenuItem,
            this.expandableStringValueToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(150, 30);
            this.newToolStripMenuItem.Text = "New";
            // 
            // keyToolStripMenuItem
            // 
            this.keyToolStripMenuItem.Name = "keyToolStripMenuItem";
            this.keyToolStripMenuItem.Size = new System.Drawing.Size(321, 34);
            this.keyToolStripMenuItem.Text = "Key";
            this.keyToolStripMenuItem.Click += new System.EventHandler(this.createNewRegistryKey_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(318, 6);
            // 
            // stringValueToolStripMenuItem
            // 
            this.stringValueToolStripMenuItem.Name = "stringValueToolStripMenuItem";
            this.stringValueToolStripMenuItem.Size = new System.Drawing.Size(321, 34);
            this.stringValueToolStripMenuItem.Text = "String Value";
            this.stringValueToolStripMenuItem.Click += new System.EventHandler(this.createStringRegistryValue_Click);
            // 
            // binaryValueToolStripMenuItem
            // 
            this.binaryValueToolStripMenuItem.Name = "binaryValueToolStripMenuItem";
            this.binaryValueToolStripMenuItem.Size = new System.Drawing.Size(321, 34);
            this.binaryValueToolStripMenuItem.Text = "Binary Value";
            this.binaryValueToolStripMenuItem.Click += new System.EventHandler(this.createBinaryRegistryValue_Click);
            // 
            // dWORD32bitValueToolStripMenuItem
            // 
            this.dWORD32bitValueToolStripMenuItem.Name = "dWORD32bitValueToolStripMenuItem";
            this.dWORD32bitValueToolStripMenuItem.Size = new System.Drawing.Size(321, 34);
            this.dWORD32bitValueToolStripMenuItem.Text = "DWORD (32-bit) Value";
            this.dWORD32bitValueToolStripMenuItem.Click += new System.EventHandler(this.createDwordRegistryValue_Click);
            // 
            // qWORD64bitValueToolStripMenuItem
            // 
            this.qWORD64bitValueToolStripMenuItem.Name = "qWORD64bitValueToolStripMenuItem";
            this.qWORD64bitValueToolStripMenuItem.Size = new System.Drawing.Size(321, 34);
            this.qWORD64bitValueToolStripMenuItem.Text = "QWORD (64-bit) Value";
            this.qWORD64bitValueToolStripMenuItem.Click += new System.EventHandler(this.createQwordRegistryValue_Click);
            // 
            // multiStringValueToolStripMenuItem
            // 
            this.multiStringValueToolStripMenuItem.Name = "multiStringValueToolStripMenuItem";
            this.multiStringValueToolStripMenuItem.Size = new System.Drawing.Size(321, 34);
            this.multiStringValueToolStripMenuItem.Text = "Multi-String Value";
            this.multiStringValueToolStripMenuItem.Click += new System.EventHandler(this.createMultiStringRegistryValue_Click);
            // 
            // expandableStringValueToolStripMenuItem
            // 
            this.expandableStringValueToolStripMenuItem.Name = "expandableStringValueToolStripMenuItem";
            this.expandableStringValueToolStripMenuItem.Size = new System.Drawing.Size(321, 34);
            this.expandableStringValueToolStripMenuItem.Text = "Expandable String Value";
            this.expandableStringValueToolStripMenuItem.Click += new System.EventHandler(this.createExpandStringRegistryValue_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(147, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Enabled = false;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(150, 30);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteRegistryKey_Click);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Enabled = false;
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(150, 30);
            this.renameToolStripMenuItem.Text = "Rename";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameRegistryKey_Click);
            // 
            // selectedItem_ContextMenuStrip
            // 
            this.selectedItem_ContextMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.selectedItem_ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifyToolStripMenuItem,
            this.modifyBinaryDataToolStripMenuItem,
            this.modifyToolStripSeparator1,
            this.deleteToolStripMenuItem1,
            this.renameToolStripMenuItem1});
            this.selectedItem_ContextMenuStrip.Name = "selectedItem_ContextMenuStrip";
            this.selectedItem_ContextMenuStrip.Size = new System.Drawing.Size(260, 138);
            // 
            // modifyToolStripMenuItem
            // 
            this.modifyToolStripMenuItem.Enabled = false;
            this.modifyToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Size = new System.Drawing.Size(259, 32);
            this.modifyToolStripMenuItem.Text = "Modify...";
            this.modifyToolStripMenuItem.Click += new System.EventHandler(this.modifyRegistryValue_Click);
            // 
            // modifyBinaryDataToolStripMenuItem
            // 
            this.modifyBinaryDataToolStripMenuItem.Enabled = false;
            this.modifyBinaryDataToolStripMenuItem.Name = "modifyBinaryDataToolStripMenuItem";
            this.modifyBinaryDataToolStripMenuItem.Size = new System.Drawing.Size(259, 32);
            this.modifyBinaryDataToolStripMenuItem.Text = "Modify Binary Data...";
            this.modifyBinaryDataToolStripMenuItem.Click += new System.EventHandler(this.modifyBinaryDataRegistryValue_Click);
            // 
            // modifyToolStripSeparator1
            // 
            this.modifyToolStripSeparator1.Name = "modifyToolStripSeparator1";
            this.modifyToolStripSeparator1.Size = new System.Drawing.Size(256, 6);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(259, 32);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteRegistryValue_Click);
            // 
            // renameToolStripMenuItem1
            // 
            this.renameToolStripMenuItem1.Name = "renameToolStripMenuItem1";
            this.renameToolStripMenuItem1.Size = new System.Drawing.Size(259, 32);
            this.renameToolStripMenuItem1.Text = "Rename";
            this.renameToolStripMenuItem1.Click += new System.EventHandler(this.renameRegistryValue_Click);
            // 
            // lst_ContextMenuStrip
            // 
            this.lst_ContextMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.lst_ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem1});
            this.lst_ContextMenuStrip.Name = "lst_ContextMenuStrip";
            this.lst_ContextMenuStrip.Size = new System.Drawing.Size(120, 34);
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keyToolStripMenuItem1,
            this.toolStripSeparator4,
            this.stringValueToolStripMenuItem1,
            this.binaryValueToolStripMenuItem1,
            this.dWORD32bitValueToolStripMenuItem1,
            this.qWORD64bitValueToolStripMenuItem1,
            this.multiStringValueToolStripMenuItem1,
            this.expandableStringValueToolStripMenuItem1});
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(119, 30);
            this.newToolStripMenuItem1.Text = "New";
            // 
            // keyToolStripMenuItem1
            // 
            this.keyToolStripMenuItem1.Name = "keyToolStripMenuItem1";
            this.keyToolStripMenuItem1.Size = new System.Drawing.Size(321, 34);
            this.keyToolStripMenuItem1.Text = "Key";
            this.keyToolStripMenuItem1.Click += new System.EventHandler(this.createNewRegistryKey_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(318, 6);
            // 
            // stringValueToolStripMenuItem1
            // 
            this.stringValueToolStripMenuItem1.Name = "stringValueToolStripMenuItem1";
            this.stringValueToolStripMenuItem1.Size = new System.Drawing.Size(321, 34);
            this.stringValueToolStripMenuItem1.Text = "String Value";
            this.stringValueToolStripMenuItem1.Click += new System.EventHandler(this.createStringRegistryValue_Click);
            // 
            // binaryValueToolStripMenuItem1
            // 
            this.binaryValueToolStripMenuItem1.Name = "binaryValueToolStripMenuItem1";
            this.binaryValueToolStripMenuItem1.Size = new System.Drawing.Size(321, 34);
            this.binaryValueToolStripMenuItem1.Text = "Binary Value";
            this.binaryValueToolStripMenuItem1.Click += new System.EventHandler(this.createBinaryRegistryValue_Click);
            // 
            // dWORD32bitValueToolStripMenuItem1
            // 
            this.dWORD32bitValueToolStripMenuItem1.Name = "dWORD32bitValueToolStripMenuItem1";
            this.dWORD32bitValueToolStripMenuItem1.Size = new System.Drawing.Size(321, 34);
            this.dWORD32bitValueToolStripMenuItem1.Text = "DWORD (32-bit) Value";
            this.dWORD32bitValueToolStripMenuItem1.Click += new System.EventHandler(this.createDwordRegistryValue_Click);
            // 
            // qWORD64bitValueToolStripMenuItem1
            // 
            this.qWORD64bitValueToolStripMenuItem1.Name = "qWORD64bitValueToolStripMenuItem1";
            this.qWORD64bitValueToolStripMenuItem1.Size = new System.Drawing.Size(321, 34);
            this.qWORD64bitValueToolStripMenuItem1.Text = "QWORD (64-bit) Value";
            this.qWORD64bitValueToolStripMenuItem1.Click += new System.EventHandler(this.createQwordRegistryValue_Click);
            // 
            // multiStringValueToolStripMenuItem1
            // 
            this.multiStringValueToolStripMenuItem1.Name = "multiStringValueToolStripMenuItem1";
            this.multiStringValueToolStripMenuItem1.Size = new System.Drawing.Size(321, 34);
            this.multiStringValueToolStripMenuItem1.Text = "Multi-String Value";
            this.multiStringValueToolStripMenuItem1.Click += new System.EventHandler(this.createMultiStringRegistryValue_Click);
            // 
            // expandableStringValueToolStripMenuItem1
            // 
            this.expandableStringValueToolStripMenuItem1.Name = "expandableStringValueToolStripMenuItem1";
            this.expandableStringValueToolStripMenuItem1.Size = new System.Drawing.Size(321, 34);
            this.expandableStringValueToolStripMenuItem1.Text = "Expandable String Value";
            this.expandableStringValueToolStripMenuItem1.Click += new System.EventHandler(this.createExpandStringRegistryValue_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormRegistryEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1176, 842);
            this.Controls.Add(this.tableLayoutPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormRegistryEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注册表编辑器  []";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormRegistryEditor_FormClosed);
            this.Load += new System.EventHandler(this.FrmRegistryEditor_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tv_ContextMenuStrip.ResumeLayout(false);
            this.selectedItem_ContextMenuStrip.ResumeLayout(false);
            this.lst_ContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.SplitContainer splitContainer;
        public RegistryTreeView tvRegistryDirectory;
        private AeroListView lstRegistryValues;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel selectedStripStatusLabel;
        private System.Windows.Forms.ImageList imageRegistryDirectoryList;
        private System.Windows.Forms.ColumnHeader hName;
        private System.Windows.Forms.ColumnHeader hType;
        private System.Windows.Forms.ColumnHeader hValue;
        private System.Windows.Forms.ImageList imageRegistryKeyTypeList;
        private System.Windows.Forms.ContextMenuStrip tv_ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem stringValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binaryValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dWORD32bitValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qWORD64bitValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiStringValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expandableStringValueToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip selectedItem_ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyBinaryDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip lst_ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem keyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stringValueToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem binaryValueToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dWORD32bitValueToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem qWORD64bitValueToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem multiStringValueToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem expandableStringValueToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modifyBinaryDataToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator modifyNewtoolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem keyToolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem stringValueToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem binaryValueToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem dWORD32bitValueToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem qWORD64bitValueToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem multiStringValueToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem expandableStringValueToolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator modifyToolStripSeparator1;
        public System.Windows.Forms.Timer timer1;
    }
}