namespace VA_GUI
{
    partial class Output_Previewer
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
            this.Textbox_PREVIEW = new System.Windows.Forms.TextBox();
            this.bt_saveFile = new System.Windows.Forms.Button();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_nodeCount = new System.Windows.Forms.Label();
            this.tb_Nodes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Enemies = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Invalid = new System.Windows.Forms.TextBox();
            this.bt_Credits = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Textbox_PREVIEW
            // 
            this.Textbox_PREVIEW.AcceptsReturn = true;
            this.Textbox_PREVIEW.AcceptsTab = true;
            this.Textbox_PREVIEW.BackColor = System.Drawing.SystemColors.Menu;
            this.Textbox_PREVIEW.Location = new System.Drawing.Point(12, 42);
            this.Textbox_PREVIEW.Multiline = true;
            this.Textbox_PREVIEW.Name = "Textbox_PREVIEW";
            this.Textbox_PREVIEW.ReadOnly = true;
            this.Textbox_PREVIEW.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Textbox_PREVIEW.Size = new System.Drawing.Size(589, 692);
            this.Textbox_PREVIEW.TabIndex = 0;
            // 
            // bt_saveFile
            // 
            this.bt_saveFile.Location = new System.Drawing.Point(12, 741);
            this.bt_saveFile.Name = "bt_saveFile";
            this.bt_saveFile.Size = new System.Drawing.Size(165, 23);
            this.bt_saveFile.TabIndex = 3;
            this.bt_saveFile.Text = "Save File";
            this.bt_saveFile.UseVisualStyleBackColor = true;
            this.bt_saveFile.Click += new System.EventHandler(this.bt_saveFile_Click);
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.Location = new System.Drawing.Point(653, 742);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(165, 23);
            this.bt_Cancel.TabIndex = 4;
            this.bt_Cancel.Text = "Close Preview";
            this.bt_Cancel.UseVisualStyleBackColor = true;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Number Of Nodes: ";
            // 
            // lb_nodeCount
            // 
            this.lb_nodeCount.AutoSize = true;
            this.lb_nodeCount.Location = new System.Drawing.Point(105, 13);
            this.lb_nodeCount.Name = "lb_nodeCount";
            this.lb_nodeCount.Size = new System.Drawing.Size(29, 13);
            this.lb_nodeCount.TabIndex = 6;
            this.lb_nodeCount.Text = "{##}";
            // 
            // tb_Nodes
            // 
            this.tb_Nodes.AcceptsReturn = true;
            this.tb_Nodes.AcceptsTab = true;
            this.tb_Nodes.BackColor = System.Drawing.SystemColors.Menu;
            this.tb_Nodes.Location = new System.Drawing.Point(607, 58);
            this.tb_Nodes.Multiline = true;
            this.tb_Nodes.Name = "tb_Nodes";
            this.tb_Nodes.ReadOnly = true;
            this.tb_Nodes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Nodes.Size = new System.Drawing.Size(211, 172);
            this.tb_Nodes.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(604, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nodes not referenced:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(604, 469);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Enemies used  referenced:";
            // 
            // tb_Enemies
            // 
            this.tb_Enemies.AcceptsReturn = true;
            this.tb_Enemies.AcceptsTab = true;
            this.tb_Enemies.BackColor = System.Drawing.SystemColors.Menu;
            this.tb_Enemies.Location = new System.Drawing.Point(607, 485);
            this.tb_Enemies.Multiline = true;
            this.tb_Enemies.Name = "tb_Enemies";
            this.tb_Enemies.ReadOnly = true;
            this.tb_Enemies.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_Enemies.Size = new System.Drawing.Size(211, 249);
            this.tb_Enemies.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(604, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Invalid Reference:";
            // 
            // tb_Invalid
            // 
            this.tb_Invalid.AcceptsReturn = true;
            this.tb_Invalid.AcceptsTab = true;
            this.tb_Invalid.BackColor = System.Drawing.SystemColors.Menu;
            this.tb_Invalid.Location = new System.Drawing.Point(607, 266);
            this.tb_Invalid.Multiline = true;
            this.tb_Invalid.Name = "tb_Invalid";
            this.tb_Invalid.ReadOnly = true;
            this.tb_Invalid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Invalid.Size = new System.Drawing.Size(211, 172);
            this.tb_Invalid.TabIndex = 11;
            // 
            // bt_Credits
            // 
            this.bt_Credits.Location = new System.Drawing.Point(212, 8);
            this.bt_Credits.Name = "bt_Credits";
            this.bt_Credits.Size = new System.Drawing.Size(122, 23);
            this.bt_Credits.TabIndex = 13;
            this.bt_Credits.Text = "Add Credits";
            this.bt_Credits.UseVisualStyleBackColor = true;
            this.bt_Credits.Click += new System.EventHandler(this.bt_Credits_Click);
            // 
            // Output_Previewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 777);
            this.Controls.Add(this.bt_Credits);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_Invalid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Enemies);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Nodes);
            this.Controls.Add(this.lb_nodeCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.bt_saveFile);
            this.Controls.Add(this.Textbox_PREVIEW);
            this.Name = "Output_Previewer";
            this.Text = "Output_Previewer";
            this.Load += new System.EventHandler(this.Output_Previewer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Textbox_PREVIEW;
        private System.Windows.Forms.Button bt_saveFile;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_nodeCount;
        private System.Windows.Forms.TextBox tb_Nodes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Enemies;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Invalid;
        private System.Windows.Forms.Button bt_Credits;
    }
}