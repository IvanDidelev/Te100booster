using Database;
using Database.Entities;
using Microsoft.EntityFrameworkCore;
using WinFormsApplication.Components;

namespace WinFormsApplication.Forms
{
    public partial class ServiceDirectionsForm : Form
    {
        public ServiceDirectionsForm()
        {
            InitializeComponent();

            UpdateData();
        }

        private void UpdateData()
        {
            serviceDirectionsContainer.Controls.Clear();

            using var dbContext = new DatabaseContext();

            foreach (var serviceDirection in dbContext.ServiceDirections
                .Include(x => x.Service)
                .ThenInclude(x => x.Category)
                .Include(x => x.Employee)
                .ThenInclude(x => x.User)
                .Include(x => x.Employee.Position)
                .Include(x => x.Client)
                .ThenInclude(x => x.User))
            {
                var serviceDirectionControl = new ServiceDirectionControl(serviceDirection);

                serviceDirectionsContainer.Controls.Add(serviceDirectionControl);
            }
        }

        private void ServiceDirectionsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
