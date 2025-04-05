using StudentInformationManagementSystem.Models;

namespace StudentInformationManagementSystem.Interfaces
{
    public interface IGetProfile
    {
        User GetProfileDetails(string userId);
    }
}
