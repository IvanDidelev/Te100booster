using Database.Entities;

namespace WinFormsApplication.Services
{
    public interface ICurrentUserAccessor
    {
        public User User { get; set; }
    }
}
