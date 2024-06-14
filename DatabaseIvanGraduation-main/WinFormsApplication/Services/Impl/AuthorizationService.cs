using System.Text.Json;
using Database;
using WinFormsApplication.Exceptions;

namespace WinFormsApplication.Services.Impl
{
    public class AuthorizationService : IAuthorizationService
    {
        private static IAuthorizationService _instance;
        private string _tempPath;

        public static IAuthorizationService Instance => _instance ?? (_instance = new AuthorizationService());

        public AuthorizationService()
        {
            _tempPath = Path.Combine(Environment.CurrentDirectory, "login.ini");

            if (File.Exists(_tempPath))
            {
                try
                {
                    var data = JsonSerializer.Deserialize<AuthorizationInfo>(File.ReadAllText(_tempPath));

                    SignIn(data.Login, data.Password);

                    return;
                }
                catch(AuthException ex)
                {
                }
            }

            Authorized = false;
        }

        public bool Authorized { get; private set; }

        public void Logout()
        {
            Authorized = false;

            if (File.Exists(_tempPath))
            {
                File.Delete(_tempPath);
            }
        }

        public void SignIn(string login, string password)
        {
            using var dbContext = new DatabaseContext();

            var user = dbContext.Users.FirstOrDefault(x => x.Password == password && x.Login == login);

            if (user is null)
            {
                throw new AuthException();
            }

            Authorized = true;

            if (CurrentUserService.Instance is ICurrentUserAccessor accessor)
            {
                accessor.User = user;
            }
            else
            {
                throw new NotImplementedException();
            }

            if (File.Exists(_tempPath) == false)
            {
                var fileStream = File.Create(_tempPath);

                fileStream.Dispose();
            }

            var data = new AuthorizationInfo
            {
                Login = login,
                Password = password
            };
            var serializedData = JsonSerializer.Serialize(data);

            File.WriteAllText(_tempPath, serializedData);
        }

        private class AuthorizationInfo
        {
            public string Login { get; set; }

            public string Password { get; set; }
        }
    }
}
