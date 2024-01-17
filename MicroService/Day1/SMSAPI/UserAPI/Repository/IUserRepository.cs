using UserAPI.Models;

namespace UserAPI.Repository
{
    public interface IUserRepository
    {
        void Register(User user);
        User Validate(string username, string password);
        void EditUser(User user);
    }
}
