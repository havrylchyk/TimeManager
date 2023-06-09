namespace TimeManager.UI
{
    partial class LoginForm
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
            EmailtextBox = new TextBox();
            PasswordtextBox = new TextBox();
            UsernametextBox = new TextBox();
            Enternamelabel = new Label();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            Applaybutton = new Button();
            Loginbutton = new Button();
            SuspendLayout();
            // 
            // EmailtextBox
            // 
            EmailtextBox.Location = new Point(94, 225);
            EmailtextBox.Multiline = true;
            EmailtextBox.Name = "EmailtextBox";
            EmailtextBox.Size = new Size(386, 35);
            EmailtextBox.TabIndex = 0;
            // 
            // PasswordtextBox
            // 
            PasswordtextBox.Location = new Point(94, 312);
            PasswordtextBox.Multiline = true;
            PasswordtextBox.Name = "PasswordtextBox";
            PasswordtextBox.Size = new Size(386, 35);
            PasswordtextBox.TabIndex = 1;
            PasswordtextBox.UseSystemPasswordChar = true;
            PasswordtextBox.TextChanged += PasswordtextBox_TextChanged;
            // 
            // UsernametextBox
            // 
            UsernametextBox.Location = new Point(94, 137);
            UsernametextBox.Multiline = true;
            UsernametextBox.Name = "UsernametextBox";
            UsernametextBox.Size = new Size(386, 35);
            UsernametextBox.TabIndex = 2;
            // 
            // Enternamelabel
            // 
            Enternamelabel.AutoSize = true;
            Enternamelabel.Location = new Point(94, 114);
            Enternamelabel.Name = "Enternamelabel";
            Enternamelabel.Size = new Size(117, 20);
            Enternamelabel.TabIndex = 3;
            Enternamelabel.Text = "Enter User name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 202);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 4;
            label2.Text = "Enter email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 289);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 5;
            label3.Text = "Enter password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gabriola", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(127, 28);
            label1.Name = "label1";
            label1.Size = new Size(297, 63);
            label1.TabIndex = 6;
            label1.Text = "Welcome to TimeManager";
            // 
            // Applaybutton
            // 
            Applaybutton.BackColor = Color.Thistle;
            Applaybutton.Location = new Point(127, 377);
            Applaybutton.Name = "Applaybutton";
            Applaybutton.Size = new Size(110, 37);
            Applaybutton.TabIndex = 7;
            Applaybutton.Text = "Sing up";
            Applaybutton.UseVisualStyleBackColor = false;
            Applaybutton.Click += Applaybutton_Click;
            // 
            // Loginbutton
            // 
            Loginbutton.BackColor = Color.Thistle;
            Loginbutton.Location = new Point(307, 377);
            Loginbutton.Name = "Loginbutton";
            Loginbutton.Size = new Size(117, 37);
            Loginbutton.TabIndex = 9;
            Loginbutton.Text = "Log in";
            Loginbutton.UseVisualStyleBackColor = false;
            Loginbutton.Click += Loginbutton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(567, 440);
            Controls.Add(Loginbutton);
            Controls.Add(Applaybutton);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Enternamelabel);
            Controls.Add(UsernametextBox);
            Controls.Add(PasswordtextBox);
            Controls.Add(EmailtextBox);
            Name = "LoginForm";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox EmailtextBox;
        private TextBox PasswordtextBox;
        private TextBox UsernametextBox;
        private Label Enternamelabel;
        private Label label2;
        private Label label3;
        private Label label1;
        private Button Applaybutton;
        private Button Loginbutton;
    }
}