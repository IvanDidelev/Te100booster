namespace WinFormsApplication.Forms
{
    partial class RegistrationForm
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
            titleLabel = new Label();
            lastNameLabel = new Label();
            lastNameTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            firstNameLabel = new Label();
            middleNameTextBox = new TextBox();
            middleNameLabel = new Label();
            phoneTextBox = new TextBox();
            phoneLabel = new Label();
            emailTextBox = new TextBox();
            emailLabel = new Label();
            loginTextBox = new TextBox();
            loginLabel = new Label();
            passwordTextBox = new TextBox();
            passwordLabel = new Label();
            birthDayInput = new DateTimePicker();
            birthDayLabel = new Label();
            sendButton = new Button();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            titleLabel.Location = new Point(12, 9);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(96, 20);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Регистрация";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(14, 44);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(61, 15);
            lastNameLabel.TabIndex = 1;
            lastNameLabel.Text = "Фамилия:";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(81, 41);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(243, 23);
            lastNameTextBox.TabIndex = 2;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(81, 80);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(243, 23);
            firstNameTextBox.TabIndex = 4;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(41, 83);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(34, 15);
            firstNameLabel.TabIndex = 3;
            firstNameLabel.Text = "Имя:";
            // 
            // middleNameTextBox
            // 
            middleNameTextBox.Location = new Point(81, 121);
            middleNameTextBox.Name = "middleNameTextBox";
            middleNameTextBox.Size = new Size(243, 23);
            middleNameTextBox.TabIndex = 6;
            // 
            // middleNameLabel
            // 
            middleNameLabel.AutoSize = true;
            middleNameLabel.Location = new Point(14, 124);
            middleNameLabel.Name = "middleNameLabel";
            middleNameLabel.Size = new Size(61, 15);
            middleNameLabel.TabIndex = 5;
            middleNameLabel.Text = "Отчество:";
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(81, 162);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(243, 23);
            phoneTextBox.TabIndex = 8;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new Point(17, 165);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(58, 15);
            phoneLabel.TabIndex = 7;
            phoneLabel.Text = "Телефон:";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(81, 202);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(243, 23);
            emailTextBox.TabIndex = 10;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(31, 205);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(44, 15);
            emailLabel.TabIndex = 9;
            emailLabel.Text = "Почта:";
            // 
            // loginTextBox
            // 
            loginTextBox.Location = new Point(81, 241);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(243, 23);
            loginTextBox.TabIndex = 12;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new Point(31, 244);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(44, 15);
            loginLabel.TabIndex = 11;
            loginLabel.Text = "Логин:";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(81, 279);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(243, 23);
            passwordTextBox.TabIndex = 14;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(23, 282);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(52, 15);
            passwordLabel.TabIndex = 13;
            passwordLabel.Text = "Пароль:";
            // 
            // birthDayInput
            // 
            birthDayInput.Location = new Point(124, 317);
            birthDayInput.Name = "birthDayInput";
            birthDayInput.Size = new Size(200, 23);
            birthDayInput.TabIndex = 15;
            // 
            // birthDayLabel
            // 
            birthDayLabel.AutoSize = true;
            birthDayLabel.Location = new Point(23, 323);
            birthDayLabel.Name = "birthDayLabel";
            birthDayLabel.Size = new Size(95, 15);
            birthDayLabel.TabIndex = 16;
            birthDayLabel.Text = "День рождения:";
            // 
            // sendButton
            // 
            sendButton.Location = new Point(241, 356);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(83, 23);
            sendButton.TabIndex = 17;
            sendButton.Text = "Отправить";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += sendButton_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 391);
            Controls.Add(sendButton);
            Controls.Add(birthDayLabel);
            Controls.Add(birthDayInput);
            Controls.Add(passwordTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(loginTextBox);
            Controls.Add(loginLabel);
            Controls.Add(emailTextBox);
            Controls.Add(emailLabel);
            Controls.Add(phoneTextBox);
            Controls.Add(phoneLabel);
            Controls.Add(middleNameTextBox);
            Controls.Add(middleNameLabel);
            Controls.Add(firstNameTextBox);
            Controls.Add(firstNameLabel);
            Controls.Add(lastNameTextBox);
            Controls.Add(lastNameLabel);
            Controls.Add(titleLabel);
            MaximumSize = new Size(350, 430);
            MinimumSize = new Size(350, 430);
            Name = "RegistrationForm";
            Text = "Регистрация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Label lastNameLabel;
        private TextBox lastNameTextBox;
        private TextBox firstNameTextBox;
        private Label firstNameLabel;
        private TextBox middleNameTextBox;
        private Label middleNameLabel;
        private TextBox phoneTextBox;
        private Label phoneLabel;
        private TextBox emailTextBox;
        private Label emailLabel;
        private TextBox loginTextBox;
        private Label loginLabel;
        private TextBox passwordTextBox;
        private Label passwordLabel;
        private DateTimePicker birthDayInput;
        private Label birthDayLabel;
        private Button sendButton;
    }
}