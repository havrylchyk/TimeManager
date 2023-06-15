namespace TimeManager.UI
{
    partial class Report
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
            UsertextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            AmountOfTasktextBox = new TextBox();
            NoStartedtextBox = new TextBox();
            label3 = new Label();
            ProgrestextBox = new TextBox();
            label4 = new Label();
            DonetextBox = new TextBox();
            label = new Label();
            groupBox1 = new GroupBox();
            WastedTimetextBox = new TextBox();
            label5 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // UsertextBox
            // 
            UsertextBox.BackColor = Color.Snow;
            UsertextBox.Location = new Point(16, 44);
            UsertextBox.Name = "UsertextBox";
            UsertextBox.ReadOnly = true;
            UsertextBox.Size = new Size(188, 27);
            UsertextBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 21);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 6;
            label1.Text = "Користувач";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 94);
            label2.Name = "label2";
            label2.Size = new Size(195, 20);
            label2.TabIndex = 7;
            label2.Text = "Загальна кількість завдань";
            // 
            // AmountOfTasktextBox
            // 
            AmountOfTasktextBox.BackColor = Color.Snow;
            AmountOfTasktextBox.Location = new Point(16, 117);
            AmountOfTasktextBox.Name = "AmountOfTasktextBox";
            AmountOfTasktextBox.ReadOnly = true;
            AmountOfTasktextBox.Size = new Size(125, 27);
            AmountOfTasktextBox.TabIndex = 8;
            // 
            // NoStartedtextBox
            // 
            NoStartedtextBox.BackColor = Color.Snow;
            NoStartedtextBox.Location = new Point(16, 315);
            NoStartedtextBox.Name = "NoStartedtextBox";
            NoStartedtextBox.ReadOnly = true;
            NoStartedtextBox.Size = new Size(125, 27);
            NoStartedtextBox.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 292);
            label3.Name = "label3";
            label3.Size = new Size(205, 20);
            label3.TabIndex = 9;
            label3.Text = "З них нерозпочаті завдання";
            // 
            // ProgrestextBox
            // 
            ProgrestextBox.BackColor = Color.Snow;
            ProgrestextBox.Location = new Point(16, 251);
            ProgrestextBox.Name = "ProgrestextBox";
            ProgrestextBox.ReadOnly = true;
            ProgrestextBox.Size = new Size(125, 27);
            ProgrestextBox.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 228);
            label4.Name = "label4";
            label4.Size = new Size(117, 20);
            label4.TabIndex = 11;
            label4.Text = "З них в процесі";
            // 
            // DonetextBox
            // 
            DonetextBox.BackColor = Color.Snow;
            DonetextBox.Location = new Point(16, 189);
            DonetextBox.Name = "DonetextBox";
            DonetextBox.ReadOnly = true;
            DonetextBox.Size = new Size(125, 27);
            DonetextBox.TabIndex = 14;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(19, 166);
            label.Name = "label";
            label.Size = new Size(186, 20);
            label.TabIndex = 13;
            label.Text = "З них виконані  завдання";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(WastedTimetextBox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(DonetextBox);
            groupBox1.Controls.Add(UsertextBox);
            groupBox1.Controls.Add(label);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(ProgrestextBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(AmountOfTasktextBox);
            groupBox1.Controls.Add(NoStartedtextBox);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(276, 548);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            // 
            // WastedTimetextBox
            // 
            WastedTimetextBox.BackColor = SystemColors.Window;
            WastedTimetextBox.Location = new Point(16, 400);
            WastedTimetextBox.Name = "WastedTimetextBox";
            WastedTimetextBox.ReadOnly = true;
            WastedTimetextBox.Size = new Size(125, 27);
            WastedTimetextBox.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 377);
            label5.Name = "label5";
            label5.Size = new Size(224, 20);
            label5.TabIndex = 15;
            label5.Text = "Часу витраченого на завдання";
            // 
            // Report
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(666, 684);
            Controls.Add(groupBox1);
            Name = "Report";
            Text = "Report";
            Load += Report_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox UsertextBox;
        private Label label1;
        private Label label2;
        private TextBox AmountOfTasktextBox;
        private TextBox NoStartedtextBox;
        private Label label3;
        private TextBox ProgrestextBox;
        private Label label4;
        private TextBox DonetextBox;
        private Label label;
        private GroupBox groupBox1;
        private TextBox WastedTimetextBox;
        private Label label5;
    }
}