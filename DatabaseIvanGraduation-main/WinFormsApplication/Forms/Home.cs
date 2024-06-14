using WinFormsApplication.Forms;
using WinFormsApplication.Services.Impl;

namespace WinFormsApplication
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

            if (!AuthorizationService.Instance.Authorized)
            {
                ShowAuthorizationForm();
            }
        }

        private void ShowAuthorizationForm()
        {
            var authorizationForm = new AuthorizationForm();

            HideForm();

            authorizationForm.FormClosed += OnAuthorizationFormClosed;

            authorizationForm.Show();
        }

        private void OnAuthorizationFormClosed(object? sender, FormClosedEventArgs e)
        {
            if (!AuthorizationService.Instance.Authorized)
            {
                Close();

                return;
            }

            ShowForm();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            AuthorizationService.Instance.Logout();

            ShowAuthorizationForm();
        }

        private void servicesButton_Click(object sender, EventArgs e)
        {
            var serviceForm = new ServicesForm();

            HideForm();

            serviceForm.FormClosed += (s, e) => ShowForm();

            serviceForm.Show();
        }

        private void HideForm()
        {
            Opacity = 0;

            ShowInTaskbar = false;
        }

        private void ShowForm()
        {
            Opacity = 1;

            ShowInTaskbar = true;

            Focus();
        }

        private void servicesDirectionButton_Click(object sender, EventArgs e)
        {
            var serviceDirectionsForm = new ServiceDirectionsForm();

            HideForm();

            serviceDirectionsForm.FormClosed += (s, e) => ShowForm();

            serviceDirectionsForm.Show();
        }
    }
}
