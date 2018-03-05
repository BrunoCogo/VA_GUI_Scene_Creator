namespace VA_GUI
{
    partial class ZipperForm
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
            this.PlacesCheckList = new System.Windows.Forms.CheckedListBox();
            this.EnemyChecklist = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PlacesCheckList
            // 
            this.PlacesCheckList.FormattingEnabled = true;
            this.PlacesCheckList.Location = new System.Drawing.Point(12, 29);
            this.PlacesCheckList.Name = "PlacesCheckList";
            this.PlacesCheckList.Size = new System.Drawing.Size(199, 364);
            this.PlacesCheckList.TabIndex = 0;
            this.PlacesCheckList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.PlacesCheckList_ItemCheck);
            // 
            // EnemyChecklist
            // 
            this.EnemyChecklist.FormattingEnabled = true;
            this.EnemyChecklist.Location = new System.Drawing.Point(217, 29);
            this.EnemyChecklist.Name = "EnemyChecklist";
            this.EnemyChecklist.Size = new System.Drawing.Size(199, 364);
            this.EnemyChecklist.TabIndex = 1;
            this.EnemyChecklist.SelectedIndexChanged += new System.EventHandler(this.checkedListBox2_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Export Zip";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Places";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enemies";
            // 
            // ZipperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 434);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EnemyChecklist);
            this.Controls.Add(this.PlacesCheckList);
            this.Name = "ZipperForm";
            this.Text = "ZipperForm";
            this.Load += new System.EventHandler(this.ZipperForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox PlacesCheckList;
        private System.Windows.Forms.CheckedListBox EnemyChecklist;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}