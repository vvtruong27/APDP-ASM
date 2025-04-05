using StudentInformationManagementSystem.Models;
using StudentInformationManagementSystem.Services;

namespace Student_Information_Management_System.Interfaces
{
    public interface IManageUser
    {
        void AddUser(User user);
        void UpdateUser(User user);
        bool RemoveUser(string userId);
        User GetUser(string userId);
        List<User> GetAllUsers();
        public List<User> GetNonAdminUsers();

    }
}
