using Database.Entities;

namespace WinFormsApplication.Services.Impl
{
    public class CurrentUserService : ICurrentUserService, ICurrentUserAccessor
    {
        private static ICurrentUserService _instance = new CurrentUserService();

        public static ICurrentUserService Instance => _instance;

        private CurrentUserService()
        {
        }

        public User User { get; set; }

        public bool IsAdmin => User.RoleId == 3;

        public bool IsEmployee => User.RoleId == 2;

        public bool IsClient => User.RoleId == 1;
    }
}
