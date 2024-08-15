using bankapplication.Data;
namespace bankapplication.interfaces
{
    public interface IUserRepository
    {
        void AddUser(User user);
        void RemoveUser(int id);
        Task<IEnumerable<User>> GetUsers();
    }
}

