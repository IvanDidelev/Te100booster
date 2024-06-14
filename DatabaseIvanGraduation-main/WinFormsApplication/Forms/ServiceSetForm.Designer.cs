namespace WinFormsApplication.Forms
{
    partial class ServiceSetForm
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
            infoLabel = new Label();
            categoryComboBox = new ComboBox();
            categoryLabel = new Label();
            nameLabel = new Label();
            nameTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            descriptionLabel = new Label();
            priceLabel = new Label();
            priceInput = new NumericUpDown();
            imageLabel = new Label();
            imageComboBox = new ComboBox();
            submitButton = new Button();
            imageBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)priceInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imageBox).BeginInit();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            titleLabel.Location = new Point(12, 9);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(127, 20);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Обновить услугу";
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.Location = new Point(12, 38);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(291, 15);
            infoLabel.TabIndex = 1;
            infoLabel.Text = "Здесь вы можете обновить информацию об услуге";
            // 
            // categoryComboBox
            // 
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(104, 322);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(297, 23);
            categoryComboBox.TabIndex = 2;
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new Point(35, 325);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(63, 15);
            categoryLabel.TabIndex = 3;
            categoryLabel.Text = "Категория";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(15, 63);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(62, 15);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Название:";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(83, 60);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(318, 23);
            nameTextBox.TabIndex = 5;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(83, 98);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(318, 53);
            descriptionTextBox.TabIndex = 7;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(12, 101);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(65, 15);
            descriptionLabel.TabIndex = 6;
            descriptionLabel.Text = "Описание:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(39, 169);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(38, 15);
            priceLabel.TabIndex = 8;
            priceLabel.Text = "Цена:";
            // 
            // priceInput
            // 
            priceInput.Location = new Point(83, 167);
            priceInput.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            priceInput.Name = "priceInput";
            priceInput.Size = new Size(318, 23);
            priceInput.TabIndex = 9;
            // 
            // imageLabel
            // 
            imageLabel.AutoSize = true;
            imageLabel.Location = new Point(12, 208);
            imageLabel.Name = "imageLabel";
            imageLabel.Size = new Size(86, 15);
            imageLabel.TabIndex = 11;
            imageLabel.Text = "Изображение:";
            // 
            // imageComboBox
            // 
            imageComboBox.FormattingEnabled = true;
            imageComboBox.Location = new Point(104, 205);
            imageComboBox.Name = "imageComboBox";
            imageComboBox.Size = new Size(297, 23);
            imageComboBox.TabIndex = 10;
            imageComboBox.SelectedValueChanged += imageComboBox_SelectedValueChanged;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(311, 361);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(90, 23);
            submitButton.TabIndex = 12;
            submitButton.Text = "Отправить";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // imageBox
            // 
            imageBox.BackColor = SystemColors.ControlLight;
            imageBox.Location = new Point(12, 234);
            imageBox.Name = "imageBox";
            imageBox.Size = new Size(389, 82);
            imageBox.SizeMode = PictureBoxSizeMode.Zoom;
            imageBox.TabIndex = 13;
            imageBox.TabStop = false;
            // 
            // ServiceSetForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 396);
            Controls.Add(imageBox);
            Controls.Add(submitButton);
            Controls.Add(imageLabel);
            Controls.Add(imageComboBox);
            Controls.Add(priceInput);
            Controls.Add(priceLabel);
            Controls.Add(descriptionTextBox);
            Controls.Add(descriptionLabel);
            Controls.Add(nameTextBox);
            Controls.Add(nameLabel);
            Controls.Add(categoryLabel);
            Controls.Add(categoryComboBox);
            Controls.Add(infoLabel);
            Controls.Add(titleLabel);
            MaximumSize = new Size(429, 435);
            MinimumSize = new Size(429, 435);
            Name = "ServiceSetForm";
            Text = "Обновить услугу";
            ((System.ComponentModel.ISupportInitialize)priceInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)imageBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Label infoLabel;
        private ComboBox categoryComboBox;
        private Label categoryLabel;
        private Label nameLabel;
        private TextBox nameTextBox;
        private TextBox descriptionTextBox;
        private Label descriptionLabel;
        private Label priceLabel;
        private NumericUpDown priceInput;
        private Label imageLabel;
        private ComboBox imageComboBox;
        private Button submitButton;
        private PictureBox imageBox;
    }
}