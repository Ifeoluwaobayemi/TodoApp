namespace TodoApp
{
    partial class TodoApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titleLabel = new Label();
            descriptionLabel = new Label();
            titleTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            todoListView = new DataGridView();
            addButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            dueDateLabel = new Label();
            dueDateTime = new DateTimePicker();
            searchLabel = new Label();
            searchTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)todoListView).BeginInit();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            titleLabel.Location = new Point(177, 178);
            titleLabel.Margin = new Padding(2, 0, 2, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(108, 54);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Title:";
            titleLabel.TextAlign = ContentAlignment.TopCenter;
            titleLabel.Click += titleLabel_Click;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            descriptionLabel.Location = new Point(56, 325);
            descriptionLabel.Margin = new Padding(2, 0, 2, 0);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(234, 54);
            descriptionLabel.TabIndex = 1;
            descriptionLabel.Text = "Description:";
            descriptionLabel.Click += descriptionLabel_Click;
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(289, 178);
            titleTextBox.Margin = new Padding(7, 8, 7, 8);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(660, 47);
            titleTextBox.TabIndex = 2;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(289, 320);
            descriptionTextBox.Margin = new Padding(7, 8, 7, 8);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(660, 47);
            descriptionTextBox.TabIndex = 3;
            descriptionTextBox.TextChanged += textBox2_TextChanged;
            // 
            // todoListView
            // 
            todoListView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            todoListView.BackgroundColor = SystemColors.Window;
            todoListView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            todoListView.Location = new Point(1209, 3);
            todoListView.Margin = new Padding(7, 8, 7, 8);
            todoListView.Name = "todoListView";
            todoListView.RowHeadersWidth = 102;
            todoListView.RowTemplate.Height = 25;
            todoListView.Size = new Size(1117, 1399);
            todoListView.TabIndex = 8;
            todoListView.CellContentClick += todoListView_CellContentClick;
            // 
            // addButton
            // 
            addButton.Location = new Point(61, 776);
            addButton.Margin = new Padding(7, 8, 7, 8);
            addButton.Name = "addButton";
            addButton.Size = new Size(182, 101);
            addButton.TabIndex = 9;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(294, 776);
            editButton.Margin = new Padding(7, 8, 7, 8);
            editButton.Name = "editButton";
            editButton.Size = new Size(182, 101);
            editButton.TabIndex = 10;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(527, 776);
            deleteButton.Margin = new Padding(7, 8, 7, 8);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(182, 101);
            deleteButton.TabIndex = 11;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // dueDateLabel
            // 
            dueDateLabel.AutoSize = true;
            dueDateLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dueDateLabel.Location = new Point(100, 473);
            dueDateLabel.Margin = new Padding(7, 0, 7, 0);
            dueDateLabel.Name = "dueDateLabel";
            dueDateLabel.Size = new Size(198, 54);
            dueDateLabel.TabIndex = 13;
            dueDateLabel.Text = "Due Date:";
            // 
            // dueDateTime
            // 
            dueDateTime.Location = new Point(301, 473);
            dueDateTime.Margin = new Padding(7, 8, 7, 8);
            dueDateTime.Name = "dueDateTime";
            dueDateTime.Size = new Size(480, 47);
            dueDateTime.TabIndex = 14;
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Location = new Point(56, 976);
            searchLabel.Margin = new Padding(7, 0, 7, 0);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(113, 41);
            searchLabel.TabIndex = 15;
            searchLabel.Text = "Search:";
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(177, 968);
            searchTextBox.Margin = new Padding(7, 8, 7, 8);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(526, 47);
            searchTextBox.TabIndex = 16;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
            // 
            // TodoApp
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2334, 1462);
            Controls.Add(searchTextBox);
            Controls.Add(searchLabel);
            Controls.Add(dueDateTime);
            Controls.Add(dueDateLabel);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(addButton);
            Controls.Add(todoListView);
            Controls.Add(descriptionTextBox);
            Controls.Add(titleTextBox);
            Controls.Add(descriptionLabel);
            Controls.Add(titleLabel);
            Margin = new Padding(2, 3, 2, 3);
            Name = "TodoApp";
            Text = "TodoApp";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)todoListView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Label descriptionLabel;
        private TextBox titleTextBox;
        private TextBox descriptionTextBox;
        private DataGridView todoListView;
        private Button addButton;
        private Button editButton;
        private Button deleteButton;
        private Label dueDateLabel;
        private DateTimePicker dueDateTime;
        private Label searchLabel;
        private TextBox searchTextBox;
    }
}