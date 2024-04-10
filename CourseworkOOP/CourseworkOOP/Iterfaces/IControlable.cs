using CourseworkOOP.Entities.Users;
namespace CourseworkOOP.Iterfaces
{
    public interface IControlable
    {
        bool AddUser(List<User> users, User user);
        bool DeleteUser(List<User> users, uint id);
    }
}
