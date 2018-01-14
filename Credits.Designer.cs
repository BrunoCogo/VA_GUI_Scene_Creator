namespace VA_GUI
{
    partial class Credits
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Author = new System.Windows.Forms.TextBox();
            this.tb_enemyAutors = new System.Windows.Forms.TextBox();
            this.tb_Ene = new System.Windows.Forms.TextBox();
            this.tb_specialThx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Done = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Place Author";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enemies Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Editors";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Special thanks";
            // 
            // tb_Author
            // 
            this.tb_Author.Location = new System.Drawing.Point(110, 45);
            this.tb_Author.Name = "tb_Author";
            this.tb_Author.Size = new System.Drawing.Size(328, 20);
            this.tb_Author.TabIndex = 4;
            // 
            // tb_enemyAutors
            // 
            this.tb_enemyAutors.Location = new System.Drawing.Point(110, 74);
            this.tb_enemyAutors.Multiline = true;
            this.tb_enemyAutors.Name = "tb_enemyAutors";
            this.tb_enemyAutors.Size = new System.Drawing.Size(328, 61);
            this.tb_enemyAutors.TabIndex = 5;
            // 
            // tb_Ene
            // 
            this.tb_Ene.Location = new System.Drawing.Point(110, 141);
            this.tb_Ene.Multiline = true;
            this.tb_Ene.Name = "tb_Ene";
            this.tb_Ene.Size = new System.Drawing.Size(328, 61);
            this.tb_Ene.TabIndex = 6;
            // 
            // tb_specialThx
            // 
            this.tb_specialThx.Location = new System.Drawing.Point(110, 215);
            this.tb_specialThx.Multiline = true;
            this.tb_specialThx.Name = "tb_specialThx";
            this.tb_specialThx.Size = new System.Drawing.Size(328, 61);
            this.tb_specialThx.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Credits";
            // 
            // Done
            // 
            this.Done.Location = new System.Drawing.Point(363, 282);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(75, 23);
            this.Done.TabIndex = 9;
            this.Done.Text = "Done";
            this.Done.UseVisualStyleBackColor = true;
            this.Done.Click += new System.EventHandler(this.Done_Click);
            // 
            // Credits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 336);
            this.Controls.Add(this.Done);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_specialThx);
            this.Controls.Add(this.tb_Ene);
            this.Controls.Add(this.tb_enemyAutors);
            this.Controls.Add(this.tb_Author);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Credits";
            this.Text = "Credits";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Author;
        private System.Windows.Forms.TextBox tb_enemyAutors;
        private System.Windows.Forms.TextBox tb_Ene;
        private System.Windows.Forms.TextBox tb_specialThx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Done;
    }
}