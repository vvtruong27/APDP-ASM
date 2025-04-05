using StudentInformationManagementSystem.Services;

namespace StudentInformationManagementSystem.Models
{
    public class Student : User
    {

        public List<(Course course, double? grade)> GetAcademicRecords(string id, ViewAcademicRecords viewAcademicRecords)
        {

            return viewAcademicRecords.GetAcademicRecords(id);
        }
        public User GetProfileDetails(string userId, ProfileService profile)
        {


            return profile.GetProfileDetails(userId);
        }
        public bool Authenticate(string username, string password, AuthManage authManage)
        {

            return authManage.Authenticate(username, password);
        }

    }
}
