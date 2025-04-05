using Student_Information_Management_System.Interfaces;
using StudentInformationManagementSystem.Services;

namespace StudentInformationManagementSystem.Models
{
    public class Administrator : User
    {
        // xác thực
        public bool Authenticate(string username, string password, AuthManage authManage)
        {

            return authManage.Authenticate(username, password);
        }
        // Quản lý khóa học
        public void AddCourse(Course course , ManageCourse manageCourse)
        {
            manageCourse.AddCourse(course);
        }

        public Course GetCourse(string courseId, ManageCourse manageCourse)
        {
           
            return manageCourse.GetCourse(courseId);
        }

        public bool RemoveCourse(string courseId, ManageCourse manageCourse)
        {
            

            return manageCourse.RemoveCourse(courseId);
        }

        public List<string> GetCoursesOfStudent(string studentId, ManageCourse manageCourse)
        {
            return manageCourse.GetCoursesOfStudent(studentId);
        }

        // ---------- Triển khai IManageUser ----------
        public void AddUser(User user, ManageUser manageUser)
        {
            manageUser.AddUser(user);
        }

        public User GetUser(string userId , ManageUser manageUser)
        {
          return manageUser.GetUser(userId);
        }

        public bool RemoveUser(string userId, ManageUser manageUser)
        {
            

            return manageUser.RemoveUser(userId);
        }

        public List<User> GetNonAdminUsers(ManageUser manageUser)
        {
            
            return manageUser.GetNonAdminUsers();
        }

        public void UpdateUser(User updatedUser, ManageUser manageUser)
        {
            manageUser.UpdateUser(updatedUser);
        }
        public List<User> GetAllUsers(ManageUser manageUser)
        {
            
            return manageUser.GetAllUsers();
        }
        // Phân Công 
        public bool AddFacultyToCourse(string facultyId, string courseId , ManageCourse assignFaculty)
        {
            
            return assignFaculty.AddFacultyToCourse(facultyId, courseId); 
        }

    }
}
