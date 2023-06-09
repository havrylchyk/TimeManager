namespace TimeManager.UI
{
    partial class TimeManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeManagerForm));
            pictureBox1 = new PictureBox();
            CreateTasks = new GroupBox();
            EnddateTimePicker = new DateTimePicker();
            StartdateTimePicker = new DateTimePicker();
            Addbutton = new Button();
            Updatebutton = new Button();
            Deletebutton = new Button();
            StatuscomboBox = new ComboBox();
            CategorycomboBox = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            taskNametextBox = new TextBox();
            TaskdataGridView = new DataGridView();
            UsertextBox = new TextBox();
            Updatenamebutton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            CreateTasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TaskdataGridView).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(192, 192, 255);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(918, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 87);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // CreateTasks
            // 
            CreateTasks.BackColor = Color.FromArgb(192, 192, 255);
            CreateTasks.Controls.Add(EnddateTimePicker);
            CreateTasks.Controls.Add(StartdateTimePicker);
            CreateTasks.Controls.Add(Addbutton);
            CreateTasks.Controls.Add(Updatebutton);
            CreateTasks.Controls.Add(Deletebutton);
            CreateTasks.Controls.Add(StatuscomboBox);
            CreateTasks.Controls.Add(CategorycomboBox);
            CreateTasks.Controls.Add(label5);
            CreateTasks.Controls.Add(label4);
            CreateTasks.Controls.Add(label3);
            CreateTasks.Controls.Add(label2);
            CreateTasks.Controls.Add(label1);
            CreateTasks.Controls.Add(taskNametextBox);
            CreateTasks.Location = new Point(12, 12);
            CreateTasks.Name = "CreateTasks";
            CreateTasks.Size = new Size(447, 310);
            CreateTasks.TabIndex = 2;
            CreateTasks.TabStop = false;
            CreateTasks.Text = "Створити завдання";
            // 
            // EnddateTimePicker
            // 
            EnddateTimePicker.Location = new Point(6, 158);
            EnddateTimePicker.Name = "EnddateTimePicker";
            EnddateTimePicker.Size = new Size(250, 27);
            EnddateTimePicker.TabIndex = 12;
            // 
            // StartdateTimePicker
            // 
            StartdateTimePicker.Location = new Point(6, 103);
            StartdateTimePicker.Name = "StartdateTimePicker";
            StartdateTimePicker.Size = new Size(250, 27);
            StartdateTimePicker.TabIndex = 11;
            // 
            // Addbutton
            // 
            Addbutton.BackColor = Color.MediumPurple;
            Addbutton.Location = new Point(337, 191);
            Addbutton.Name = "Addbutton";
            Addbutton.Size = new Size(94, 28);
            Addbutton.TabIndex = 10;
            Addbutton.Text = "Додати";
            Addbutton.UseVisualStyleBackColor = false;
            Addbutton.Click += Addbutton_Click;
            // 
            // Updatebutton
            // 
            Updatebutton.BackColor = Color.MediumPurple;
            Updatebutton.Location = new Point(337, 226);
            Updatebutton.Name = "Updatebutton";
            Updatebutton.Size = new Size(94, 28);
            Updatebutton.TabIndex = 9;
            Updatebutton.Text = "Редагувати";
            Updatebutton.UseVisualStyleBackColor = false;
            // 
            // Deletebutton
            // 
            Deletebutton.BackColor = Color.MediumPurple;
            Deletebutton.Location = new Point(337, 261);
            Deletebutton.Name = "Deletebutton";
            Deletebutton.Size = new Size(94, 28);
            Deletebutton.TabIndex = 8;
            Deletebutton.Text = "Видалити";
            Deletebutton.UseVisualStyleBackColor = false;
            // 
            // StatuscomboBox
            // 
            StatuscomboBox.FormattingEnabled = true;
            StatuscomboBox.Location = new Point(6, 261);
            StatuscomboBox.Name = "StatuscomboBox";
            StatuscomboBox.Size = new Size(250, 28);
            StatuscomboBox.TabIndex = 7;
            // 
            // CategorycomboBox
            // 
            CategorycomboBox.FormattingEnabled = true;
            CategorycomboBox.Location = new Point(6, 211);
            CategorycomboBox.Name = "CategorycomboBox";
            CategorycomboBox.Size = new Size(250, 28);
            CategorycomboBox.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 238);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 5;
            label5.Text = "Статус";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 188);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 4;
            label4.Text = "Ктегорія";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 133);
            label3.Name = "label3";
            label3.Size = new Size(205, 20);
            label3.TabIndex = 3;
            label3.Text = "Кінець виконання завдання";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 79);
            label2.Name = "label2";
            label2.Size = new Size(216, 20);
            label2.TabIndex = 2;
            label2.Text = "Початок виконання завдання";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 26);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 1;
            label1.Text = "Назва завдання";
            // 
            // taskNametextBox
            // 
            taskNametextBox.Location = new Point(6, 49);
            taskNametextBox.Name = "taskNametextBox";
            taskNametextBox.Size = new Size(250, 27);
            taskNametextBox.TabIndex = 0;
            // 
            // TaskdataGridView
            // 
            TaskdataGridView.BackgroundColor = SystemColors.Window;
            TaskdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TaskdataGridView.GridColor = SystemColors.Window;
            TaskdataGridView.Location = new Point(12, 348);
            TaskdataGridView.Name = "TaskdataGridView";
            TaskdataGridView.RowHeadersWidth = 51;
            TaskdataGridView.RowTemplate.Height = 29;
            TaskdataGridView.Size = new Size(447, 292);
            TaskdataGridView.TabIndex = 3;
            // 
            // UsertextBox
            // 
            UsertextBox.Location = new Point(897, 105);
            UsertextBox.Name = "UsertextBox";
            UsertextBox.Size = new Size(130, 27);
            UsertextBox.TabIndex = 4;
            // 
            // Updatenamebutton
            // 
            Updatenamebutton.Location = new Point(918, 141);
            Updatenamebutton.Name = "Updatenamebutton";
            Updatenamebutton.Size = new Size(94, 29);
            Updatenamebutton.TabIndex = 5;
            Updatenamebutton.Text = "Редагувати";
            Updatenamebutton.UseVisualStyleBackColor = true;
            // 
            // TimeManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1048, 652);
            Controls.Add(Updatenamebutton);
            Controls.Add(UsertextBox);
            Controls.Add(TaskdataGridView);
            Controls.Add(CreateTasks);
            Controls.Add(pictureBox1);
            Name = "TimeManagerForm";
            Text = "TimeManagerForm";
            FormClosed += TimeManagerForm_FormClosed;
            Load += TimeManagerForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            CreateTasks.ResumeLayout(false);
            CreateTasks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TaskdataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private GroupBox CreateTasks;
        private TextBox taskNametextBox;
        private DataGridView TaskdataGridView;
        private TextBox UsertextBox;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button Addbutton;
        private Button Updatebutton;
        private Button Deletebutton;
        private ComboBox StatuscomboBox;
        private ComboBox CategorycomboBox;
        private Button Updatenamebutton;
        private DateTimePicker EnddateTimePicker;
        private DateTimePicker StartdateTimePicker;
    }
}