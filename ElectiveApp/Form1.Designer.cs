namespace ElectiveApp
{
    partial class AuthForm
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
            buttonLogin = new Button();
            loginTextBox = new TextBox();
            passwordTextBox = new TextBox();
            SuspendLayout();
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = SystemColors.ScrollBar;
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.ForeColor = SystemColors.ControlText;
            buttonLogin.Location = new Point(138, 97);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(182, 35);
            buttonLogin.TabIndex = 0;
            buttonLogin.Text = "Авторизоваться";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // loginTextBox
            // 
            loginTextBox.BackColor = SystemColors.Control;
            loginTextBox.BorderStyle = BorderStyle.FixedSingle;
            loginTextBox.Location = new Point(138, 21);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(182, 23);
            loginTextBox.TabIndex = 1;
            loginTextBox.Text = "Логин";
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = SystemColors.Control;
            passwordTextBox.BorderStyle = BorderStyle.FixedSingle;
            passwordTextBox.Location = new Point(138, 59);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(182, 23);
            passwordTextBox.TabIndex = 2;
            passwordTextBox.Text = "Пароль";
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(470, 153);
            Controls.Add(passwordTextBox);
            Controls.Add(loginTextBox);
            Controls.Add(buttonLogin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AuthForm";
            Text = "Авторизация";
            WindowState = FormWindowState.Minimized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogin;
        private TextBox loginTextBox;
        private TextBox passwordTextBox;
    }
}
