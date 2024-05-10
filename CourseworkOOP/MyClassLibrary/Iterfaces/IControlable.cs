using CourseworkOOP.Entities.Users;
namespace CourseworkOOP.Iterfaces
{
    public interface IControlable
    {
        bool DeleteUser(List<User> users, uint id);
    }
}
