namespace WinFormsApplication.Forms
{
    partial class ServicesForm
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
            descriptionLabel = new Label();
            servicesContainer = new FlowLayoutPanel();
            createButton = new Button();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            titleLabel.Location = new Point(12, 9);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(55, 20);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Услуги";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(12, 35);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(384, 15);
            descriptionLabel.TabIndex = 1;
            descriptionLabel.Text = "Здесь вы можете просмотреть и преобрести интересующие услуги.";
            // 
            // servicesContainer
            // 
            servicesContainer.AutoScroll = true;
            servicesContainer.FlowDirection = FlowDirection.TopDown;
            servicesContainer.Location = new Point(12, 66);
            servicesContainer.Name = "servicesContainer";
            servicesContainer.Size = new Size(776, 372);
            servicesContainer.TabIndex = 2;
            servicesContainer.WrapContents = false;
            // 
            // createButton
            // 
            createButton.Location = new Point(713, 31);
            createButton.Name = "createButton";
            createButton.Size = new Size(75, 23);
            createButton.TabIndex = 0;
            createButton.Text = "Создать";
            createButton.UseVisualStyleBackColor = true;
            createButton.Visible = false;
            createButton.Click += createButton_Click;
            // 
            // ServicesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(createButton);
            Controls.Add(servicesContainer);
            Controls.Add(descriptionLabel);
            Controls.Add(titleLabel);
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "ServicesForm";
            Text = "Услуги";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Label descriptionLabel;
        private FlowLayoutPanel servicesContainer;
        private Button createButton;
    }
}