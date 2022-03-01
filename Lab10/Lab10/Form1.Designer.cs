namespace Lab10
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
            this.ID_TextBox = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.ShowLabel = new System.Windows.Forms.Label();
            this.EmployeeList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ID_TextBox
            // 
            this.ID_TextBox.Location = new System.Drawing.Point(700, 41);
            this.ID_TextBox.Name = "ID_TextBox";
            this.ID_TextBox.Size = new System.Drawing.Size(249, 26);
            this.ID_TextBox.TabIndex = 0;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(711, 90);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(135, 54);
            this.Search.TabIndex = 1;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // ShowLabel
            // 
            this.ShowLabel.Location = new System.Drawing.Point(707, 167);
            this.ShowLabel.Name = "ShowLabel";
            this.ShowLabel.Size = new System.Drawing.Size(318, 267);
            this.ShowLabel.TabIndex = 2;
            // 
            // EmployeeList
            // 
            this.EmployeeList.FormattingEnabled = true;
            this.EmployeeList.ItemHeight = 20;
            this.EmployeeList.Location = new System.Drawing.Point(12, 27);
            this.EmployeeList.Name = "EmployeeList";
            this.EmployeeList.Size = new System.Drawing.Size(474, 404);
            this.EmployeeList.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 450);
            this.Controls.Add(this.EmployeeList);
            this.Controls.Add(this.ShowLabel);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.ID_TextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ID_TextBox;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label ShowLabel;
        private System.Windows.Forms.ListBox EmployeeList;
    }
}

