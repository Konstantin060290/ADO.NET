namespace ITMO.WFCS.ZACHET
    {
    partial class NewCourse
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
            this.CourseIDTextBox = new System.Windows.Forms.TextBox();
            this.CourseIdLabel = new System.Windows.Forms.Label();
            this.CourseTitleLabel = new System.Windows.Forms.Label();
            this.CourseTitleTextBox = new System.Windows.Forms.TextBox();
            this.CreditsUpDown = new System.Windows.Forms.DomainUpDown();
            this.CreditsLabel = new System.Windows.Forms.Label();
            this.DepIDlabel = new System.Windows.Forms.Label();
            this.LoctextBox = new System.Windows.Forms.TextBox();
            this.Loclabel = new System.Windows.Forms.Label();
            this.DaystextBox = new System.Windows.Forms.TextBox();
            this.Dayslabel = new System.Windows.Forms.Label();
            this.Timelabel = new System.Windows.Forms.Label();
            this.TimetextBox = new System.Windows.Forms.TextBox();
            this.AddToDBButton = new System.Windows.Forms.Button();
            this.DepartmentUpDown = new System.Windows.Forms.DomainUpDown();
            this.SuspendLayout();
            // 
            // CourseIDTextBox
            // 
            this.CourseIDTextBox.Location = new System.Drawing.Point(127, 36);
            this.CourseIDTextBox.Name = "CourseIDTextBox";
            this.CourseIDTextBox.Size = new System.Drawing.Size(215, 20);
            this.CourseIDTextBox.TabIndex = 0;
            this.CourseIDTextBox.TextChanged += new System.EventHandler(this.CourseIDTextBox_TextChanged);
            // 
            // CourseIdLabel
            // 
            this.CourseIdLabel.AutoSize = true;
            this.CourseIdLabel.Location = new System.Drawing.Point(58, 39);
            this.CourseIdLabel.Name = "CourseIdLabel";
            this.CourseIdLabel.Size = new System.Drawing.Size(54, 13);
            this.CourseIdLabel.TabIndex = 1;
            this.CourseIdLabel.Text = "Course ID";
            // 
            // CourseTitleLabel
            // 
            this.CourseTitleLabel.AutoSize = true;
            this.CourseTitleLabel.Location = new System.Drawing.Point(58, 69);
            this.CourseTitleLabel.Name = "CourseTitleLabel";
            this.CourseTitleLabel.Size = new System.Drawing.Size(63, 13);
            this.CourseTitleLabel.TabIndex = 2;
            this.CourseTitleLabel.Text = "Course Title";
            // 
            // CourseTitleTextBox
            // 
            this.CourseTitleTextBox.Location = new System.Drawing.Point(127, 66);
            this.CourseTitleTextBox.Name = "CourseTitleTextBox";
            this.CourseTitleTextBox.Size = new System.Drawing.Size(215, 20);
            this.CourseTitleTextBox.TabIndex = 1;
            this.CourseTitleTextBox.TextChanged += new System.EventHandler(this.CourseTitleTextBox_TextChanged);
            // 
            // CreditsUpDown
            // 
            this.CreditsUpDown.Items.Add("2");
            this.CreditsUpDown.Items.Add("3");
            this.CreditsUpDown.Items.Add("4");
            this.CreditsUpDown.Location = new System.Drawing.Point(127, 101);
            this.CreditsUpDown.Name = "CreditsUpDown";
            this.CreditsUpDown.Size = new System.Drawing.Size(215, 20);
            this.CreditsUpDown.TabIndex = 2;
            this.CreditsUpDown.SelectedItemChanged += new System.EventHandler(this.CreditsUpDown_SelectedItemChanged);
            // 
            // CreditsLabel
            // 
            this.CreditsLabel.AutoSize = true;
            this.CreditsLabel.Location = new System.Drawing.Point(82, 103);
            this.CreditsLabel.Name = "CreditsLabel";
            this.CreditsLabel.Size = new System.Drawing.Size(39, 13);
            this.CreditsLabel.TabIndex = 2;
            this.CreditsLabel.Text = "Credits";
            // 
            // DepIDlabel
            // 
            this.DepIDlabel.AutoSize = true;
            this.DepIDlabel.Location = new System.Drawing.Point(45, 130);
            this.DepIDlabel.Name = "DepIDlabel";
            this.DepIDlabel.Size = new System.Drawing.Size(76, 13);
            this.DepIDlabel.TabIndex = 1;
            this.DepIDlabel.Text = "Department ID";
            // 
            // LoctextBox
            // 
            this.LoctextBox.Location = new System.Drawing.Point(127, 159);
            this.LoctextBox.Name = "LoctextBox";
            this.LoctextBox.Size = new System.Drawing.Size(215, 20);
            this.LoctextBox.TabIndex = 4;
            this.LoctextBox.TextChanged += new System.EventHandler(this.LoctextBox_TextChanged);
            // 
            // Loclabel
            // 
            this.Loclabel.AutoSize = true;
            this.Loclabel.Location = new System.Drawing.Point(58, 162);
            this.Loclabel.Name = "Loclabel";
            this.Loclabel.Size = new System.Drawing.Size(48, 13);
            this.Loclabel.TabIndex = 1;
            this.Loclabel.Text = "Location";
            // 
            // DaystextBox
            // 
            this.DaystextBox.Location = new System.Drawing.Point(127, 190);
            this.DaystextBox.Name = "DaystextBox";
            this.DaystextBox.Size = new System.Drawing.Size(215, 20);
            this.DaystextBox.TabIndex = 5;
            this.DaystextBox.TextChanged += new System.EventHandler(this.DaystextBox_TextChanged);
            // 
            // Dayslabel
            // 
            this.Dayslabel.AutoSize = true;
            this.Dayslabel.Location = new System.Drawing.Point(81, 193);
            this.Dayslabel.Name = "Dayslabel";
            this.Dayslabel.Size = new System.Drawing.Size(31, 13);
            this.Dayslabel.TabIndex = 1;
            this.Dayslabel.Text = "Days";
            // 
            // Timelabel
            // 
            this.Timelabel.AutoSize = true;
            this.Timelabel.Location = new System.Drawing.Point(82, 221);
            this.Timelabel.Name = "Timelabel";
            this.Timelabel.Size = new System.Drawing.Size(30, 13);
            this.Timelabel.TabIndex = 1;
            this.Timelabel.Text = "Time";
            // 
            // TimetextBox
            // 
            this.TimetextBox.Location = new System.Drawing.Point(127, 218);
            this.TimetextBox.Name = "TimetextBox";
            this.TimetextBox.Size = new System.Drawing.Size(215, 20);
            this.TimetextBox.TabIndex = 6;
            this.TimetextBox.TextChanged += new System.EventHandler(this.TimetextBox_TextChanged);
            // 
            // AddToDBButton
            // 
            this.AddToDBButton.Location = new System.Drawing.Point(170, 263);
            this.AddToDBButton.Name = "AddToDBButton";
            this.AddToDBButton.Size = new System.Drawing.Size(136, 45);
            this.AddToDBButton.TabIndex = 7;
            this.AddToDBButton.Text = "Добавить в БД";
            this.AddToDBButton.UseVisualStyleBackColor = true;
            this.AddToDBButton.Click += new System.EventHandler(this.AddToDBButton_Click);
            // 
            // DepartmentUpDown
            // 
            this.DepartmentUpDown.Items.Add("1");
            this.DepartmentUpDown.Items.Add("2");
            this.DepartmentUpDown.Items.Add("4");
            this.DepartmentUpDown.Items.Add("7");
            this.DepartmentUpDown.Location = new System.Drawing.Point(127, 133);
            this.DepartmentUpDown.Name = "DepartmentUpDown";
            this.DepartmentUpDown.Size = new System.Drawing.Size(215, 20);
            this.DepartmentUpDown.TabIndex = 3;
            this.DepartmentUpDown.SelectedItemChanged += new System.EventHandler(this.DepartmentUpDown_SelectedItemChanged);
            // 
            // NewCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 345);
            this.Controls.Add(this.DepartmentUpDown);
            this.Controls.Add(this.AddToDBButton);
            this.Controls.Add(this.TimetextBox);
            this.Controls.Add(this.CreditsUpDown);
            this.Controls.Add(this.CreditsLabel);
            this.Controls.Add(this.CourseTitleLabel);
            this.Controls.Add(this.CourseTitleTextBox);
            this.Controls.Add(this.Timelabel);
            this.Controls.Add(this.Dayslabel);
            this.Controls.Add(this.Loclabel);
            this.Controls.Add(this.DaystextBox);
            this.Controls.Add(this.DepIDlabel);
            this.Controls.Add(this.LoctextBox);
            this.Controls.Add(this.CourseIdLabel);
            this.Controls.Add(this.CourseIDTextBox);
            this.Name = "NewCourse";
            this.Text = "NewCourse";
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.TextBox CourseIDTextBox;
        private System.Windows.Forms.Label CourseIdLabel;
        private System.Windows.Forms.Label CourseTitleLabel;
        private System.Windows.Forms.TextBox CourseTitleTextBox;
        private System.Windows.Forms.DomainUpDown CreditsUpDown;
        private System.Windows.Forms.Label CreditsLabel;
        private System.Windows.Forms.Label DepIDlabel;
        private System.Windows.Forms.TextBox LoctextBox;
        private System.Windows.Forms.Label Loclabel;
        private System.Windows.Forms.TextBox DaystextBox;
        private System.Windows.Forms.Label Dayslabel;
        private System.Windows.Forms.Label Timelabel;
        private System.Windows.Forms.TextBox TimetextBox;
        private System.Windows.Forms.Button AddToDBButton;
        private System.Windows.Forms.DomainUpDown DepartmentUpDown;
        }
    }