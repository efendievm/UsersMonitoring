
namespace UsersMonitoring
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.AddUserGroupButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.GroupsComboBox = new System.Windows.Forms.ComboBox();
            this.FioTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.UsersGrid = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GroupsGrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.GroupDescTextBox = new System.Windows.Forms.TextBox();
            this.AddGroupButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GroupsGrid);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1191, 246);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Группы";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AddUserButton);
            this.groupBox2.Controls.Add(this.AddUserGroupButton);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.GroupsComboBox);
            this.groupBox2.Controls.Add(this.FioTextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 492);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1191, 94);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Добавление сотрудника";
            // 
            // AddUserButton
            // 
            this.AddUserButton.Location = new System.Drawing.Point(12, 57);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(193, 31);
            this.AddUserButton.TabIndex = 5;
            this.AddUserButton.Text = "Добавить сотрудника";
            this.AddUserButton.UseVisualStyleBackColor = true;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // AddUserGroupButton
            // 
            this.AddUserGroupButton.Location = new System.Drawing.Point(653, 24);
            this.AddUserGroupButton.Name = "AddUserGroupButton";
            this.AddUserGroupButton.Size = new System.Drawing.Size(99, 32);
            this.AddUserGroupButton.TabIndex = 4;
            this.AddUserGroupButton.Text = "Добавить";
            this.AddUserGroupButton.UseVisualStyleBackColor = true;
            this.AddUserGroupButton.Click += new System.EventHandler(this.AddUserGroupButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Группы";
            // 
            // GroupsComboBox
            // 
            this.GroupsComboBox.FormattingEnabled = true;
            this.GroupsComboBox.Location = new System.Drawing.Point(428, 29);
            this.GroupsComboBox.Name = "GroupsComboBox";
            this.GroupsComboBox.Size = new System.Drawing.Size(207, 24);
            this.GroupsComboBox.TabIndex = 2;
            // 
            // FioTextBox
            // 
            this.FioTextBox.Location = new System.Drawing.Point(60, 29);
            this.FioTextBox.Name = "FioTextBox";
            this.FioTextBox.Size = new System.Drawing.Size(299, 22);
            this.FioTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.UsersGrid);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1191, 242);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Сотрудники";
            // 
            // UsersGrid
            // 
            this.UsersGrid.AllowUserToAddRows = false;
            this.UsersGrid.AllowUserToDeleteRows = false;
            this.UsersGrid.AllowUserToResizeColumns = false;
            this.UsersGrid.AllowUserToResizeRows = false;
            this.UsersGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UsersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsersGrid.Location = new System.Drawing.Point(3, 18);
            this.UsersGrid.Name = "UsersGrid";
            this.UsersGrid.ReadOnly = true;
            this.UsersGrid.RowHeadersVisible = false;
            this.UsersGrid.RowHeadersWidth = 51;
            this.UsersGrid.RowTemplate.Height = 24;
            this.UsersGrid.Size = new System.Drawing.Size(1185, 221);
            this.UsersGrid.TabIndex = 0;
            this.UsersGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UsersGrid_MouseClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Size = new System.Drawing.Size(1191, 492);
            this.splitContainer1.SplitterDistance = 246;
            this.splitContainer1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AddGroupButton);
            this.panel1.Controls.Add(this.GroupDescTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 203);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1185, 40);
            this.panel1.TabIndex = 0;
            // 
            // GroupsGrid
            // 
            this.GroupsGrid.AccessibleRole = System.Windows.Forms.AccessibleRole.WhiteSpace;
            this.GroupsGrid.AllowUserToAddRows = false;
            this.GroupsGrid.AllowUserToDeleteRows = false;
            this.GroupsGrid.AllowUserToResizeColumns = false;
            this.GroupsGrid.AllowUserToResizeRows = false;
            this.GroupsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GroupsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GroupsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupsGrid.Location = new System.Drawing.Point(3, 18);
            this.GroupsGrid.Name = "GroupsGrid";
            this.GroupsGrid.ReadOnly = true;
            this.GroupsGrid.RowHeadersVisible = false;
            this.GroupsGrid.RowHeadersWidth = 51;
            this.GroupsGrid.RowTemplate.Height = 24;
            this.GroupsGrid.Size = new System.Drawing.Size(1185, 185);
            this.GroupsGrid.TabIndex = 1;
            this.GroupsGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GroupsGrid_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Название группы";
            // 
            // GroupDescTextBox
            // 
            this.GroupDescTextBox.Location = new System.Drawing.Point(134, 9);
            this.GroupDescTextBox.Name = "GroupDescTextBox";
            this.GroupDescTextBox.Size = new System.Drawing.Size(285, 22);
            this.GroupDescTextBox.TabIndex = 1;
            // 
            // AddGroupButton
            // 
            this.AddGroupButton.Location = new System.Drawing.Point(425, 6);
            this.AddGroupButton.Name = "AddGroupButton";
            this.AddGroupButton.Size = new System.Drawing.Size(137, 29);
            this.AddGroupButton.TabIndex = 2;
            this.AddGroupButton.Text = "Добавить группу";
            this.AddGroupButton.UseVisualStyleBackColor = true;
            this.AddGroupButton.Click += new System.EventHandler(this.AddGroupButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 586);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.groupBox2);
            this.Name = "MainForm";
            this.Text = "Мониторинг сотрудников";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UsersGrid)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.Button AddUserGroupButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox GroupsComboBox;
        private System.Windows.Forms.TextBox FioTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView UsersGrid;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView GroupsGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox GroupDescTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddGroupButton;
    }
}

