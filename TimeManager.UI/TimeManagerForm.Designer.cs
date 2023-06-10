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
            groupBox1 = new GroupBox();
            label7 = new Label();
            label6 = new Label();
            EmailChangetextBox = new TextBox();
            groupBox2 = new GroupBox();
            RegularTasknumericUpDown = new NumericUpDown();
            lastdateTimePicker = new DateTimePicker();
            Addregularbutton = new Button();
            Updateregularbutton = new Button();
            CategorycomboBoxtwo = new ComboBox();
            DeleteRegularbutton = new Button();
            RegularnametextBox = new TextBox();
            label9 = new Label();
            label12 = new Label();
            label10 = new Label();
            label11 = new Label();
            CheckdrvcomboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            CreateTasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TaskdataGridView).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RegularTasknumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(86, 25);
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
            CreateTasks.Size = new Size(383, 310);
            CreateTasks.TabIndex = 2;
            CreateTasks.TabStop = false;
            CreateTasks.Text = "Створити завдання";
            // 
            // EnddateTimePicker
            // 
            EnddateTimePicker.Format = DateTimePickerFormat.Time;
            EnddateTimePicker.Location = new Point(6, 156);
            EnddateTimePicker.Name = "EnddateTimePicker";
            EnddateTimePicker.Size = new Size(250, 27);
            EnddateTimePicker.TabIndex = 12;
            // 
            // StartdateTimePicker
            // 
            StartdateTimePicker.Format = DateTimePickerFormat.Time;
            StartdateTimePicker.Location = new Point(6, 101);
            StartdateTimePicker.Name = "StartdateTimePicker";
            StartdateTimePicker.Size = new Size(250, 27);
            StartdateTimePicker.TabIndex = 11;
            // 
            // Addbutton
            // 
            Addbutton.BackColor = Color.MediumPurple;
            Addbutton.Location = new Point(278, 190);
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
            Updatebutton.Location = new Point(278, 225);
            Updatebutton.Name = "Updatebutton";
            Updatebutton.Size = new Size(94, 28);
            Updatebutton.TabIndex = 9;
            Updatebutton.Text = "Редагувати";
            Updatebutton.UseVisualStyleBackColor = false;
            Updatebutton.Click += Updatebutton_Click;
            // 
            // Deletebutton
            // 
            Deletebutton.BackColor = Color.MediumPurple;
            Deletebutton.Location = new Point(278, 260);
            Deletebutton.Name = "Deletebutton";
            Deletebutton.Size = new Size(94, 28);
            Deletebutton.TabIndex = 8;
            Deletebutton.Text = "Видалити";
            Deletebutton.UseVisualStyleBackColor = false;
            Deletebutton.Click += Deletebutton_Click;
            // 
            // StatuscomboBox
            // 
            StatuscomboBox.FormattingEnabled = true;
            StatuscomboBox.Location = new Point(6, 259);
            StatuscomboBox.Name = "StatuscomboBox";
            StatuscomboBox.Size = new Size(250, 28);
            StatuscomboBox.TabIndex = 7;
            // 
            // CategorycomboBox
            // 
            CategorycomboBox.FormattingEnabled = true;
            CategorycomboBox.Location = new Point(6, 209);
            CategorycomboBox.Name = "CategorycomboBox";
            CategorycomboBox.Size = new Size(250, 28);
            CategorycomboBox.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 236);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 5;
            label5.Text = "Статус";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 186);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 4;
            label4.Text = "Ктегорія";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 131);
            label3.Name = "label3";
            label3.Size = new Size(205, 20);
            label3.TabIndex = 3;
            label3.Text = "Кінець виконання завдання";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 77);
            label2.Name = "label2";
            label2.Size = new Size(216, 20);
            label2.TabIndex = 2;
            label2.Text = "Початок виконання завдання";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 24);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 1;
            label1.Text = "Назва завдання";
            // 
            // taskNametextBox
            // 
            taskNametextBox.Location = new Point(6, 47);
            taskNametextBox.Name = "taskNametextBox";
            taskNametextBox.Size = new Size(250, 27);
            taskNametextBox.TabIndex = 0;
            // 
            // TaskdataGridView
            // 
            TaskdataGridView.BackgroundColor = SystemColors.Window;
            TaskdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TaskdataGridView.GridColor = SystemColors.WindowText;
            TaskdataGridView.Location = new Point(12, 328);
            TaskdataGridView.Name = "TaskdataGridView";
            TaskdataGridView.RowHeadersWidth = 51;
            TaskdataGridView.RowTemplate.Height = 29;
            TaskdataGridView.Size = new Size(880, 166);
            TaskdataGridView.TabIndex = 3;
            // 
            // UsertextBox
            // 
            UsertextBox.Location = new Point(53, 147);
            UsertextBox.Name = "UsertextBox";
            UsertextBox.Size = new Size(163, 27);
            UsertextBox.TabIndex = 4;
            // 
            // Updatenamebutton
            // 
            Updatenamebutton.BackColor = Color.MediumPurple;
            Updatenamebutton.Location = new Point(86, 259);
            Updatenamebutton.Name = "Updatenamebutton";
            Updatenamebutton.Size = new Size(94, 29);
            Updatenamebutton.TabIndex = 5;
            Updatenamebutton.Text = "Редагувати";
            Updatenamebutton.UseVisualStyleBackColor = false;
            Updatenamebutton.Click += Updatenamebutton_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 192, 192);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(EmailChangetextBox);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(Updatenamebutton);
            groupBox1.Controls.Add(UsertextBox);
            groupBox1.Location = new Point(401, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(267, 310);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Змінити дані";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(75, 188);
            label7.Name = "label7";
            label7.Size = new Size(112, 20);
            label7.TabIndex = 8;
            label7.Text = "Змінити пошту";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(86, 124);
            label6.Name = "label6";
            label6.Size = new Size(95, 20);
            label6.TabIndex = 7;
            label6.Text = "Змінити і'мя";
            // 
            // EmailChangetextBox
            // 
            EmailChangetextBox.Location = new Point(53, 211);
            EmailChangetextBox.Name = "EmailChangetextBox";
            EmailChangetextBox.Size = new Size(163, 27);
            EmailChangetextBox.TabIndex = 6;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(192, 192, 255);
            groupBox2.Controls.Add(RegularTasknumericUpDown);
            groupBox2.Controls.Add(lastdateTimePicker);
            groupBox2.Controls.Add(Addregularbutton);
            groupBox2.Controls.Add(Updateregularbutton);
            groupBox2.Controls.Add(CategorycomboBoxtwo);
            groupBox2.Controls.Add(DeleteRegularbutton);
            groupBox2.Controls.Add(RegularnametextBox);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label11);
            groupBox2.Location = new Point(677, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(323, 310);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Створити регулярне завдання";
            // 
            // RegularTasknumericUpDown
            // 
            RegularTasknumericUpDown.Location = new Point(8, 129);
            RegularTasknumericUpDown.Name = "RegularTasknumericUpDown";
            RegularTasknumericUpDown.Size = new Size(182, 27);
            RegularTasknumericUpDown.TabIndex = 23;
            // 
            // lastdateTimePicker
            // 
            lastdateTimePicker.Format = DateTimePickerFormat.Time;
            lastdateTimePicker.Location = new Point(8, 191);
            lastdateTimePicker.Name = "lastdateTimePicker";
            lastdateTimePicker.Size = new Size(182, 27);
            lastdateTimePicker.TabIndex = 22;
            // 
            // Addregularbutton
            // 
            Addregularbutton.BackColor = Color.MediumPurple;
            Addregularbutton.Location = new Point(223, 193);
            Addregularbutton.Name = "Addregularbutton";
            Addregularbutton.Size = new Size(94, 28);
            Addregularbutton.TabIndex = 13;
            Addregularbutton.Text = "Додати";
            Addregularbutton.UseVisualStyleBackColor = false;
            Addregularbutton.Click += Addregularbutton_Click;
            // 
            // Updateregularbutton
            // 
            Updateregularbutton.BackColor = Color.MediumPurple;
            Updateregularbutton.Location = new Point(223, 228);
            Updateregularbutton.Name = "Updateregularbutton";
            Updateregularbutton.Size = new Size(94, 28);
            Updateregularbutton.TabIndex = 12;
            Updateregularbutton.Text = "Редагувати";
            Updateregularbutton.UseVisualStyleBackColor = false;
            Updateregularbutton.Click += Updateregularbutton_Click;
            // 
            // CategorycomboBoxtwo
            // 
            CategorycomboBoxtwo.FormattingEnabled = true;
            CategorycomboBoxtwo.Location = new Point(8, 261);
            CategorycomboBoxtwo.Name = "CategorycomboBoxtwo";
            CategorycomboBoxtwo.Size = new Size(182, 28);
            CategorycomboBoxtwo.TabIndex = 19;
            // 
            // DeleteRegularbutton
            // 
            DeleteRegularbutton.BackColor = Color.MediumPurple;
            DeleteRegularbutton.Location = new Point(223, 263);
            DeleteRegularbutton.Name = "DeleteRegularbutton";
            DeleteRegularbutton.Size = new Size(94, 28);
            DeleteRegularbutton.TabIndex = 11;
            DeleteRegularbutton.Text = "Видалити";
            DeleteRegularbutton.UseVisualStyleBackColor = false;
            DeleteRegularbutton.Click += DeleteRegularbutton_Click;
            // 
            // RegularnametextBox
            // 
            RegularnametextBox.Location = new Point(8, 59);
            RegularnametextBox.Name = "RegularnametextBox";
            RegularnametextBox.Size = new Size(182, 27);
            RegularnametextBox.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(8, 238);
            label9.Name = "label9";
            label9.Size = new Size(68, 20);
            label9.TabIndex = 17;
            label9.Text = "Ктегорія";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(8, 36);
            label12.Name = "label12";
            label12.Size = new Size(120, 20);
            label12.TabIndex = 14;
            label12.Text = "Назва завдання";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 168);
            label10.Name = "label10";
            label10.Size = new Size(237, 20);
            label10.TabIndex = 16;
            label10.Text = "Коли було виконано останій раз";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 101);
            label11.Name = "label11";
            label11.Size = new Size(250, 20);
            label11.TabIndex = 15;
            label11.Text = "Яка частота повторень за тиждень";
            // 
            // CheckdrvcomboBox
            // 
            CheckdrvcomboBox.FormattingEnabled = true;
            CheckdrvcomboBox.Location = new Point(11, 500);
            CheckdrvcomboBox.Name = "CheckdrvcomboBox";
            CheckdrvcomboBox.Size = new Size(212, 28);
            CheckdrvcomboBox.TabIndex = 8;
            CheckdrvcomboBox.SelectedIndexChanged += CheckdrvcomboBox_SelectedIndexChanged;
            // 
            // TimeManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1008, 560);
            Controls.Add(CheckdrvcomboBox);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(TaskdataGridView);
            Controls.Add(CreateTasks);
            Name = "TimeManagerForm";
            Text = "TimeManagerForm";
            FormClosed += TimeManagerForm_FormClosed;
            Load += TimeManagerForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            CreateTasks.ResumeLayout(false);
            CreateTasks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TaskdataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RegularTasknumericUpDown).EndInit();
            ResumeLayout(false);
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
        private GroupBox groupBox1;
        private Label label6;
        private TextBox EmailChangetextBox;
        private Label label7;
        private GroupBox groupBox2;
        private Button Addregularbutton;
        private Button Updateregularbutton;
        private Button DeleteRegularbutton;
        private DateTimePicker lastdateTimePicker;
        private ComboBox CategorycomboBoxtwo;
        private TextBox RegularnametextBox;
        private Label label9;
        private Label label12;
        private Label label10;
        private Label label11;
        private NumericUpDown RegularTasknumericUpDown;
        private ComboBox CheckdrvcomboBox;
    }
}