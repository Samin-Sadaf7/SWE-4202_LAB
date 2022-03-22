namespace IUT_Result_Processing_App
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
            this.StudentList = new System.Windows.Forms.ListBox();
            this.ShowResultLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchIDText = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ShowResult2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StudentList
            // 
            this.StudentList.FormattingEnabled = true;
            this.StudentList.ItemHeight = 20;
            this.StudentList.Location = new System.Drawing.Point(12, 141);
            this.StudentList.Name = "StudentList";
            this.StudentList.Size = new System.Drawing.Size(568, 504);
            this.StudentList.TabIndex = 0;
            // 
            // ShowResultLabel
            // 
            this.ShowResultLabel.Location = new System.Drawing.Point(610, 157);
            this.ShowResultLabel.Name = "ShowResultLabel";
            this.ShowResultLabel.Size = new System.Drawing.Size(479, 230);
            this.ShowResultLabel.TabIndex = 1;
            this.ShowResultLabel.Text = "Your Result:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "Object Oriented Concepts 1";
            // 
            // SearchIDText
            // 
            this.SearchIDText.Location = new System.Drawing.Point(614, 112);
            this.SearchIDText.Name = "SearchIDText";
            this.SearchIDText.Size = new System.Drawing.Size(344, 26);
            this.SearchIDText.TabIndex = 3;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(980, 112);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(127, 42);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(575, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID                         Name                                Percentage        " +
    "Grade";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ShowResult2
            // 
            this.ShowResult2.Location = new System.Drawing.Point(610, 416);
            this.ShowResult2.Name = "ShowResult2";
            this.ShowResult2.Size = new System.Drawing.Size(479, 204);
            this.ShowResult2.TabIndex = 6;
            this.ShowResult2.Click += new System.EventHandler(this.ShowResult2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 657);
            this.Controls.Add(this.ShowResult2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchIDText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShowResultLabel);
            this.Controls.Add(this.StudentList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox StudentList;
        private System.Windows.Forms.Label ShowResultLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchIDText;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ShowResult2;
    }
}

