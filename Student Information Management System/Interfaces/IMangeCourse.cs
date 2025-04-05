using NuGet.Protocol.Plugins;
using StudentInformationManagementSystem.Models;
using StudentInformationManagementSystem.Services;

namespace Student_Information_Management_System.Interfaces
{
    public interface IMangeCourse
    {
        public bool AddCourse(Course course);

        public Course GetCourse(string courseId);

        public bool RemoveCourse(string courseId);

        public List<string> GetCoursesOfStudent(string studentId);
        public bool UpdateCourse(Course course);
        public List<Course> ReadCourseData();
        public List<string> GetStudentsOfCourse(string courseId);
        public bool AddFacultyToCourse(string facultyId, string courseId);

        public string GetStudentByID(string studentID);

        public List<User> GetAllUsers();
        public List<Faculty> ReadFacultyData();
        public string GetNameFacultyById(string facultyId);


    }
}
