using WinFormsApplication.Exceptions;
using WinFormsApplication.Helpers;
using WinFormsApplication.Services.Impl;

namespace WinFormsApplication.Forms
{
    public partial class AuthorizationForm : Form
    {
        private VerificationContext _verificationContext;

        public AuthorizationForm()
        {
            InitializeComponent();

            _verificationContext = new();

            _verificationContext.CreateValidation(loginTextBox, loginLabel,
                VerificationHelper.StringLengthCondition(() => loginTextBox.Text, 5, 64));

            _verificationContext.CreateValidation(passwordTextBox, passwordLabel,
                VerificationHelper.StringLengthCondition(() => passwordTextBox.Text, 5, 64));
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (!_verificationContext.Verify())
            {
                return;
            }

            try
            {
                AuthorizationService.Instance.SignIn(loginTextBox.Text, passwordTextBox.Text);

                Close();
            }
            catch (AuthException ex)
            {
                loginLabel.ForeColor = Color.Red;
                loginTextBox.ForeColor = Color.Red;

                passwordLabel.ForeColor = Color.Red;
                passwordTextBox.ForeColor = Color.Red;

                errorLabel.Visible = true;
            }
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            var registrationForm = new RegistrationForm();

            Opacity = 0;

            ShowInTaskbar = false;

            registrationForm.FormClosed += OnRegistrationFormClosed;

            registrationForm.Show();
        }

        private void OnRegistrationFormClosed(object? sender, FormClosedEventArgs e)
        {
            if (AuthorizationService.Instance.Authorized)
            {
                Close();

                return;
            }

            Opacity = 1;

            ShowInTaskbar = true;
        }
    }
}
