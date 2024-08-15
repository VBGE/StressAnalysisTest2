﻿namespace MyCAD.EntryForms
{
    partial class Input_Values
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label materialLabel;
            System.Windows.Forms.Label tensileStrengthLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.materialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialsDBDataSet = new MyCAD.MaterialsDBDataSet();
            this.materialTextBox = new System.Windows.Forms.TextBox();
            this.tensileStrengthTextBox = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.addNewBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.materialsDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensileStrengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialsTableAdapter = new MyCAD.MaterialsDBDataSetTableAdapters.MaterialsTableAdapter();
            this.tableAdapterManager = new MyCAD.MaterialsDBDataSetTableAdapters.TableAdapterManager();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.parent_material_thickness_textBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.weld_size_textBox = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.Mz_textBox = new System.Windows.Forms.TextBox();
            this.Mx_textBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.My_textBox = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.Fx_textBox = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.Fy_textBox = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.Fz_textBox = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.FoSLabel = new System.Windows.Forms.Label();
            this.ResultantForceLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AllowableForceLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            idLabel = new System.Windows.Forms.Label();
            materialLabel = new System.Windows.Forms.Label();
            tensileStrengthLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsDBDataSet)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialsDataGridView)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(13, 54);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(46, 32);
            idLabel.TabIndex = 37;
            idLabel.Text = "Id:";
            // 
            // materialLabel
            // 
            materialLabel.AutoSize = true;
            materialLabel.Location = new System.Drawing.Point(13, 98);
            materialLabel.Name = "materialLabel";
            materialLabel.Size = new System.Drawing.Size(125, 32);
            materialLabel.TabIndex = 39;
            materialLabel.Text = "Material:";
            // 
            // tensileStrengthLabel
            // 
            tensileStrengthLabel.AutoSize = true;
            tensileStrengthLabel.Location = new System.Drawing.Point(13, 142);
            tensileStrengthLabel.Name = "tensileStrengthLabel";
            tensileStrengthLabel.Size = new System.Drawing.Size(231, 32);
            tensileStrengthLabel.TabIndex = 41;
            tensileStrengthLabel.Text = "Tensile Strength:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MinimumSize = new System.Drawing.Size(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1708, 50);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.label11);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1708, 60);
            this.panel4.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(686, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(300, 39);
            this.label11.TabIndex = 0;
            this.label11.Text = "Material selection";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.68429F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.31571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 246F));
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.materialsDataGridView, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 50);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.06806F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 309F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 309F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1708, 309);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(idLabel);
            this.panel5.Controls.Add(this.idTextBox);
            this.panel5.Controls.Add(materialLabel);
            this.panel5.Controls.Add(this.materialTextBox);
            this.panel5.Controls.Add(tensileStrengthLabel);
            this.panel5.Controls.Add(this.tensileStrengthTextBox);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(817, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(641, 303);
            this.panel5.TabIndex = 12;
            // 
            // idTextBox
            // 
            this.idTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialsBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(250, 51);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(323, 38);
            this.idTextBox.TabIndex = 38;
            // 
            // materialsBindingSource
            // 
            this.materialsBindingSource.DataMember = "Materials";
            this.materialsBindingSource.DataSource = this.materialsDBDataSet;
            // 
            // materialsDBDataSet
            // 
            this.materialsDBDataSet.DataSetName = "MaterialsDBDataSet";
            this.materialsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialTextBox
            // 
            this.materialTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialsBindingSource, "Material", true));
            this.materialTextBox.Location = new System.Drawing.Point(250, 95);
            this.materialTextBox.Name = "materialTextBox";
            this.materialTextBox.Size = new System.Drawing.Size(323, 38);
            this.materialTextBox.TabIndex = 40;
            // 
            // tensileStrengthTextBox
            // 
            this.tensileStrengthTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tensileStrengthTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialsBindingSource, "TensileStrength", true));
            this.tensileStrengthTextBox.Location = new System.Drawing.Point(250, 139);
            this.tensileStrengthTextBox.Name = "tensileStrengthTextBox";
            this.tensileStrengthTextBox.Size = new System.Drawing.Size(323, 38);
            this.tensileStrengthTextBox.TabIndex = 42;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.addNewBtn);
            this.panel6.Controls.Add(this.saveBtn);
            this.panel6.Controls.Add(this.deleteBtn);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(1464, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(241, 303);
            this.panel6.TabIndex = 10;
            // 
            // addNewBtn
            // 
            this.addNewBtn.BackColor = System.Drawing.SystemColors.Info;
            this.addNewBtn.Font = new System.Drawing.Font("Cambria", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewBtn.Location = new System.Drawing.Point(60, 36);
            this.addNewBtn.Name = "addNewBtn";
            this.addNewBtn.Size = new System.Drawing.Size(119, 48);
            this.addNewBtn.TabIndex = 28;
            this.addNewBtn.Text = "Add";
            this.addNewBtn.UseVisualStyleBackColor = false;
            this.addNewBtn.Click += new System.EventHandler(this.BindingNavigatorAddNewItem_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.saveBtn.Font = new System.Drawing.Font("Cambria", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(60, 126);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(119, 48);
            this.saveBtn.TabIndex = 26;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.MaterialsBindingNavigatorSaveItem_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.deleteBtn.Font = new System.Drawing.Font("Cambria", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(60, 216);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(119, 48);
            this.deleteBtn.TabIndex = 27;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.BindingNavigatorDeleteItem_Click);
            // 
            // materialsDataGridView
            // 
            this.materialsDataGridView.AllowUserToAddRows = false;
            this.materialsDataGridView.AllowUserToOrderColumns = true;
            this.materialsDataGridView.AutoGenerateColumns = false;
            this.materialsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.materialsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.materialDataGridViewTextBoxColumn,
            this.tensileStrengthDataGridViewTextBoxColumn});
            this.materialsDataGridView.DataSource = this.materialsBindingSource;
            this.materialsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.materialsDataGridView.Name = "materialsDataGridView";
            this.materialsDataGridView.RowTemplate.Height = 40;
            this.materialsDataGridView.Size = new System.Drawing.Size(808, 303);
            this.materialsDataGridView.TabIndex = 8;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materialDataGridViewTextBoxColumn
            // 
            this.materialDataGridViewTextBoxColumn.DataPropertyName = "Material";
            this.materialDataGridViewTextBoxColumn.HeaderText = "Material";
            this.materialDataGridViewTextBoxColumn.Name = "materialDataGridViewTextBoxColumn";
            // 
            // tensileStrengthDataGridViewTextBoxColumn
            // 
            this.tensileStrengthDataGridViewTextBoxColumn.DataPropertyName = "TensileStrength";
            this.tensileStrengthDataGridViewTextBoxColumn.HeaderText = "TensileStrength";
            this.tensileStrengthDataGridViewTextBoxColumn.Name = "tensileStrengthDataGridViewTextBoxColumn";
            // 
            // materialsTableAdapter
            // 
            this.materialsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MaterialsTableAdapter = this.materialsTableAdapter;
            this.tableAdapterManager.UpdateOrder = MyCAD.MaterialsDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel7.Controls.Add(this.label1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 359);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1708, 60);
            this.panel7.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(774, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inputs";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 419);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1708, 240);
            this.panel2.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel10, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 60);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1708, 240);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(844, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(844, 240);
            this.panel3.TabIndex = 42;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label12);
            this.panel8.Controls.Add(this.parent_material_thickness_textBox);
            this.panel8.Controls.Add(this.label13);
            this.panel8.Controls.Add(this.label14);
            this.panel8.Controls.Add(this.label15);
            this.panel8.Controls.Add(this.weld_size_textBox);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(844, 240);
            this.panel8.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(288, 84);
            this.label12.TabIndex = 38;
            this.label12.Text = "Suggested parent material thicknes: ";
            // 
            // parent_material_thickness_textBox
            // 
            this.parent_material_thickness_textBox.Enabled = false;
            this.parent_material_thickness_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parent_material_thickness_textBox.Location = new System.Drawing.Point(360, 151);
            this.parent_material_thickness_textBox.Name = "parent_material_thickness_textBox";
            this.parent_material_thickness_textBox.Size = new System.Drawing.Size(327, 41);
            this.parent_material_thickness_textBox.TabIndex = 39;
            this.parent_material_thickness_textBox.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(693, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 36);
            this.label13.TabIndex = 43;
            this.label13.Text = "in.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(8, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(288, 36);
            this.label14.TabIndex = 40;
            this.label14.Text = "Weld (Leg) size (W):";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(693, 154);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 36);
            this.label15.TabIndex = 42;
            this.label15.Text = "in.";
            // 
            // weld_size_textBox
            // 
            this.weld_size_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weld_size_textBox.Location = new System.Drawing.Point(360, 75);
            this.weld_size_textBox.Name = "weld_size_textBox";
            this.weld_size_textBox.Size = new System.Drawing.Size(327, 41);
            this.weld_size_textBox.TabIndex = 41;
            this.weld_size_textBox.Text = "0";
            this.weld_size_textBox.TextChanged += new System.EventHandler(this.Weld_size_textBox_TextChanged);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.panel9);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(3, 3);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(5);
            this.panel10.Size = new System.Drawing.Size(838, 234);
            this.panel10.TabIndex = 13;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label19);
            this.panel9.Controls.Add(this.Mz_textBox);
            this.panel9.Controls.Add(this.Mx_textBox);
            this.panel9.Controls.Add(this.label20);
            this.panel9.Controls.Add(this.label21);
            this.panel9.Controls.Add(this.My_textBox);
            this.panel9.Controls.Add(this.label22);
            this.panel9.Controls.Add(this.Fx_textBox);
            this.panel9.Controls.Add(this.label23);
            this.panel9.Controls.Add(this.Fy_textBox);
            this.panel9.Controls.Add(this.label24);
            this.panel9.Controls.Add(this.Fz_textBox);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(5, 5);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(828, 224);
            this.panel9.TabIndex = 38;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(285, 29);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 36);
            this.label19.TabIndex = 44;
            this.label19.Text = "Mx: ";
            // 
            // Mz_textBox
            // 
            this.Mz_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mz_textBox.Location = new System.Drawing.Point(365, 143);
            this.Mz_textBox.Name = "Mz_textBox";
            this.Mz_textBox.Size = new System.Drawing.Size(165, 41);
            this.Mz_textBox.TabIndex = 49;
            this.Mz_textBox.Text = "0";
            // 
            // Mx_textBox
            // 
            this.Mx_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mx_textBox.Location = new System.Drawing.Point(365, 18);
            this.Mx_textBox.Name = "Mx_textBox";
            this.Mx_textBox.Size = new System.Drawing.Size(165, 41);
            this.Mx_textBox.TabIndex = 45;
            this.Mx_textBox.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(285, 151);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(71, 36);
            this.label20.TabIndex = 48;
            this.label20.Text = "Mz: ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(285, 89);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(71, 36);
            this.label21.TabIndex = 46;
            this.label21.Text = "My: ";
            // 
            // My_textBox
            // 
            this.My_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.My_textBox.Location = new System.Drawing.Point(365, 84);
            this.My_textBox.Name = "My_textBox";
            this.My_textBox.Size = new System.Drawing.Size(165, 41);
            this.My_textBox.TabIndex = 47;
            this.My_textBox.Text = "0";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(16, 28);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(64, 36);
            this.label22.TabIndex = 38;
            this.label22.Text = "Fx: ";
            // 
            // Fx_textBox
            // 
            this.Fx_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fx_textBox.Location = new System.Drawing.Point(96, 21);
            this.Fx_textBox.Name = "Fx_textBox";
            this.Fx_textBox.Size = new System.Drawing.Size(164, 41);
            this.Fx_textBox.TabIndex = 39;
            this.Fx_textBox.Text = "0";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(16, 89);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(64, 36);
            this.label23.TabIndex = 40;
            this.label23.Text = "Fy: ";
            // 
            // Fy_textBox
            // 
            this.Fy_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fy_textBox.Location = new System.Drawing.Point(96, 82);
            this.Fy_textBox.Name = "Fy_textBox";
            this.Fy_textBox.Size = new System.Drawing.Size(164, 41);
            this.Fy_textBox.TabIndex = 41;
            this.Fy_textBox.Text = "0";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(16, 150);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(64, 36);
            this.label24.TabIndex = 42;
            this.label24.Text = "Fz: ";
            // 
            // Fz_textBox
            // 
            this.Fz_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fz_textBox.Location = new System.Drawing.Point(96, 143);
            this.Fz_textBox.Name = "Fz_textBox";
            this.Fz_textBox.Size = new System.Drawing.Size(164, 41);
            this.Fz_textBox.TabIndex = 43;
            this.Fz_textBox.Text = "0";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel11.Controls.Add(this.label2);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 659);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1708, 60);
            this.panel11.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(774, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "Output";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.FoSLabel);
            this.panel12.Controls.Add(this.ResultantForceLabel);
            this.panel12.Controls.Add(this.label8);
            this.panel12.Controls.Add(this.AllowableForceLabel);
            this.panel12.Controls.Add(this.label6);
            this.panel12.Controls.Add(this.label5);
            this.panel12.Controls.Add(this.label4);
            this.panel12.Controls.Add(this.label3);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(3, 3);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1702, 249);
            this.panel12.TabIndex = 8;
            // 
            // FoSLabel
            // 
            this.FoSLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FoSLabel.AutoSize = true;
            this.FoSLabel.Location = new System.Drawing.Point(1479, 91);
            this.FoSLabel.Name = "FoSLabel";
            this.FoSLabel.Size = new System.Drawing.Size(67, 32);
            this.FoSLabel.TabIndex = 10;
            this.FoSLabel.Text = "FoS";
            // 
            // ResultantForceLabel
            // 
            this.ResultantForceLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ResultantForceLabel.AutoSize = true;
            this.ResultantForceLabel.Location = new System.Drawing.Point(1015, 146);
            this.ResultantForceLabel.Name = "ResultantForceLabel";
            this.ResultantForceLabel.Size = new System.Drawing.Size(206, 32);
            this.ResultantForceLabel.TabIndex = 9;
            this.ResultantForceLabel.Text = "Resultant force";
            this.ResultantForceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(852, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(532, 32);
            this.label8.TabIndex = 8;
            this.label8.Text = " ________________________________ = ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AllowableForceLabel
            // 
            this.AllowableForceLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AllowableForceLabel.AutoSize = true;
            this.AllowableForceLabel.Location = new System.Drawing.Point(911, 61);
            this.AllowableForceLabel.Name = "AllowableForceLabel";
            this.AllowableForceLabel.Size = new System.Drawing.Size(414, 32);
            this.AllowableForceLabel.TabIndex = 7;
            this.AllowableForceLabel.Text = "Allowable force per inch of weld";
            this.AllowableForceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(428, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "Resultant force";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(555, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = " = ________________________________ = ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(414, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Allowable force per inch of weld";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "FoS";
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Location = new System.Drawing.Point(1398, -1);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(282, 73);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1096, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 73);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Ok_btn_Click);
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.button1);
            this.panel13.Controls.Add(this.CancelButton);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(3, 258);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(1702, 148);
            this.panel13.TabIndex = 9;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.panel13, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel12, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 719);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.35294F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.64706F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1708, 409);
            this.tableLayoutPanel3.TabIndex = 10;
            // 
            // Input_Values
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1708, 1252);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1740, 1340);
            this.Name = "Input_Values";
            this.Load += new System.EventHandler(this.Input_Values_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsDBDataSet)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.materialsDataGridView)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView materialsDataGridView;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button addNewBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label11;
        private MaterialsDBDataSet materialsDBDataSet;
        private System.Windows.Forms.BindingSource materialsBindingSource;
        private MaterialsDBDataSetTableAdapters.MaterialsTableAdapter materialsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensileStrengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox materialTextBox;
        private System.Windows.Forms.TextBox tensileStrengthTextBox;
        private MaterialsDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox parent_material_thickness_textBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox weld_size_textBox;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox Mz_textBox;
        private System.Windows.Forms.TextBox Mx_textBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox My_textBox;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox Fx_textBox;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox Fy_textBox;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox Fz_textBox;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label FoSLabel;
        private System.Windows.Forms.Label ResultantForceLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label AllowableForceLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}