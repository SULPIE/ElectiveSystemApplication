namespace ElectiveApp
{
    partial class MainForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridView = new DataGridView();
            menuStrip1 = new MenuStrip();
            StudentsItem = new ToolStripMenuItem();
            SubjectsItem = new ToolStripMenuItem();
            SemestersItem = new ToolStripMenuItem();
            ReportsItem = new ToolStripMenuItem();
            создатьToolStripMenuItem = new ToolStripMenuItem();
            currentSemesterTB = new ToolStripTextBox();
            EndSemesterBtn = new ToolStripMenuItem();
            UsersItem = new ToolStripMenuItem();
            LogsItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // DataGridView
            // 
            DataGridView.AllowUserToAddRows = false;
            DataGridView.AllowUserToOrderColumns = true;
            DataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridView.BackgroundColor = SystemColors.Window;
            DataGridView.BorderStyle = BorderStyle.None;
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            DataGridView.Location = new Point(9, 37);
            DataGridView.Margin = new Padding(0, 3, 3, 3);
            DataGridView.Name = "DataGridView";
            DataGridView.Size = new Size(1068, 419);
            DataGridView.TabIndex = 0;
            DataGridView.CellBeginEdit += DataGridView_CellBeginEdit;
            DataGridView.CellEndEdit += DataGridView_CellEndEdit;
            DataGridView.UserDeletingRow += DataGridView_UserDeletingRow;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaption;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { StudentsItem, SubjectsItem, SemestersItem, ReportsItem, создатьToolStripMenuItem, currentSemesterTB, EndSemesterBtn, UsersItem, LogsItem });
            menuStrip1.Location = new Point(2, 10);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1077, 27);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // StudentsItem
            // 
            StudentsItem.BackColor = Color.Bisque;
            StudentsItem.Name = "StudentsItem";
            StudentsItem.Size = new Size(71, 23);
            StudentsItem.Text = "Студенты";
            StudentsItem.Click += StudentsItem_Click;
            // 
            // SubjectsItem
            // 
            SubjectsItem.BackColor = Color.Bisque;
            SubjectsItem.Name = "SubjectsItem";
            SubjectsItem.Size = new Size(76, 23);
            SubjectsItem.Text = "Предметы";
            SubjectsItem.Click += SubjectsItem_Click;
            // 
            // SemestersItem
            // 
            SemestersItem.BackColor = Color.Bisque;
            SemestersItem.Name = "SemestersItem";
            SemestersItem.Size = new Size(147, 23);
            SemestersItem.Text = "Предметы за семестры";
            SemestersItem.Click += SemestersItem_Click;
            // 
            // ReportsItem
            // 
            ReportsItem.BackColor = Color.Bisque;
            ReportsItem.Name = "ReportsItem";
            ReportsItem.Size = new Size(116, 23);
            ReportsItem.Text = "Итоговые оценки";
            ReportsItem.Click += ReportsItem_Click;
            // 
            // создатьToolStripMenuItem
            // 
            создатьToolStripMenuItem.BackColor = Color.Gold;
            создатьToolStripMenuItem.Margin = new Padding(10, 0, 0, 0);
            создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            создатьToolStripMenuItem.Size = new Size(102, 23);
            создатьToolStripMenuItem.Text = "Создать запись";
            создатьToolStripMenuItem.Click += создатьToolStripMenuItem_Click;
            // 
            // currentSemesterTB
            // 
            currentSemesterTB.BackColor = Color.Bisque;
            currentSemesterTB.Margin = new Padding(10, 0, 1, 0);
            currentSemesterTB.Name = "currentSemesterTB";
            currentSemesterTB.ReadOnly = true;
            currentSemesterTB.Size = new Size(135, 23);
            currentSemesterTB.Text = "Текущий семестр:";
            // 
            // EndSemesterBtn
            // 
            EndSemesterBtn.BackColor = Color.Gold;
            EndSemesterBtn.Name = "EndSemesterBtn";
            EndSemesterBtn.Size = new Size(128, 23);
            EndSemesterBtn.Text = "Завершить семестр";
            EndSemesterBtn.Click += EndSemesterBtn_Click;
            // 
            // UsersItem
            // 
            UsersItem.BackColor = SystemColors.HotTrack;
            UsersItem.ForeColor = SystemColors.ControlLight;
            UsersItem.Margin = new Padding(10, 0, 0, 0);
            UsersItem.Name = "UsersItem";
            UsersItem.Size = new Size(97, 23);
            UsersItem.Text = "Пользователи";
            UsersItem.Click += UsersItem_Click;
            // 
            // LogsItem
            // 
            LogsItem.BackColor = SystemColors.HotTrack;
            LogsItem.ForeColor = SystemColors.ControlLight;
            LogsItem.Name = "LogsItem";
            LogsItem.Size = new Size(46, 23);
            LogsItem.Text = "Логи";
            LogsItem.Click += LogsItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1089, 468);
            Controls.Add(DataGridView);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Главная";
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataGridView;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem StudentsItem;
        private ToolStripMenuItem SubjectsItem;
        private ToolStripMenuItem SemestersItem;
        private ToolStripMenuItem ReportsItem;
        private ToolStripMenuItem создатьToolStripMenuItem;
        private ToolStripTextBox currentSemesterTB;
        private ToolStripMenuItem EndSemesterBtn;
        private ToolStripMenuItem UsersItem;
        private ToolStripMenuItem LogsItem;
    }
}