using Database;
using Database.Entities;
using WinFormsApplication.Helpers;
using WinFormsApplication.Services.Impl;

namespace WinFormsApplication.Forms
{
    public partial class RegistrationForm : Form
    {
        private readonly VerificationContext _verificationContext;

        public RegistrationForm()
        {
            _verificationContext = new();

            InitializeComponent();

            birthDayInput.MaxDate = DateTime.Now;

            _verificationContext.CreateValidation(firstNameTextBox, firstNameLabel,
                VerificationHelper.StringLengthCondition(() => firstNameTextBox.Text, 5, 64));

            _verificationContext.CreateValidation(middleNameTextBox, middleNameLabel,
                VerificationHelper.StringLengthCondition(() => middleNameTextBox.Text, 5, 64));

            _verificationContext.CreateValidation(lastNameTextBox, lastNameLabel,
                VerificationHelper.StringLengthCondition(() => lastNameTextBox.Text, 5, 64));

            _verificationContext.CreateValidation(phoneTextBox, phoneLabel,
                VerificationHelper.PhoneCondition(() => phoneTextBox.Text));

            _verificationContext.CreateValidation(emailTextBox, emailLabel,
                VerificationHelper.EmailCondition(() => emailTextBox.Text));

            _verificationContext.CreateValidation(loginTextBox, loginLabel,
                VerificationHelper.StringLengthCondition(() => loginTextBox.Text, 3, 32));

            _verificationContext.CreateValidation(passwordTextBox, passwordLabel,
                VerificationHelper.StringLengthCondition(() => passwordTextBox.Text, 3, 32));
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (!_verificationContext.Verify())
            {
                return;
            }

            using var dbContext = new DatabaseContext();

            dbContext.Users.Add(new User()
            {
                RoleId = 1,
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text,
                MiddleName = middleNameTextBox.Text,
                Email = emailTextBox.Text,
                Phone = phoneTextBox.Text,
                BirthDay = birthDayInput.Value,
                Login = loginTextBox.Text,
                Password = passwordTextBox.Text,
            });

            dbContext.SaveChanges();

            AuthorizationService.Instance.SignIn(loginTextBox.Text, passwordTextBox.Text);

            Close();
        }
    }
}
