using Database.Entities;
using WinFormsApplication.Services.Impl;

namespace WinFormsApplication.Components
{
    public partial class ServiceControl : UserControl
    {
        public event Action OnSubmitClick = delegate { };

        public ServiceControl(Service service)
        {
            InitializeComponent();

            priceLabel.Text = string.Format(priceLabel.Text, service.Price.ToString());

            nameLabel.Text = service.Name;
            descriptionLabel.Text = service.Description;
            categoryLabel.Text = string.Format(categoryLabel.Text, service.Category.Name);
            categoryDiscriptionLabel.Text = string.Format(categoryDiscriptionLabel.Text, service.Category.Description);

            imageBox.Image = BitmapGetter.Instance.GetBitmap(service.ImagePath);
        }

        public void SetSubmitButton(string submitButtonText)
        {
            submitButton.Visible = true;
            submitButton.Text = submitButtonText;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            OnSubmitClick();
        }
    }
}
