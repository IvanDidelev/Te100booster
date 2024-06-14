using Database;
using Database.Entities;
using Microsoft.EntityFrameworkCore;
using WinFormsApplication.Services.Impl;

namespace WinFormsApplication.Components
{
    public partial class ServiceDirectionControl : UserControl
    {
        private readonly string _coachLabelFormat;
        private readonly string _coachPositionFormat;
        private readonly string _periodLabelFormat;
        private int _directionId;

        public ServiceDirectionControl(ServiceDirection serviceDirection)
        {
            _directionId = serviceDirection.Id;

            InitializeComponent();

            _coachLabelFormat = coachLabel.Text;
            _coachPositionFormat = positionLabel.Text;
            _periodLabelFormat = directionPeriodLabel.Text;

            serviceNameLabel.Text = serviceDirection.Service.Name;
            serviceDescriptionLabel.Text = serviceDirection.Service.Description;
            serviceImageBox.Image = BitmapGetter.Instance.GetBitmap(serviceDirection.Service.ImagePath);

            clientFullNameLabel.Text = string.Format(clientFullNameLabel.Text, serviceDirection.Client.User.FullName);
            hasCertificatesCheckBox.Checked = serviceDirection.Client.HasHealthCertificate;

            coachLabel.Text = string.Format(_coachLabelFormat, serviceDirection.Employee?.User.FullName ?? "Не установлено");
            positionLabel.Text = string.Format(_coachPositionFormat, serviceDirection.Employee?.Position?.Title ?? "Не установлено");

            priceLabel.Text = string.Format(priceLabel.Text, serviceDirection.Price);
            amountLabel.Text = string.Format(amountLabel.Text, serviceDirection.Amount);
            directionPeriodLabel.Text = string.Format(_periodLabelFormat, serviceDirection.CreatedTime.ToString(), serviceDirection.ServedTime?.ToString() ?? "Не установлено");

            isCompletedCheckBox.Checked = serviceDirection.IsCompleted;

            categoryLabel.Text = string.Format(categoryLabel.Text, serviceDirection.Service.Category.Name);
            categoryDiscriptionLabel.Text = string.Format(categoryDiscriptionLabel.Text, serviceDirection.Service.Category.Description);

            if (serviceDirection.EmployeeId is null && CurrentUserService.Instance.IsEmployee)
            {
                pinButton.Visible = true;
            }

            if (serviceDirection.Employee is not null && serviceDirection.Employee.User.Id == CurrentUserService.Instance.User.Id)
            {
                isCompletedCheckBox.AutoCheck = true;
            }
        }

        private void pinButton_Click(object sender, EventArgs e)
        {
            using var dbContext = new DatabaseContext();

            var currentEmployee = dbContext.Employees
                .Include(x => x.User)
                .Include(x => x.Position)
                .FirstOrDefault(x => x.UserId == CurrentUserService.Instance.User.Id);

            if (currentEmployee is null)
            {
                return;
            }

            var direction = dbContext.ServiceDirections.First(x => x.Id == _directionId);

            direction.EmployeeId = currentEmployee.Id;

            dbContext.SaveChanges();

            coachLabel.Text = string.Format(_coachLabelFormat, currentEmployee.User.FullName);
            positionLabel.Text = string.Format(_coachPositionFormat, currentEmployee.Position.Title);

            pinButton.Visible = false;
            isCompletedCheckBox.AutoCheck = true;
        }

        private void isCompletedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            using var dbContext = new DatabaseContext();

            var serviceDirection = dbContext.ServiceDirections.First(x => x.Id == _directionId);

            serviceDirection.IsCompleted = isCompletedCheckBox.Checked;
            serviceDirection.ServedTime = isCompletedCheckBox.Checked ? DateTime.Now : null;
            directionPeriodLabel.Text = string.Format(_periodLabelFormat, serviceDirection.CreatedTime,
                serviceDirection.ServedTime?.ToString() ?? "Не установлено");

            dbContext.SaveChanges();
        }
    }
}
