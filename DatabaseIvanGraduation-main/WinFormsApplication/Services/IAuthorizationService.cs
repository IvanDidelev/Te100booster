namespace WinFormsApplication.Services
{
    public interface IAuthorizationService
    {
        public bool Authorized { get; }

        public void SignIn(string login, string password);

        public void Logout();
    }
}
