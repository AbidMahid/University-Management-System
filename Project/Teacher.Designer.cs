namespace Project
{
    partial class Teacher
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
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.teacherControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reviewProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(933, 476);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teacherControlToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1262, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // teacherControlToolStripMenuItem
            // 
            this.teacherControlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewCourseToolStripMenuItem,
            this.reviewProfileToolStripMenuItem});
            this.teacherControlToolStripMenuItem.Name = "teacherControlToolStripMenuItem";
            this.teacherControlToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.teacherControlToolStripMenuItem.Text = "Teacher Control";
            // 
            // viewCourseToolStripMenuItem
            // 
            this.viewCourseToolStripMenuItem.Name = "viewCourseToolStripMenuItem";
            this.viewCourseToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.viewCourseToolStripMenuItem.Text = "View Course";
            this.viewCourseToolStripMenuItem.Click += new System.EventHandler(this.viewCourseToolStripMenuItem_Click);
            // 
            // reviewProfileToolStripMenuItem
            // 
            this.reviewProfileToolStripMenuItem.Name = "reviewProfileToolStripMenuItem";
            this.reviewProfileToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.reviewProfileToolStripMenuItem.Text = "Review Profile";
            this.reviewProfileToolStripMenuItem.Click += new System.EventHandler(this.reviewProfileToolStripMenuItem_Click);
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 853);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Teacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem teacherControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reviewProfileToolStripMenuItem;
    }
}