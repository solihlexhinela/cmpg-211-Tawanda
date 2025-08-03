﻿namespace TawandaSystem
{
    partial class Children
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
            this.tpgChildren = new System.Windows.Forms.TabControl();
            this.tpgAdd = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbInsertRecords = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.gbIsAccepted = new System.Windows.Forms.GroupBox();
            this.chbxYes = new System.Windows.Forms.CheckBox();
            this.chbxNo = new System.Windows.Forms.CheckBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.lblArrival = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblChildLName = new System.Windows.Forms.Label();
            this.lblChildName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblHeading = new System.Windows.Forms.Label();
            this.tpgUpdate = new System.Windows.Forms.TabPage();
            this.btnClearUp = new System.Windows.Forms.Button();
            this.btnBackUp = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblHeadingII = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblUpdated = new System.Windows.Forms.Label();
            this.lstUpdatedRecord = new System.Windows.Forms.ListBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.txtIDUp = new System.Windows.Forms.TextBox();
            this.txtNameUp = new System.Windows.Forms.TextBox();
            this.txtLNameUp = new System.Windows.Forms.TextBox();
            this.lblDeparture = new System.Windows.Forms.Label();
            this.lblIDUp = new System.Windows.Forms.Label();
            this.lblLNameUp = new System.Windows.Forms.Label();
            this.lblNameUp = new System.Windows.Forms.Label();
            this.tpgDelete = new System.Windows.Forms.TabPage();
            this.btnClearDel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnBackDel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbSearchToDel = new System.Windows.Forms.GroupBox();
            this.lblResults = new System.Windows.Forms.Label();
            this.dgvDeleteRecord = new System.Windows.Forms.DataGridView();
            this.txtNameDel = new System.Windows.Forms.TextBox();
            this.txtLNameDel = new System.Windows.Forms.TextBox();
            this.lblLNameDel = new System.Windows.Forms.Label();
            this.lblNameDel = new System.Windows.Forms.Label();
            this.lblHeadingIII = new System.Windows.Forms.Label();
            this.tpgDisplayChildren = new System.Windows.Forms.TabPage();
            this.dgvchildren = new System.Windows.Forms.DataGridView();
            this.btnBackto = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbSort = new System.Windows.Forms.GroupBox();
            this.rdoBetween = new System.Windows.Forms.RadioButton();
            this.rdoLess = new System.Windows.Forms.RadioButton();
            this.rbtnDisplayAll = new System.Windows.Forms.RadioButton();
            this.rdogreater = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tpgChildren.SuspendLayout();
            this.tpgAdd.SuspendLayout();
            this.gbInsertRecords.SuspendLayout();
            this.gbIsAccepted.SuspendLayout();
            this.tpgUpdate.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tpgDelete.SuspendLayout();
            this.gbSearchToDel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeleteRecord)).BeginInit();
            this.tpgDisplayChildren.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvchildren)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.gbSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpgChildren
            // 
            this.tpgChildren.Controls.Add(this.tpgAdd);
            this.tpgChildren.Controls.Add(this.tpgUpdate);
            this.tpgChildren.Controls.Add(this.tpgDelete);
            this.tpgChildren.Controls.Add(this.tpgDisplayChildren);
            this.tpgChildren.Location = new System.Drawing.Point(-3, 30);
            this.tpgChildren.Margin = new System.Windows.Forms.Padding(4);
            this.tpgChildren.Name = "tpgChildren";
            this.tpgChildren.SelectedIndex = 0;
            this.tpgChildren.Size = new System.Drawing.Size(839, 492);
            this.tpgChildren.TabIndex = 0;
            this.tpgChildren.SelectedIndexChanged += new System.EventHandler(this.tpgChildren_SelectedIndexChanged);
            // 
            // tpgAdd
            // 
            this.tpgAdd.Controls.Add(this.btnClear);
            this.tpgAdd.Controls.Add(this.btnBack);
            this.tpgAdd.Controls.Add(this.gbInsertRecords);
            this.tpgAdd.Controls.Add(this.btnAdd);
            this.tpgAdd.Controls.Add(this.lblHeading);
            this.tpgAdd.Location = new System.Drawing.Point(4, 25);
            this.tpgAdd.Margin = new System.Windows.Forms.Padding(4);
            this.tpgAdd.Name = "tpgAdd";
            this.tpgAdd.Padding = new System.Windows.Forms.Padding(4);
            this.tpgAdd.Size = new System.Drawing.Size(831, 463);
            this.tpgAdd.TabIndex = 0;
            this.tpgAdd.Text = "Add New Records";
            this.tpgAdd.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.SkyBlue;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClear.Location = new System.Drawing.Point(481, 404);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(155, 44);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SkyBlue;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Location = new System.Drawing.Point(644, 404);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(155, 44);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gbInsertRecords
            // 
            this.gbInsertRecords.Controls.Add(this.dateTimePicker1);
            this.gbInsertRecords.Controls.Add(this.gbIsAccepted);
            this.gbInsertRecords.Controls.Add(this.txtID);
            this.gbInsertRecords.Controls.Add(this.txtName);
            this.gbInsertRecords.Controls.Add(this.txtLName);
            this.gbInsertRecords.Controls.Add(this.lblArrival);
            this.gbInsertRecords.Controls.Add(this.lblID);
            this.gbInsertRecords.Controls.Add(this.lblChildLName);
            this.gbInsertRecords.Controls.Add(this.lblChildName);
            this.gbInsertRecords.Location = new System.Drawing.Point(36, 63);
            this.gbInsertRecords.Margin = new System.Windows.Forms.Padding(4);
            this.gbInsertRecords.Name = "gbInsertRecords";
            this.gbInsertRecords.Padding = new System.Windows.Forms.Padding(4);
            this.gbInsertRecords.Size = new System.Drawing.Size(763, 321);
            this.gbInsertRecords.TabIndex = 4;
            this.gbInsertRecords.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(201, 169);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(132, 22);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // gbIsAccepted
            // 
            this.gbIsAccepted.Controls.Add(this.chbxYes);
            this.gbIsAccepted.Controls.Add(this.chbxNo);
            this.gbIsAccepted.Location = new System.Drawing.Point(385, 66);
            this.gbIsAccepted.Margin = new System.Windows.Forms.Padding(4);
            this.gbIsAccepted.Name = "gbIsAccepted";
            this.gbIsAccepted.Padding = new System.Windows.Forms.Padding(4);
            this.gbIsAccepted.Size = new System.Drawing.Size(351, 122);
            this.gbIsAccepted.TabIndex = 11;
            this.gbIsAccepted.TabStop = false;
            this.gbIsAccepted.Text = "Is Accepeted";
            // 
            // chbxYes
            // 
            this.chbxYes.AutoSize = true;
            this.chbxYes.Location = new System.Drawing.Point(25, 28);
            this.chbxYes.Margin = new System.Windows.Forms.Padding(4);
            this.chbxYes.Name = "chbxYes";
            this.chbxYes.Size = new System.Drawing.Size(53, 20);
            this.chbxYes.TabIndex = 5;
            this.chbxYes.Text = "Yes";
            this.chbxYes.UseVisualStyleBackColor = true;
            // 
            // chbxNo
            // 
            this.chbxNo.AutoSize = true;
            this.chbxNo.Location = new System.Drawing.Point(25, 57);
            this.chbxNo.Margin = new System.Windows.Forms.Padding(4);
            this.chbxNo.Name = "chbxNo";
            this.chbxNo.Size = new System.Drawing.Size(47, 20);
            this.chbxNo.TabIndex = 6;
            this.chbxNo.Text = "No";
            this.chbxNo.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(201, 137);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(132, 22);
            this.txtID.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(201, 102);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(132, 22);
            this.txtName.TabIndex = 8;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(201, 66);
            this.txtLName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(132, 22);
            this.txtLName.TabIndex = 7;
            // 
            // lblArrival
            // 
            this.lblArrival.AutoSize = true;
            this.lblArrival.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrival.Location = new System.Drawing.Point(23, 169);
            this.lblArrival.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArrival.Name = "lblArrival";
            this.lblArrival.Size = new System.Drawing.Size(87, 18);
            this.lblArrival.TabIndex = 3;
            this.lblArrival.Text = "Arrival Date:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(24, 138);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(150, 18);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "Identification Number:";
            // 
            // lblChildLName
            // 
            this.lblChildLName.AutoSize = true;
            this.lblChildLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChildLName.Location = new System.Drawing.Point(24, 78);
            this.lblChildLName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChildLName.Name = "lblChildLName";
            this.lblChildLName.Size = new System.Drawing.Size(88, 18);
            this.lblChildLName.TabIndex = 1;
            this.lblChildLName.Text = "Last Name: ";
            // 
            // lblChildName
            // 
            this.lblChildName.AutoSize = true;
            this.lblChildName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChildName.Location = new System.Drawing.Point(24, 108);
            this.lblChildName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChildName.Name = "lblChildName";
            this.lblChildName.Size = new System.Drawing.Size(70, 18);
            this.lblChildName.TabIndex = 0;
            this.lblChildName.Text = "Name(s):";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Location = new System.Drawing.Point(319, 404);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(155, 44);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(232, 20);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(279, 25);
            this.lblHeading.TabIndex = 3;
            this.lblHeading.Text = "CHILD MANAGEMENT";
            // 
            // tpgUpdate
            // 
            this.tpgUpdate.Controls.Add(this.btnClearUp);
            this.tpgUpdate.Controls.Add(this.btnBackUp);
            this.tpgUpdate.Controls.Add(this.btnUpdate);
            this.tpgUpdate.Controls.Add(this.lblHeadingII);
            this.tpgUpdate.Controls.Add(this.groupBox1);
            this.tpgUpdate.Location = new System.Drawing.Point(4, 25);
            this.tpgUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.tpgUpdate.Name = "tpgUpdate";
            this.tpgUpdate.Padding = new System.Windows.Forms.Padding(4);
            this.tpgUpdate.Size = new System.Drawing.Size(831, 463);
            this.tpgUpdate.TabIndex = 1;
            this.tpgUpdate.Text = "Update Records";
            this.tpgUpdate.UseVisualStyleBackColor = true;
            // 
            // btnClearUp
            // 
            this.btnClearUp.BackColor = System.Drawing.Color.SkyBlue;
            this.btnClearUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearUp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClearUp.Location = new System.Drawing.Point(477, 388);
            this.btnClearUp.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearUp.Name = "btnClearUp";
            this.btnClearUp.Size = new System.Drawing.Size(155, 44);
            this.btnClearUp.TabIndex = 15;
            this.btnClearUp.Text = "Clear";
            this.btnClearUp.UseVisualStyleBackColor = false;
            this.btnClearUp.Click += new System.EventHandler(this.btnClearUp_Click);
            // 
            // btnBackUp
            // 
            this.btnBackUp.BackColor = System.Drawing.Color.SkyBlue;
            this.btnBackUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackUp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBackUp.Location = new System.Drawing.Point(640, 388);
            this.btnBackUp.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackUp.Name = "btnBackUp";
            this.btnBackUp.Size = new System.Drawing.Size(155, 44);
            this.btnBackUp.TabIndex = 14;
            this.btnBackUp.Text = "Back";
            this.btnBackUp.UseVisualStyleBackColor = false;
            this.btnBackUp.Click += new System.EventHandler(this.btnBackUp_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.SkyBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.Location = new System.Drawing.Point(315, 388);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(155, 44);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblHeadingII
            // 
            this.lblHeadingII.AutoSize = true;
            this.lblHeadingII.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadingII.Location = new System.Drawing.Point(231, 22);
            this.lblHeadingII.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeadingII.Name = "lblHeadingII";
            this.lblHeadingII.Size = new System.Drawing.Size(279, 25);
            this.lblHeadingII.TabIndex = 6;
            this.lblHeadingII.Text = "CHILD MANAGEMENT";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblUpdated);
            this.groupBox1.Controls.Add(this.lstUpdatedRecord);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.txtIDUp);
            this.groupBox1.Controls.Add(this.txtNameUp);
            this.groupBox1.Controls.Add(this.txtLNameUp);
            this.groupBox1.Controls.Add(this.lblDeparture);
            this.groupBox1.Controls.Add(this.lblIDUp);
            this.groupBox1.Controls.Add(this.lblLNameUp);
            this.groupBox1.Controls.Add(this.lblNameUp);
            this.groupBox1.Location = new System.Drawing.Point(41, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(753, 330);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // lblUpdated
            // 
            this.lblUpdated.AutoSize = true;
            this.lblUpdated.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdated.Location = new System.Drawing.Point(361, 37);
            this.lblUpdated.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdated.Name = "lblUpdated";
            this.lblUpdated.Size = new System.Drawing.Size(120, 18);
            this.lblUpdated.TabIndex = 15;
            this.lblUpdated.Text = "Updated Record:";
            // 
            // lstUpdatedRecord
            // 
            this.lstUpdatedRecord.FormattingEnabled = true;
            this.lstUpdatedRecord.ItemHeight = 16;
            this.lstUpdatedRecord.Location = new System.Drawing.Point(365, 59);
            this.lstUpdatedRecord.Margin = new System.Windows.Forms.Padding(4);
            this.lstUpdatedRecord.Name = "lstUpdatedRecord";
            this.lstUpdatedRecord.Size = new System.Drawing.Size(379, 260);
            this.lstUpdatedRecord.TabIndex = 14;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(201, 135);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(132, 22);
            this.dateTimePicker2.TabIndex = 13;
            // 
            // txtIDUp
            // 
            this.txtIDUp.Location = new System.Drawing.Point(201, 97);
            this.txtIDUp.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDUp.Name = "txtIDUp";
            this.txtIDUp.Size = new System.Drawing.Size(132, 22);
            this.txtIDUp.TabIndex = 9;
            // 
            // txtNameUp
            // 
            this.txtNameUp.Location = new System.Drawing.Point(201, 66);
            this.txtNameUp.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameUp.Name = "txtNameUp";
            this.txtNameUp.Size = new System.Drawing.Size(132, 22);
            this.txtNameUp.TabIndex = 8;
            // 
            // txtLNameUp
            // 
            this.txtLNameUp.Location = new System.Drawing.Point(201, 38);
            this.txtLNameUp.Margin = new System.Windows.Forms.Padding(4);
            this.txtLNameUp.Name = "txtLNameUp";
            this.txtLNameUp.Size = new System.Drawing.Size(132, 22);
            this.txtLNameUp.TabIndex = 7;
            // 
            // lblDeparture
            // 
            this.lblDeparture.AutoSize = true;
            this.lblDeparture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeparture.Location = new System.Drawing.Point(23, 135);
            this.lblDeparture.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeparture.Name = "lblDeparture";
            this.lblDeparture.Size = new System.Drawing.Size(112, 18);
            this.lblDeparture.TabIndex = 3;
            this.lblDeparture.Text = "Departure Date:";
            // 
            // lblIDUp
            // 
            this.lblIDUp.AutoSize = true;
            this.lblIDUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDUp.Location = new System.Drawing.Point(21, 103);
            this.lblIDUp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDUp.Name = "lblIDUp";
            this.lblIDUp.Size = new System.Drawing.Size(150, 18);
            this.lblIDUp.TabIndex = 2;
            this.lblIDUp.Text = "Identification Number:";
            // 
            // lblLNameUp
            // 
            this.lblLNameUp.AutoSize = true;
            this.lblLNameUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLNameUp.Location = new System.Drawing.Point(21, 44);
            this.lblLNameUp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLNameUp.Name = "lblLNameUp";
            this.lblLNameUp.Size = new System.Drawing.Size(88, 18);
            this.lblLNameUp.TabIndex = 1;
            this.lblLNameUp.Text = "Last Name: ";
            // 
            // lblNameUp
            // 
            this.lblNameUp.AutoSize = true;
            this.lblNameUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameUp.Location = new System.Drawing.Point(21, 73);
            this.lblNameUp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameUp.Name = "lblNameUp";
            this.lblNameUp.Size = new System.Drawing.Size(70, 18);
            this.lblNameUp.TabIndex = 0;
            this.lblNameUp.Text = "Name(s):";
            // 
            // tpgDelete
            // 
            this.tpgDelete.Controls.Add(this.btnClearDel);
            this.tpgDelete.Controls.Add(this.btnSearch);
            this.tpgDelete.Controls.Add(this.btnBackDel);
            this.tpgDelete.Controls.Add(this.btnDelete);
            this.tpgDelete.Controls.Add(this.gbSearchToDel);
            this.tpgDelete.Controls.Add(this.lblHeadingIII);
            this.tpgDelete.Location = new System.Drawing.Point(4, 25);
            this.tpgDelete.Margin = new System.Windows.Forms.Padding(4);
            this.tpgDelete.Name = "tpgDelete";
            this.tpgDelete.Size = new System.Drawing.Size(831, 463);
            this.tpgDelete.TabIndex = 2;
            this.tpgDelete.Text = "Delete Records";
            this.tpgDelete.UseVisualStyleBackColor = true;
            this.tpgDelete.Click += new System.EventHandler(this.tpgDelete_Click);
            // 
            // btnClearDel
            // 
            this.btnClearDel.BackColor = System.Drawing.Color.SkyBlue;
            this.btnClearDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearDel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClearDel.Location = new System.Drawing.Point(297, 388);
            this.btnClearDel.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearDel.Name = "btnClearDel";
            this.btnClearDel.Size = new System.Drawing.Size(155, 44);
            this.btnClearDel.TabIndex = 17;
            this.btnClearDel.Text = "Clear";
            this.btnClearDel.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.Location = new System.Drawing.Point(135, 388);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(155, 44);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnBackDel
            // 
            this.btnBackDel.BackColor = System.Drawing.Color.SkyBlue;
            this.btnBackDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackDel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBackDel.Location = new System.Drawing.Point(639, 388);
            this.btnBackDel.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackDel.Name = "btnBackDel";
            this.btnBackDel.Size = new System.Drawing.Size(155, 44);
            this.btnBackDel.TabIndex = 15;
            this.btnBackDel.Text = "Back";
            this.btnBackDel.UseVisualStyleBackColor = false;
            this.btnBackDel.Click += new System.EventHandler(this.btnBackDel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(460, 388);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(155, 44);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // gbSearchToDel
            // 
            this.gbSearchToDel.Controls.Add(this.lblResults);
            this.gbSearchToDel.Controls.Add(this.dgvDeleteRecord);
            this.gbSearchToDel.Controls.Add(this.txtNameDel);
            this.gbSearchToDel.Controls.Add(this.txtLNameDel);
            this.gbSearchToDel.Controls.Add(this.lblLNameDel);
            this.gbSearchToDel.Controls.Add(this.lblNameDel);
            this.gbSearchToDel.Location = new System.Drawing.Point(41, 58);
            this.gbSearchToDel.Margin = new System.Windows.Forms.Padding(4);
            this.gbSearchToDel.Name = "gbSearchToDel";
            this.gbSearchToDel.Padding = new System.Windows.Forms.Padding(4);
            this.gbSearchToDel.Size = new System.Drawing.Size(752, 305);
            this.gbSearchToDel.TabIndex = 8;
            this.gbSearchToDel.TabStop = false;
            this.gbSearchToDel.Text = "Search for Record:";
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(21, 101);
            this.lblResults.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(113, 18);
            this.lblResults.TabIndex = 10;
            this.lblResults.Text = "Search Results:";
            // 
            // dgvDeleteRecord
            // 
            this.dgvDeleteRecord.AllowUserToOrderColumns = true;
            this.dgvDeleteRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeleteRecord.Location = new System.Drawing.Point(25, 123);
            this.dgvDeleteRecord.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDeleteRecord.Name = "dgvDeleteRecord";
            this.dgvDeleteRecord.RowHeadersWidth = 51;
            this.dgvDeleteRecord.Size = new System.Drawing.Size(703, 162);
            this.dgvDeleteRecord.TabIndex = 9;
            // 
            // txtNameDel
            // 
            this.txtNameDel.Location = new System.Drawing.Point(147, 64);
            this.txtNameDel.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameDel.Name = "txtNameDel";
            this.txtNameDel.Size = new System.Drawing.Size(132, 22);
            this.txtNameDel.TabIndex = 8;
            // 
            // txtLNameDel
            // 
            this.txtLNameDel.Location = new System.Drawing.Point(147, 32);
            this.txtLNameDel.Margin = new System.Windows.Forms.Padding(4);
            this.txtLNameDel.Name = "txtLNameDel";
            this.txtLNameDel.Size = new System.Drawing.Size(132, 22);
            this.txtLNameDel.TabIndex = 7;
            // 
            // lblLNameDel
            // 
            this.lblLNameDel.AutoSize = true;
            this.lblLNameDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLNameDel.Location = new System.Drawing.Point(21, 38);
            this.lblLNameDel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLNameDel.Name = "lblLNameDel";
            this.lblLNameDel.Size = new System.Drawing.Size(88, 18);
            this.lblLNameDel.TabIndex = 1;
            this.lblLNameDel.Text = "Last Name: ";
            // 
            // lblNameDel
            // 
            this.lblNameDel.AutoSize = true;
            this.lblNameDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameDel.Location = new System.Drawing.Point(21, 70);
            this.lblNameDel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameDel.Name = "lblNameDel";
            this.lblNameDel.Size = new System.Drawing.Size(70, 18);
            this.lblNameDel.TabIndex = 0;
            this.lblNameDel.Text = "Name(s):";
            // 
            // lblHeadingIII
            // 
            this.lblHeadingIII.AutoSize = true;
            this.lblHeadingIII.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadingIII.Location = new System.Drawing.Point(228, 30);
            this.lblHeadingIII.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeadingIII.Name = "lblHeadingIII";
            this.lblHeadingIII.Size = new System.Drawing.Size(279, 25);
            this.lblHeadingIII.TabIndex = 7;
            this.lblHeadingIII.Text = "CHILD MANAGEMENT";
            // 
            // tpgDisplayChildren
            // 
            this.tpgDisplayChildren.Controls.Add(this.label1);
            this.tpgDisplayChildren.Controls.Add(this.gbSort);
            this.tpgDisplayChildren.Controls.Add(this.dgvchildren);
            this.tpgDisplayChildren.Controls.Add(this.btnBackto);
            this.tpgDisplayChildren.Controls.Add(this.btnEnter);
            this.tpgDisplayChildren.Location = new System.Drawing.Point(4, 25);
            this.tpgDisplayChildren.Name = "tpgDisplayChildren";
            this.tpgDisplayChildren.Size = new System.Drawing.Size(831, 463);
            this.tpgDisplayChildren.TabIndex = 3;
            this.tpgDisplayChildren.Text = "Display Records";
            this.tpgDisplayChildren.UseVisualStyleBackColor = true;
            // 
            // dgvchildren
            // 
            this.dgvchildren.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvchildren.Location = new System.Drawing.Point(3, 165);
            this.dgvchildren.Name = "dgvchildren";
            this.dgvchildren.RowHeadersWidth = 51;
            this.dgvchildren.RowTemplate.Height = 24;
            this.dgvchildren.Size = new System.Drawing.Size(820, 240);
            this.dgvchildren.TabIndex = 22;
            // 
            // btnBackto
            // 
            this.btnBackto.BackColor = System.Drawing.Color.SkyBlue;
            this.btnBackto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBackto.Location = new System.Drawing.Point(672, 412);
            this.btnBackto.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackto.Name = "btnBackto";
            this.btnBackto.Size = new System.Drawing.Size(155, 44);
            this.btnBackto.TabIndex = 20;
            this.btnBackto.Text = "Back";
            this.btnBackto.UseVisualStyleBackColor = false;
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.SkyBlue;
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEnter.Location = new System.Drawing.Point(509, 412);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(155, 44);
            this.btnEnter.TabIndex = 19;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(784, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(53, 524);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // gbSort
            // 
            this.gbSort.Controls.Add(this.rdogreater);
            this.gbSort.Controls.Add(this.rdoBetween);
            this.gbSort.Controls.Add(this.rdoLess);
            this.gbSort.Controls.Add(this.rbtnDisplayAll);
            this.gbSort.Location = new System.Drawing.Point(11, 29);
            this.gbSort.Name = "gbSort";
            this.gbSort.Size = new System.Drawing.Size(343, 130);
            this.gbSort.TabIndex = 29;
            this.gbSort.TabStop = false;
            this.gbSort.Text = "Display";
            // 
            // rdoBetween
            // 
            this.rdoBetween.AutoSize = true;
            this.rdoBetween.Location = new System.Drawing.Point(17, 83);
            this.rdoBetween.Name = "rdoBetween";
            this.rdoBetween.Size = new System.Drawing.Size(168, 20);
            this.rdoBetween.TabIndex = 2;
            this.rdoBetween.TabStop = true;
            this.rdoBetween.Text = "Age Between 10 and 17";
            this.rdoBetween.UseVisualStyleBackColor = true;
            // 
            // rdoLess
            // 
            this.rdoLess.AutoSize = true;
            this.rdoLess.Location = new System.Drawing.Point(17, 57);
            this.rdoLess.Name = "rdoLess";
            this.rdoLess.Size = new System.Drawing.Size(80, 20);
            this.rdoLess.TabIndex = 1;
            this.rdoLess.TabStop = true;
            this.rdoLess.Text = "Age < 10";
            this.rdoLess.UseVisualStyleBackColor = true;
            // 
            // rbtnDisplayAll
            // 
            this.rbtnDisplayAll.AutoSize = true;
            this.rbtnDisplayAll.Location = new System.Drawing.Point(17, 31);
            this.rbtnDisplayAll.Name = "rbtnDisplayAll";
            this.rbtnDisplayAll.Size = new System.Drawing.Size(43, 20);
            this.rbtnDisplayAll.TabIndex = 0;
            this.rbtnDisplayAll.TabStop = true;
            this.rbtnDisplayAll.Text = "All";
            this.rbtnDisplayAll.UseVisualStyleBackColor = true;
            // 
            // rdogreater
            // 
            this.rdogreater.AutoSize = true;
            this.rdogreater.Location = new System.Drawing.Point(17, 104);
            this.rdogreater.Name = "rdogreater";
            this.rdogreater.Size = new System.Drawing.Size(182, 20);
            this.rdogreater.TabIndex = 3;
            this.rdogreater.TabStop = true;
            this.rdogreater.Text = "Age greater or equal to 18";
            this.rdogreater.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "CHILD MANAGEMENT";
            // 
            // Children
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(837, 524);
            this.Controls.Add(this.tpgChildren);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Children";
            this.Text = "Children";
            this.Load += new System.EventHandler(this.Children_Load);
            this.tpgChildren.ResumeLayout(false);
            this.tpgAdd.ResumeLayout(false);
            this.tpgAdd.PerformLayout();
            this.gbInsertRecords.ResumeLayout(false);
            this.gbInsertRecords.PerformLayout();
            this.gbIsAccepted.ResumeLayout(false);
            this.gbIsAccepted.PerformLayout();
            this.tpgUpdate.ResumeLayout(false);
            this.tpgUpdate.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tpgDelete.ResumeLayout(false);
            this.tpgDelete.PerformLayout();
            this.gbSearchToDel.ResumeLayout(false);
            this.gbSearchToDel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeleteRecord)).EndInit();
            this.tpgDisplayChildren.ResumeLayout(false);
            this.tpgDisplayChildren.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvchildren)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbSort.ResumeLayout(false);
            this.gbSort.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tpgChildren;
        private System.Windows.Forms.TabPage tpgAdd;
        private System.Windows.Forms.TabPage tpgUpdate;
        private System.Windows.Forms.TabPage tpgDelete;
        private System.Windows.Forms.Label lblChildLName;
        private System.Windows.Forms.Label lblChildName;
        private System.Windows.Forms.GroupBox gbInsertRecords;
        private System.Windows.Forms.Label lblArrival;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.CheckBox chbxNo;
        private System.Windows.Forms.CheckBox chbxYes;
        private System.Windows.Forms.GroupBox gbIsAccepted;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblHeadingII;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox txtIDUp;
        private System.Windows.Forms.TextBox txtNameUp;
        private System.Windows.Forms.TextBox txtLNameUp;
        private System.Windows.Forms.Label lblDeparture;
        private System.Windows.Forms.Label lblIDUp;
        private System.Windows.Forms.Label lblLNameUp;
        private System.Windows.Forms.Label lblNameUp;
        private System.Windows.Forms.Button btnBackUp;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblUpdated;
        private System.Windows.Forms.ListBox lstUpdatedRecord;
        private System.Windows.Forms.Label lblHeadingIII;
        private System.Windows.Forms.GroupBox gbSearchToDel;
        private System.Windows.Forms.TextBox txtNameDel;
        private System.Windows.Forms.TextBox txtLNameDel;
        private System.Windows.Forms.Label lblLNameDel;
        private System.Windows.Forms.Label lblNameDel;
        private System.Windows.Forms.Button btnBackDel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvDeleteRecord;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClearUp;
        private System.Windows.Forms.Button btnClearDel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabPage tpgDisplayChildren;
        private System.Windows.Forms.Button btnBackto;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.DataGridView dgvchildren;
        private System.Windows.Forms.GroupBox gbSort;
        private System.Windows.Forms.RadioButton rdogreater;
        private System.Windows.Forms.RadioButton rdoBetween;
        private System.Windows.Forms.RadioButton rdoLess;
        private System.Windows.Forms.RadioButton rbtnDisplayAll;
        private System.Windows.Forms.Label label1;
    }
}