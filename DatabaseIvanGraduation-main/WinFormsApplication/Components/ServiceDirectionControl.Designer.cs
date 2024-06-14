namespace WinFormsApplication.Components
{
    partial class ServiceDirectionControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            positionLabel = new Label();
            hasCertificatesCheckBox = new CheckBox();
            coachLabel = new Label();
            clientFullNameLabel = new Label();
            serviceImageBox = new PictureBox();
            serviceDescriptionLabel = new Label();
            serviceNameLabel = new Label();
            isCompletedCheckBox = new CheckBox();
            directionPeriodLabel = new Label();
            amountLabel = new Label();
            categoryDiscriptionLabel = new Label();
            categoryLabel = new Label();
            priceLabel = new Label();
            pinButton = new Button();
            ((System.ComponentModel.ISupportInitialize)serviceImageBox).BeginInit();
            SuspendLayout();
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Location = new Point(525, 159);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new Size(111, 20);
            positionLabel.TabIndex = 21;
            positionLabel.Text = "Должность: {0}";
            // 
            // hasCertificatesCheckBox
            // 
            hasCertificatesCheckBox.AutoCheck = false;
            hasCertificatesCheckBox.AutoSize = true;
            hasCertificatesCheckBox.Location = new Point(248, 157);
            hasCertificatesCheckBox.Margin = new Padding(3, 4, 3, 4);
            hasCertificatesCheckBox.Name = "hasCertificatesCheckBox";
            hasCertificatesCheckBox.Size = new Size(250, 24);
            hasCertificatesCheckBox.TabIndex = 20;
            hasCertificatesCheckBox.Text = "Справки о состоянии здоровья";
            hasCertificatesCheckBox.UseVisualStyleBackColor = true;
            // 
            // coachLabel
            // 
            coachLabel.AutoSize = true;
            coachLabel.Location = new Point(507, 133);
            coachLabel.Name = "coachLabel";
            coachLabel.Size = new Size(85, 20);
            coachLabel.TabIndex = 19;
            coachLabel.Text = "Тренер: {0}";
            // 
            // clientFullNameLabel
            // 
            clientFullNameLabel.AutoSize = true;
            clientFullNameLabel.Location = new Point(226, 133);
            clientFullNameLabel.Name = "clientFullNameLabel";
            clientFullNameLabel.Size = new Size(83, 20);
            clientFullNameLabel.TabIndex = 18;
            clientFullNameLabel.Text = "Клиент: {0}";
            // 
            // serviceImageBox
            // 
            serviceImageBox.Image = Properties.Resources.LionGym;
            serviceImageBox.Location = new Point(10, 52);
            serviceImageBox.Margin = new Padding(3, 4, 3, 4);
            serviceImageBox.Name = "serviceImageBox";
            serviceImageBox.Size = new Size(209, 163);
            serviceImageBox.SizeMode = PictureBoxSizeMode.Zoom;
            serviceImageBox.TabIndex = 17;
            serviceImageBox.TabStop = false;
            // 
            // serviceDescriptionLabel
            // 
            serviceDescriptionLabel.Location = new Point(226, 52);
            serviceDescriptionLabel.Name = "serviceDescriptionLabel";
            serviceDescriptionLabel.Size = new Size(615, 81);
            serviceDescriptionLabel.TabIndex = 16;
            serviceDescriptionLabel.Text = "Очень длинное очень очень чуть чуть можно много нельзя описание";
            // 
            // serviceNameLabel
            // 
            serviceNameLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            serviceNameLabel.Location = new Point(10, 0);
            serviceNameLabel.Name = "serviceNameLabel";
            serviceNameLabel.Size = new Size(813, 48);
            serviceNameLabel.TabIndex = 15;
            serviceNameLabel.Text = "Название";
            serviceNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // isCompletedCheckBox
            // 
            isCompletedCheckBox.AutoCheck = false;
            isCompletedCheckBox.Location = new Point(10, 303);
            isCompletedCheckBox.Margin = new Padding(3, 4, 3, 4);
            isCompletedCheckBox.Name = "isCompletedCheckBox";
            isCompletedCheckBox.Size = new Size(102, 25);
            isCompletedCheckBox.TabIndex = 27;
            isCompletedCheckBox.Text = "Завершено";
            isCompletedCheckBox.UseVisualStyleBackColor = true;
            isCompletedCheckBox.CheckedChanged += isCompletedCheckBox_CheckedChanged;
            // 
            // directionPeriodLabel
            // 
            directionPeriodLabel.AutoSize = true;
            directionPeriodLabel.Location = new Point(128, 303);
            directionPeriodLabel.Name = "directionPeriodLabel";
            directionPeriodLabel.Size = new Size(217, 20);
            directionPeriodLabel.TabIndex = 26;
            directionPeriodLabel.Text = "Период направления: {0} - {1}";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            amountLabel.Location = new Point(10, 251);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(105, 19);
            amountLabel.TabIndex = 25;
            amountLabel.Text = "Количество: {0}";
            // 
            // categoryDiscriptionLabel
            // 
            categoryDiscriptionLabel.Location = new Point(226, 249);
            categoryDiscriptionLabel.Name = "categoryDiscriptionLabel";
            categoryDiscriptionLabel.Size = new Size(615, 53);
            categoryDiscriptionLabel.TabIndex = 24;
            categoryDiscriptionLabel.Text = "Описание категории: {0}";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new Point(226, 221);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(106, 20);
            categoryLabel.TabIndex = 23;
            categoryLabel.Text = "Категория: {0}";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            priceLabel.Location = new Point(10, 221);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(64, 19);
            priceLabel.TabIndex = 22;
            priceLabel.Text = "Цена: {0}";
            // 
            // pinButton
            // 
            pinButton.Location = new Point(669, 292);
            pinButton.Margin = new Padding(3, 4, 3, 4);
            pinButton.Name = "pinButton";
            pinButton.Size = new Size(172, 31);
            pinButton.TabIndex = 28;
            pinButton.Text = "Назначить себя";
            pinButton.UseVisualStyleBackColor = true;
            pinButton.Visible = false;
            pinButton.Click += pinButton_Click;
            // 
            // ServiceDirectionControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(pinButton);
            Controls.Add(isCompletedCheckBox);
            Controls.Add(directionPeriodLabel);
            Controls.Add(amountLabel);
            Controls.Add(categoryDiscriptionLabel);
            Controls.Add(categoryLabel);
            Controls.Add(priceLabel);
            Controls.Add(positionLabel);
            Controls.Add(hasCertificatesCheckBox);
            Controls.Add(coachLabel);
            Controls.Add(clientFullNameLabel);
            Controls.Add(serviceImageBox);
            Controls.Add(serviceDescriptionLabel);
            Controls.Add(serviceNameLabel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ServiceDirectionControl";
            Size = new Size(853, 336);
            ((System.ComponentModel.ISupportInitialize)serviceImageBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label positionLabel;
        private CheckBox hasCertificatesCheckBox;
        private Label coachLabel;
        private Label clientFullNameLabel;
        private PictureBox serviceImageBox;
        private Label serviceDescriptionLabel;
        private Label serviceNameLabel;
        private CheckBox isCompletedCheckBox;
        private Label directionPeriodLabel;
        private Label amountLabel;
        private Label categoryDiscriptionLabel;
        private Label categoryLabel;
        private Label priceLabel;
        private Button pinButton;
    }
}
