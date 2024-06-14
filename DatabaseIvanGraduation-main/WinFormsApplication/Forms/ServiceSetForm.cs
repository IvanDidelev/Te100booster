using Database;
using Database.Entities;
using WinFormsApplication.Helpers;
using WinFormsApplication.Services.Impl;

namespace WinFormsApplication.Forms
{
    public partial class ServiceSetForm : Form
    {
        private readonly VerificationContext _verificationContext;
        private int? _serviceId;

        public event Action<Service> ValidSubmit = delegate { };

        public ServiceSetForm(Service? service = null)
        {
            _serviceId = service?.Id;

            InitializeComponent();

            _verificationContext = new VerificationContext();

            _verificationContext.CreateValidation(nameTextBox, nameLabel,
                VerificationHelper.StringLengthCondition(() => nameTextBox.Text, 5, 64));

            _verificationContext.CreateValidation(descriptionTextBox, descriptionLabel,
                VerificationHelper.StringLengthCondition(() => descriptionTextBox.Text, 5, 128));

            _verificationContext.CreateValidation(imageComboBox, imageLabel,
                VerificationHelper.StringLengthCondition(() => imageComboBox.Text, 5, 64));

            _verificationContext.CreateValidation(categoryComboBox, categoryLabel,
                () => categoryComboBox.SelectedItem is CategoryItem);

            using var dbContext = new DatabaseContext();

            categoryComboBox.Items.AddRange(
                dbContext.Categories
                .Select(category =>
                    new CategoryItem()
                    {
                        Id = category.Id,
                        Name = category.Name,
                    })
                .ToArray());

            imageComboBox.Items.AddRange(BitmapGetter.Instance.GetBitmapsList().ToArray());

            if (service is null)
            {
                Name = titleLabel.Text = "Создать услугу";

                infoLabel.Text = "Здесь вы можете создать новую услугу";

                submitButton.Text = "Создать";
            }
            else
            {
                Name = titleLabel.Text = "Обновить услугу";

                infoLabel.Text = "Здесь вы можете обновить данные, уже созданной, услуги";

                submitButton.Text = "Обновить";

                nameTextBox.Text = service.Name;
                descriptionTextBox.Text = service.Description;
                priceInput.Value = service.Price;

                foreach (CategoryItem categoryItem in categoryComboBox.Items)
                {
                    if (categoryItem.Id == service.CategoryId)
                    {
                        categoryComboBox.SelectedItem = categoryItem;

                        break;
                    }
                }

                imageComboBox.SelectedItem = service.ImagePath;
            }
        }

        private void imageComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            imageBox.Image = BitmapGetter.Instance.GetBitmap(imageComboBox.Text);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (!_verificationContext.Verify())
            {
                return;
            }

            ValidSubmit(new Service()
            {
                Id = _serviceId ?? 0,
                Name = nameTextBox.Text,
                Description = descriptionTextBox.Text,
                CategoryId = (categoryComboBox.SelectedItem as CategoryItem).Id,
                ImagePath = imageComboBox.Text,
                Price = priceInput.Value,
            });

            Close();
        }

        private class CategoryItem
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public override string ToString()
            {
                return Name;
            }
        }
    }
}
