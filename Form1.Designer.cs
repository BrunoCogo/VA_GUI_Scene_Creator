namespace VA_GUI
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bt_LoadCustom = new System.Windows.Forms.Button();
            this.bt_ExportCustom = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_battleDesc = new System.Windows.Forms.CheckBox();
            this.cb_StarterAdeventure = new System.Windows.Forms.CheckBox();
            this.Num_Chance = new System.Windows.Forms.NumericUpDown();
            this.label_Chance = new System.Windows.Forms.Label();
            this.tb_Desc = new System.Windows.Forms.RichTextBox();
            this.bt_newNode = new System.Windows.Forms.Button();
            this.tb_chance = new System.Windows.Forms.TrackBar();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.cb_EnemyLink = new System.Windows.Forms.ComboBox();
            this.num_OptionCount = new System.Windows.Forms.NumericUpDown();
            this.cb_Type = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ct_Delete = new System.Windows.Forms.Button();
            this.cb_CurrentNode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Edit = new System.Windows.Forms.Button();
            this.bt_AddNode = new System.Windows.Forms.Button();
            this.tb_Title = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv_Olinking = new System.Windows.Forms.DataGridView();
            this.cl_OptName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_OptionLink = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cl_del = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label_Enemy = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_place = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.bt_AddPlace = new System.Windows.Forms.Button();
            this.bt_delPlace = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Chance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_chance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_OptionCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Olinking)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_LoadCustom
            // 
            this.bt_LoadCustom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_LoadCustom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_LoadCustom.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_LoadCustom.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_LoadCustom.Location = new System.Drawing.Point(12, 9);
            this.bt_LoadCustom.Name = "bt_LoadCustom";
            this.bt_LoadCustom.Size = new System.Drawing.Size(148, 27);
            this.bt_LoadCustom.TabIndex = 0;
            this.bt_LoadCustom.Text = "Load Custom Folder";
            this.bt_LoadCustom.UseVisualStyleBackColor = true;
            this.bt_LoadCustom.Click += new System.EventHandler(this.bt_LoadCustom_Click);
            // 
            // bt_ExportCustom
            // 
            this.bt_ExportCustom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_ExportCustom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_ExportCustom.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ExportCustom.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_ExportCustom.Location = new System.Drawing.Point(166, 9);
            this.bt_ExportCustom.Name = "bt_ExportCustom";
            this.bt_ExportCustom.Size = new System.Drawing.Size(148, 27);
            this.bt_ExportCustom.TabIndex = 1;
            this.bt_ExportCustom.Text = "Save Current Place";
            this.bt_ExportCustom.UseVisualStyleBackColor = true;
            this.bt_ExportCustom.Click += new System.EventHandler(this.Bt_ExportCustom_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cb_battleDesc);
            this.panel1.Controls.Add(this.cb_StarterAdeventure);
            this.panel1.Controls.Add(this.Num_Chance);
            this.panel1.Controls.Add(this.label_Chance);
            this.panel1.Controls.Add(this.tb_Desc);
            this.panel1.Controls.Add(this.bt_newNode);
            this.panel1.Controls.Add(this.tb_chance);
            this.panel1.Controls.Add(this.tb_ID);
            this.panel1.Controls.Add(this.cb_EnemyLink);
            this.panel1.Controls.Add(this.num_OptionCount);
            this.panel1.Controls.Add(this.cb_Type);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.ct_Delete);
            this.panel1.Controls.Add(this.cb_CurrentNode);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bt_Edit);
            this.panel1.Controls.Add(this.bt_AddNode);
            this.panel1.Controls.Add(this.tb_Title);
            this.panel1.Controls.Add(this.tb_Name);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dgv_Olinking);
            this.panel1.Controls.Add(this.label_Enemy);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-3, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 537);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cb_battleDesc
            // 
            this.cb_battleDesc.AutoSize = true;
            this.cb_battleDesc.BackColor = System.Drawing.Color.Transparent;
            this.cb_battleDesc.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_battleDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cb_battleDesc.Location = new System.Drawing.Point(234, 123);
            this.cb_battleDesc.Name = "cb_battleDesc";
            this.cb_battleDesc.Size = new System.Drawing.Size(261, 21);
            this.cb_battleDesc.TabIndex = 33;
            this.cb_battleDesc.Text = "Battle Description (combat only)";
            this.cb_battleDesc.UseVisualStyleBackColor = false;
            this.cb_battleDesc.Visible = false;
            this.cb_battleDesc.CheckedChanged += new System.EventHandler(this.cb_battleDesc_CheckedChanged);
            // 
            // cb_StarterAdeventure
            // 
            this.cb_StarterAdeventure.AutoSize = true;
            this.cb_StarterAdeventure.BackColor = System.Drawing.Color.Transparent;
            this.cb_StarterAdeventure.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_StarterAdeventure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cb_StarterAdeventure.Location = new System.Drawing.Point(581, 90);
            this.cb_StarterAdeventure.Name = "cb_StarterAdeventure";
            this.cb_StarterAdeventure.Size = new System.Drawing.Size(213, 21);
            this.cb_StarterAdeventure.TabIndex = 32;
            this.cb_StarterAdeventure.Text = "Will be starter adventure?";
            this.cb_StarterAdeventure.UseVisualStyleBackColor = false;
            this.cb_StarterAdeventure.CheckedChanged += new System.EventHandler(this.cb_StarterAdeventure_CheckedChanged);
            // 
            // Num_Chance
            // 
            this.Num_Chance.DecimalPlaces = 2;
            this.Num_Chance.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Num_Chance.Location = new System.Drawing.Point(507, 61);
            this.Num_Chance.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Num_Chance.Name = "Num_Chance";
            this.Num_Chance.Size = new System.Drawing.Size(57, 20);
            this.Num_Chance.TabIndex = 31;
            this.Num_Chance.Visible = false;
            this.Num_Chance.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label_Chance
            // 
            this.label_Chance.AutoSize = true;
            this.label_Chance.BackColor = System.Drawing.Color.Transparent;
            this.label_Chance.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Chance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label_Chance.Location = new System.Drawing.Point(444, 61);
            this.label_Chance.Name = "label_Chance";
            this.label_Chance.Size = new System.Drawing.Size(57, 17);
            this.label_Chance.TabIndex = 30;
            this.label_Chance.Text = "Chance";
            this.label_Chance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_Chance.Visible = false;
            this.label_Chance.Click += new System.EventHandler(this.label_Chance_Click);
            // 
            // tb_Desc
            // 
            this.tb_Desc.Location = new System.Drawing.Point(148, 370);
            this.tb_Desc.Name = "tb_Desc";
            this.tb_Desc.Size = new System.Drawing.Size(681, 119);
            this.tb_Desc.TabIndex = 29;
            this.tb_Desc.Text = "";
            this.tb_Desc.TextChanged += new System.EventHandler(this.tb_Desc_TextChanged);
            // 
            // bt_newNode
            // 
            this.bt_newNode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_newNode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_newNode.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_newNode.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_newNode.Location = new System.Drawing.Point(459, 31);
            this.bt_newNode.Name = "bt_newNode";
            this.bt_newNode.Size = new System.Drawing.Size(341, 24);
            this.bt_newNode.TabIndex = 28;
            this.bt_newNode.Text = "Clear Node (dosen\'t update node)";
            this.bt_newNode.UseVisualStyleBackColor = true;
            this.bt_newNode.Click += new System.EventHandler(this.bt_newNode_Click);
            // 
            // tb_chance
            // 
            this.tb_chance.LargeChange = 10;
            this.tb_chance.Location = new System.Drawing.Point(569, 61);
            this.tb_chance.Maximum = 100;
            this.tb_chance.Name = "tb_chance";
            this.tb_chance.Size = new System.Drawing.Size(233, 45);
            this.tb_chance.SmallChange = 5;
            this.tb_chance.TabIndex = 6;
            this.tb_chance.Visible = false;
            this.tb_chance.Scroll += new System.EventHandler(this.tb_chance_Scroll);
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(149, 9);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(206, 20);
            this.tb_ID.TabIndex = 0;
            this.tb_ID.TextChanged += new System.EventHandler(this.tb_ID_TextChanged);
            // 
            // cb_EnemyLink
            // 
            this.cb_EnemyLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.cb_EnemyLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_EnemyLink.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cb_EnemyLink.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_EnemyLink.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cb_EnemyLink.FormattingEnabled = true;
            this.cb_EnemyLink.Location = new System.Drawing.Point(567, 122);
            this.cb_EnemyLink.Name = "cb_EnemyLink";
            this.cb_EnemyLink.Size = new System.Drawing.Size(262, 23);
            this.cb_EnemyLink.TabIndex = 7;
            this.cb_EnemyLink.Visible = false;
            this.cb_EnemyLink.SelectedIndexChanged += new System.EventHandler(this.cb_EnemyLink_SelectedIndexChanged);
            // 
            // num_OptionCount
            // 
            this.num_OptionCount.Location = new System.Drawing.Point(148, 123);
            this.num_OptionCount.Name = "num_OptionCount";
            this.num_OptionCount.ReadOnly = true;
            this.num_OptionCount.Size = new System.Drawing.Size(80, 20);
            this.num_OptionCount.TabIndex = 4;
            this.num_OptionCount.Visible = false;
            this.num_OptionCount.ValueChanged += new System.EventHandler(this.num_OptionCount_ValueChanged);
            // 
            // cb_Type
            // 
            this.cb_Type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.cb_Type.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_Type.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cb_Type.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Type.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cb_Type.FormattingEnabled = true;
            this.cb_Type.Items.AddRange(new object[] {
            "noncombat",
            "combat",
            "nothing"});
            this.cb_Type.Location = new System.Drawing.Point(149, 92);
            this.cb_Type.Name = "cb_Type";
            this.cb_Type.Size = new System.Drawing.Size(207, 23);
            this.cb_Type.TabIndex = 3;
            this.cb_Type.SelectedIndexChanged += new System.EventHandler(this.cb_Type_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label9.Location = new System.Drawing.Point(105, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "ID:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // ct_Delete
            // 
            this.ct_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ct_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ct_Delete.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ct_Delete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ct_Delete.Location = new System.Drawing.Point(695, 495);
            this.ct_Delete.Name = "ct_Delete";
            this.ct_Delete.Size = new System.Drawing.Size(134, 27);
            this.ct_Delete.TabIndex = 12;
            this.ct_Delete.Text = "Delete Node";
            this.ct_Delete.UseVisualStyleBackColor = true;
            this.ct_Delete.Click += new System.EventHandler(this.ct_Delete_Click);
            // 
            // cb_CurrentNode
            // 
            this.cb_CurrentNode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.cb_CurrentNode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_CurrentNode.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cb_CurrentNode.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_CurrentNode.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cb_CurrentNode.FormattingEnabled = true;
            this.cb_CurrentNode.Location = new System.Drawing.Point(559, 4);
            this.cb_CurrentNode.Name = "cb_CurrentNode";
            this.cb_CurrentNode.Size = new System.Drawing.Size(241, 23);
            this.cb_CurrentNode.TabIndex = 5;
            this.cb_CurrentNode.SelectedIndexChanged += new System.EventHandler(this.cb_CurrentNode_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(452, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Current Node";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bt_Edit
            // 
            this.bt_Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_Edit.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Edit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_Edit.Location = new System.Drawing.Point(555, 495);
            this.bt_Edit.Name = "bt_Edit";
            this.bt_Edit.Size = new System.Drawing.Size(134, 27);
            this.bt_Edit.TabIndex = 11;
            this.bt_Edit.Text = "Edit Node";
            this.bt_Edit.UseVisualStyleBackColor = true;
            this.bt_Edit.Click += new System.EventHandler(this.bt_Edit_Click);
            // 
            // bt_AddNode
            // 
            this.bt_AddNode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_AddNode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_AddNode.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_AddNode.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_AddNode.Location = new System.Drawing.Point(444, 495);
            this.bt_AddNode.Name = "bt_AddNode";
            this.bt_AddNode.Size = new System.Drawing.Size(106, 27);
            this.bt_AddNode.TabIndex = 10;
            this.bt_AddNode.Text = "Add Node";
            this.bt_AddNode.UseVisualStyleBackColor = true;
            this.bt_AddNode.Click += new System.EventHandler(this.bt_AddNode_Click);
            // 
            // tb_Title
            // 
            this.tb_Title.Location = new System.Drawing.Point(149, 64);
            this.tb_Title.Name = "tb_Title";
            this.tb_Title.Size = new System.Drawing.Size(206, 20);
            this.tb_Title.TabIndex = 2;
            this.tb_Title.TextChanged += new System.EventHandler(this.tb_Title_TextChanged);
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(149, 36);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(206, 20);
            this.tb_Name.TabIndex = 1;
            this.tb_Name.TextChanged += new System.EventHandler(this.tb_Name_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label8.Location = new System.Drawing.Point(42, 370);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Description:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // dgv_Olinking
            // 
            this.dgv_Olinking.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Olinking.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dgv_Olinking.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = "---";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Olinking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Olinking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Olinking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_OptName,
            this.cl_OptionLink,
            this.cl_del});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Olinking.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Olinking.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv_Olinking.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgv_Olinking.Location = new System.Drawing.Point(149, 156);
            this.dgv_Olinking.MultiSelect = false;
            this.dgv_Olinking.Name = "dgv_Olinking";
            this.dgv_Olinking.Size = new System.Drawing.Size(680, 198);
            this.dgv_Olinking.TabIndex = 8;
            this.dgv_Olinking.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Olinking_CellValueChanged);
            this.dgv_Olinking.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Olinking_CellValueChanged);
            // 
            // cl_OptName
            // 
            this.cl_OptName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cl_OptName.HeaderText = "Option";
            this.cl_OptName.Name = "cl_OptName";
            this.cl_OptName.ReadOnly = true;
            this.cl_OptName.Width = 63;
            // 
            // cl_OptionLink
            // 
            this.cl_OptionLink.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.cl_OptionLink.DefaultCellStyle = dataGridViewCellStyle2;
            this.cl_OptionLink.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.cl_OptionLink.HeaderText = "Linked Node";
            this.cl_OptionLink.Name = "cl_OptionLink";
            this.cl_OptionLink.Width = 74;
            // 
            // cl_del
            // 
            this.cl_del.HeaderText = "Delete Row";
            this.cl_del.Name = "cl_del";
            this.cl_del.ReadOnly = true;
            // 
            // label_Enemy
            // 
            this.label_Enemy.AutoSize = true;
            this.label_Enemy.BackColor = System.Drawing.Color.Transparent;
            this.label_Enemy.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Enemy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label_Enemy.Location = new System.Drawing.Point(502, 125);
            this.label_Enemy.Name = "label_Enemy";
            this.label_Enemy.Size = new System.Drawing.Size(59, 17);
            this.label_Enemy.TabIndex = 11;
            this.label_Enemy.Text = "Enemy:";
            this.label_Enemy.Visible = false;
            this.label_Enemy.Click += new System.EventHandler(this.label_Enemy_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Location = new System.Drawing.Point(13, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Option Linking:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(30, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Option Count:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(86, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Name:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(91, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Type:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(89, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Title:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cb_place
            // 
            this.cb_place.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.cb_place.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_place.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cb_place.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_place.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cb_place.FormattingEnabled = true;
            this.cb_place.Location = new System.Drawing.Point(139, 41);
            this.cb_place.Name = "cb_place";
            this.cb_place.Size = new System.Drawing.Size(240, 23);
            this.cb_place.TabIndex = 2;
            this.cb_place.SelectedIndexChanged += new System.EventHandler(this.ModifyWorkspace);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label13.Location = new System.Drawing.Point(18, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 17);
            this.label13.TabIndex = 27;
            this.label13.Text = "Working Place";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // bt_AddPlace
            // 
            this.bt_AddPlace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_AddPlace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_AddPlace.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_AddPlace.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_AddPlace.Location = new System.Drawing.Point(385, 39);
            this.bt_AddPlace.Name = "bt_AddPlace";
            this.bt_AddPlace.Size = new System.Drawing.Size(157, 27);
            this.bt_AddPlace.TabIndex = 3;
            this.bt_AddPlace.Text = "Add place";
            this.bt_AddPlace.UseVisualStyleBackColor = true;
            this.bt_AddPlace.Click += new System.EventHandler(this.bt_AddPlace_Click);
            // 
            // bt_delPlace
            // 
            this.bt_delPlace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_delPlace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_delPlace.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_delPlace.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_delPlace.Location = new System.Drawing.Point(552, 39);
            this.bt_delPlace.Name = "bt_delPlace";
            this.bt_delPlace.Size = new System.Drawing.Size(147, 27);
            this.bt_delPlace.TabIndex = 4;
            this.bt_delPlace.Text = "Delete place";
            this.bt_delPlace.UseVisualStyleBackColor = true;
            this.bt_delPlace.Click += new System.EventHandler(this.bt_delPlace_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(786, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 30);
            this.button1.TabIndex = 28;
            this.button1.Text = "Donate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(320, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 27);
            this.button2.TabIndex = 29;
            this.button2.Text = "Export ZIP Pack";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(855, 623);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_delPlace);
            this.Controls.Add(this.bt_AddPlace);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cb_place);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_ExportCustom);
            this.Controls.Add(this.bt_LoadCustom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Vore Adventure Scene Editor By Cogo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Chance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_chance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_OptionCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Olinking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_LoadCustom;
        private System.Windows.Forms.Button bt_ExportCustom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ct_Delete;
        private System.Windows.Forms.Button bt_Edit;
        private System.Windows.Forms.Button bt_AddNode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_Enemy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_CurrentNode;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cb_EnemyLink;
        public System.Windows.Forms.NumericUpDown num_OptionCount;
        public System.Windows.Forms.ComboBox cb_Type;
        public System.Windows.Forms.TextBox tb_Title;
        public System.Windows.Forms.TextBox tb_Name;
        public System.Windows.Forms.DataGridView dgv_Olinking;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.ComboBox cb_place;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button bt_AddPlace;
        private System.Windows.Forms.Button bt_delPlace;
        private System.Windows.Forms.TrackBar tb_chance;
        private System.Windows.Forms.Button bt_newNode;
        private System.Windows.Forms.RichTextBox tb_Desc;
        private System.Windows.Forms.NumericUpDown Num_Chance;
        private System.Windows.Forms.Label label_Chance;
        private System.Windows.Forms.CheckBox cb_StarterAdeventure;
        private System.Windows.Forms.CheckBox cb_battleDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_OptName;
        private System.Windows.Forms.DataGridViewComboBoxColumn cl_OptionLink;
        private System.Windows.Forms.DataGridViewButtonColumn cl_del;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

