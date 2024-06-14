using Database.Entities;

namespace WinFormsApplication.Services
{
    public interface ICurrentUserService
    {
        public User User { get; }

        public bool IsAdmin { get; }

        public bool IsEmployee { get; }

        public bool IsClient { get; }
    }
}
