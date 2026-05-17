namespace Project
{
    partial class TPE
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
            this.dgvVTPE = new System.Windows.Forms.DataGridView();
            this.btnVTPE = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVTPE)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVTPE
            // 
            this.dgvVTPE.AllowUserToAddRows = false;
            this.dgvVTPE.AllowUserToDeleteRows = false;
            this.dgvVTPE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVTPE.Location = new System.Drawing.Point(343, 169);
            this.dgvVTPE.Name = "dgvVTPE";
            this.dgvVTPE.ReadOnly = true;
            this.dgvVTPE.RowHeadersWidth = 51;
            this.dgvVTPE.RowTemplate.Height = 24;
            this.dgvVTPE.Size = new System.Drawing.Size(507, 317);
            this.dgvVTPE.TabIndex = 0;
            // 
            // btnVTPE
            // 
            this.btnVTPE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVTPE.Location = new System.Drawing.Point(430, 130);
            this.btnVTPE.Name = "btnVTPE";
            this.btnVTPE.Size = new System.Drawing.Size(114, 33);
            this.btnVTPE.TabIndex = 1;
            this.btnVTPE.Text = "View TPE";
            this.btnVTPE.UseVisualStyleBackColor = true;
            this.btnVTPE.Click += new System.EventHandler(this.btnVTPE_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(619, 130);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(114, 33);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // TPE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 853);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnVTPE);
            this.Controls.Add(this.dgvVTPE);
            this.Name = "TPE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TPE";
            this.Load += new System.EventHandler(this.TPE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVTPE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVTPE;
        private System.Windows.Forms.Button btnVTPE;
        private System.Windows.Forms.Button btnBack;
    }
}