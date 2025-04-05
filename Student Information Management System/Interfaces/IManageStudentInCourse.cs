using StudentInformationManagementSystem.Services;

namespace Student_Information_Management_System.Interfaces
{
    public interface IManageStudentInCourse
    {
        public void AddStudentToCourse(string studentId, string courseId);


        public List<string> GetCoursesOfStudent(string studentId);

    }
}
