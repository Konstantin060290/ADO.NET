namespace ITMO.WFCS.ZACHET
{
    partial class ZachetForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.GetStudentsButton = new System.Windows.Forms.Button();
            this.StudentsListView = new System.Windows.Forms.ListView();
            this.PesonId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HireDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DepartmentsDataGridView = new System.Windows.Forms.DataGridView();
            this.GetDepartmentsButton = new System.Windows.Forms.Button();
            this.ChangeDepartmentsButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // GetStudentsButton
            // 
            this.GetStudentsButton.Location = new System.Drawing.Point(12, 27);
            this.GetStudentsButton.Name = "GetStudentsButton";
            this.GetStudentsButton.Size = new System.Drawing.Size(154, 46);
            this.GetStudentsButton.TabIndex = 0;
            this.GetStudentsButton.Text = "Получить список учеников";
            this.GetStudentsButton.UseVisualStyleBackColor = true;
            this.GetStudentsButton.Click += new System.EventHandler(this.GetStudentsButton_Click);
            // 
            // StudentsListView
            // 
            this.StudentsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PesonId,
            this.FirstName,
            this.LastName,
            this.HireDate});
            this.StudentsListView.HideSelection = false;
            this.StudentsListView.Location = new System.Drawing.Point(172, 27);
            this.StudentsListView.Name = "StudentsListView";
            this.StudentsListView.Size = new System.Drawing.Size(442, 125);
            this.StudentsListView.TabIndex = 2;
            this.StudentsListView.UseCompatibleStateImageBehavior = false;
            this.StudentsListView.View = System.Windows.Forms.View.Details;
            // 
            // PesonId
            // 
            this.PesonId.Text = "Peson ID";
            // 
            // FirstName
            // 
            this.FirstName.Text = "First Name";
            this.FirstName.Width = 99;
            // 
            // LastName
            // 
            this.LastName.Text = "Last Name";
            this.LastName.Width = 102;
            // 
            // HireDate
            // 
            this.HireDate.Text = "Hire Date";
            this.HireDate.Width = 210;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveUsToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // SaveUsToolStripMenuItem
            // 
            this.SaveUsToolStripMenuItem.Name = "SaveUsToolStripMenuItem";
            this.SaveUsToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.SaveUsToolStripMenuItem.Text = "Сохранить как";
            this.SaveUsToolStripMenuItem.Click += new System.EventHandler(this.SaveUsToolStripMenuItem_Click);
            // 
            // DepartmentsDataGridView
            // 
            this.DepartmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DepartmentsDataGridView.Location = new System.Drawing.Point(172, 158);
            this.DepartmentsDataGridView.Name = "DepartmentsDataGridView";
            this.DepartmentsDataGridView.Size = new System.Drawing.Size(442, 142);
            this.DepartmentsDataGridView.TabIndex = 4;
            // 
            // GetDepartmentsButton
            // 
            this.GetDepartmentsButton.Location = new System.Drawing.Point(12, 158);
            this.GetDepartmentsButton.Name = "GetDepartmentsButton";
            this.GetDepartmentsButton.Size = new System.Drawing.Size(154, 46);
            this.GetDepartmentsButton.TabIndex = 0;
            this.GetDepartmentsButton.Text = "Получить список департаментов";
            this.GetDepartmentsButton.UseVisualStyleBackColor = true;
            this.GetDepartmentsButton.Click += new System.EventHandler(this.GetTeachersButton_Click);
            // 
            // ChangeDepartmentsButton
            // 
            this.ChangeDepartmentsButton.Location = new System.Drawing.Point(12, 210);
            this.ChangeDepartmentsButton.Name = "ChangeDepartmentsButton";
            this.ChangeDepartmentsButton.Size = new System.Drawing.Size(154, 40);
            this.ChangeDepartmentsButton.TabIndex = 5;
            this.ChangeDepartmentsButton.Text = "Изменить";
            this.ChangeDepartmentsButton.UseVisualStyleBackColor = true;
            this.ChangeDepartmentsButton.Click += new System.EventHandler(this.ChangeDepartmentsButton_Click);
            // 
            // ZachetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChangeDepartmentsButton);
            this.Controls.Add(this.DepartmentsDataGridView);
            this.Controls.Add(this.StudentsListView);
            this.Controls.Add(this.GetDepartmentsButton);
            this.Controls.Add(this.GetStudentsButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ZachetForm";
            this.Text = "Зачетное задание";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetStudentsButton;
        private System.Windows.Forms.ListView StudentsListView;
        private System.Windows.Forms.ColumnHeader PesonId;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader HireDate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveUsToolStripMenuItem;
        private System.Windows.Forms.DataGridView DepartmentsDataGridView;
        private System.Windows.Forms.Button GetDepartmentsButton;
        private System.Windows.Forms.Button ChangeDepartmentsButton;
        }
}

