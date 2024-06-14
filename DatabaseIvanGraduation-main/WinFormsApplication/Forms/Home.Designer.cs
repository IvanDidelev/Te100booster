namespace WinFormsApplication
{
    partial class Home
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
            titleLabel = new Label();
            quitButton = new Button();
            servicesButton = new Button();
            servicesDirectionButton = new Button();
            gymPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)gymPictureBox).BeginInit();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            titleLabel.Location = new Point(12, 9);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(298, 21);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Добро пожаловать в спортзал \"Леон\"";
            // 
            // quitButton
            // 
            quitButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            quitButton.Location = new Point(660, 12);
            quitButton.Name = "quitButton";
            quitButton.Size = new Size(75, 23);
            quitButton.TabIndex = 1;
            quitButton.Text = "Выйти";
            quitButton.UseVisualStyleBackColor = true;
            quitButton.Click += quitButton_Click;
            // 
            // servicesButton
            // 
            servicesButton.Location = new Point(12, 415);
            servicesButton.Name = "servicesButton";
            servicesButton.Size = new Size(83, 23);
            servicesButton.TabIndex = 2;
            servicesButton.Text = "Услуги";
            servicesButton.UseVisualStyleBackColor = true;
            servicesButton.Click += servicesButton_Click;
            // 
            // servicesDirectionButton
            // 
            servicesDirectionButton.Location = new Point(101, 415);
            servicesDirectionButton.Name = "servicesDirectionButton";
            servicesDirectionButton.Size = new Size(145, 23);
            servicesDirectionButton.TabIndex = 3;
            servicesDirectionButton.Text = "Направления услуг";
            servicesDirectionButton.UseVisualStyleBackColor = true;
            servicesDirectionButton.Click += servicesDirectionButton_Click;
            // 
            // gymPictureBox
            // 
            gymPictureBox.Image = Properties.Resources.LionGym;
            gymPictureBox.Location = new Point(12, 41);
            gymPictureBox.Name = "gymPictureBox";
            gymPictureBox.Size = new Size(725, 368);
            gymPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            gymPictureBox.TabIndex = 4;
            gymPictureBox.TabStop = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 450);
            Controls.Add(gymPictureBox);
            Controls.Add(servicesDirectionButton);
            Controls.Add(servicesButton);
            Controls.Add(quitButton);
            Controls.Add(titleLabel);
            MaximumSize = new Size(763, 489);
            MinimumSize = new Size(763, 489);
            Name = "Home";
            Text = "Домашняя страница";
            ((System.ComponentModel.ISupportInitialize)gymPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Button quitButton;
        private Button servicesButton;
        private Button servicesDirectionButton;
        private PictureBox gymPictureBox;
    }
}
