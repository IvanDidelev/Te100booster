namespace WinFormsApplication.Forms
{
    partial class AuthorizationForm
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
            loginLabel = new Label();
            loginTextBox = new TextBox();
            label2 = new Label();
            passwordTextBox = new TextBox();
            passwordLabel = new Label();
            loginButton = new Button();
            errorLabel = new Label();
            registrationButton = new Button();
            SuspendLayout();
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new Point(14, 52);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(55, 20);
            loginLabel.TabIndex = 0;
            loginLabel.Text = "Логин:";
            // 
            // loginTextBox
            // 
            loginTextBox.Location = new Point(80, 48);
            loginTextBox.Margin = new Padding(3, 4, 3, 4);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(247, 27);
            loginTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(14, 12);
            label2.Name = "label2";
            label2.Size = new Size(292, 23);
            label2.TabIndex = 2;
            label2.Text = "Вход в терминал сопртзала \"Леон\"";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(80, 101);
            passwordTextBox.Margin = new Padding(3, 4, 3, 4);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(247, 27);
            passwordTextBox.TabIndex = 4;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(14, 105);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(65, 20);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Пароль:";
            // 
            // loginButton
            // 
            loginButton.Location = new Point(176, 181);
            loginButton.Margin = new Padding(3, 4, 3, 4);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(152, 31);
            loginButton.TabIndex = 5;
            loginButton.Text = "Войти";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.BackColor = Color.Crimson;
            errorLabel.ForeColor = SystemColors.ButtonHighlight;
            errorLabel.Location = new Point(74, 148);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(212, 20);
            errorLabel.TabIndex = 6;
            errorLabel.Text = "Неверный логин или пароль";
            errorLabel.Visible = false;
            // 
            // registrationButton
            // 
            registrationButton.Location = new Point(14, 181);
            registrationButton.Margin = new Padding(3, 4, 3, 4);
            registrationButton.Name = "registrationButton";
            registrationButton.Size = new Size(155, 31);
            registrationButton.TabIndex = 7;
            registrationButton.Text = "Регистрация";
            registrationButton.UseVisualStyleBackColor = true;
            registrationButton.Click += registrationButton_Click;
            // 
            // AuthorizationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 217);
            Controls.Add(registrationButton);
            Controls.Add(errorLabel);
            Controls.Add(loginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(label2);
            Controls.Add(loginTextBox);
            Controls.Add(loginLabel);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(357, 264);
            MinimumSize = new Size(357, 264);
            Name = "AuthorizationForm";
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label loginLabel;
        private TextBox loginTextBox;
        private Label label2;
        private TextBox passwordTextBox;
        private Label passwordLabel;
        private Button loginButton;
        private Label errorLabel;
        private Button registrationButton;
    }
}