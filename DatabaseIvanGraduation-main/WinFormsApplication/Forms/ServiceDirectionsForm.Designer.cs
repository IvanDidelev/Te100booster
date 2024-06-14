namespace WinFormsApplication.Forms
{
    partial class ServiceDirectionsForm
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
            descriptionLabel = new Label();
            titleLabel = new Label();
            serviceDirectionsContainer = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(14, 41);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(389, 20);
            descriptionLabel.TabIndex = 3;
            descriptionLabel.Text = "Здесь вы можете найти созданные направления услуг";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            titleLabel.Location = new Point(14, 12);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(185, 25);
            titleLabel.TabIndex = 2;
            titleLabel.Text = "Направления услуг";
            // 
            // serviceDirectionsContainer
            // 
            serviceDirectionsContainer.AutoScroll = true;
            serviceDirectionsContainer.FlowDirection = FlowDirection.TopDown;
            serviceDirectionsContainer.Location = new Point(14, 71);
            serviceDirectionsContainer.Margin = new Padding(3, 4, 3, 4);
            serviceDirectionsContainer.Name = "serviceDirectionsContainer";
            serviceDirectionsContainer.Size = new Size(887, 513);
            serviceDirectionsContainer.TabIndex = 4;
            serviceDirectionsContainer.WrapContents = false;
            // 
            // ServiceDirectionsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 589);
            Controls.Add(serviceDirectionsContainer);
            Controls.Add(descriptionLabel);
            Controls.Add(titleLabel);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(930, 636);
            MinimumSize = new Size(930, 636);
            Name = "ServiceDirectionsForm";
            Text = "Направления услуг";
            Load += ServiceDirectionsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label descriptionLabel;
        private Label titleLabel;
        private FlowLayoutPanel serviceDirectionsContainer;
    }
}