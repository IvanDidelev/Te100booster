using Database;
using Database.Entities;
using Microsoft.EntityFrameworkCore;
using WinFormsApplication.Components;
using WinFormsApplication.Services.Impl;

namespace WinFormsApplication.Forms
{
    public partial class ServicesForm : Form
    {
        public ServicesForm()
        {
            InitializeComponent();

            UpdateData();

            if (CurrentUserService.Instance.IsAdmin)
            {
                createButton.Visible = true;
            }
        }

        private void UpdateData()
        {
            using var dbContext = new DatabaseContext();

            servicesContainer.Controls.Clear();

            foreach (var service in dbContext.Services.Include(x => x.Category))
            {
                var serviceControl = new ServiceControl(service);

                if (CurrentUserService.Instance.IsAdmin)
                {
                    serviceControl.SetSubmitButton("Редактировать");

                    serviceControl.OnSubmitClick += () => OnAdminSubmit(service);
                }
                else if (CurrentUserService.Instance.IsClient)
                {
                    serviceControl.SetSubmitButton("Приобрести");

                    serviceControl.OnSubmitClick += () => OnClientSubmit(service);
                }

                servicesContainer.Controls.Add(serviceControl);
            }
        }

        private void OnAdminSubmit(Service service)
        {
            var updateServiceForm = new ServiceSetForm(service);

            updateServiceForm.ValidSubmit += UpdateService;

            updateServiceForm.Show();
        }

        private void UpdateService(Service service)
        {
            using var dbContext = new DatabaseContext();

            var updateService = dbContext.Services.First(x => x.Id == service.Id);

            updateService.Name = service.Name;
            updateService.Description = service.Description;
            updateService.ImagePath = service.ImagePath;
            updateService.Price = service.Price;
            updateService.CategoryId = service.CategoryId;

            dbContext.Update(updateService);

            dbContext.SaveChanges();

            UpdateData();
        }

        private void OnClientSubmit(Service service)
        {
            using var dbContext = new DatabaseContext();

            var currentClient = dbContext.Clients.FirstOrDefault(x => x.UserId == CurrentUserService.Instance.User.Id);

            dbContext.ServiceDirections.Add(new()
            {
                ServiceId = service.Id,
                ClientId = currentClient.Id,
                EmployeeId = null,
                Amount = 1,
                Price = service.Price,
                CreatedTime = DateTime.Now,
                ServedTime = null,
                IsCompleted = false,
            });

            dbContext.SaveChanges();

            MessageBox.Show("Заявка успешно создана");
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            var createServiceForm = new ServiceSetForm();

            createServiceForm.ValidSubmit += CreateService;

            createServiceForm.Show();
        }

        private void CreateService(Service service)
        {
            using var dbContext = new DatabaseContext();

            dbContext.Services.Add(service);

            dbContext.SaveChanges();

            UpdateData();
        }
    }
}
