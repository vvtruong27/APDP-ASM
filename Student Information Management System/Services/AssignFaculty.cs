using StudentInformationManagementSystem.Models;

namespace StudentInformationManagementSystem.Services
{
    public class AssignFaculty
    {
        private readonly CSVServices csvServices;

        public AssignFaculty(CSVServices services)
        {
            csvServices = services;
        }

        public bool AddFacultyToCourse(string facultyId, string courseId)
        {
            var courses = csvServices.ReadData();
            foreach (var course in courses)
            {
                if (course[0] == courseId) // CourseID ở cột 0
                {
                    course[7] = facultyId; // Gán FacultyID vào cột 7 (faculty)
                    csvServices.WriteData(courses);
                    return true;
                }
            }
            return false; // Không tìm thấy khóa học
        }

        public string GetFacultyForCourse(string courseId)
        {
            var courses = csvServices.ReadData();
            foreach (var course in courses)
            {
                if (course[0] == courseId) // CourseID ở cột 0
                {
                    return course[7]; // FacultyID ở cột 7
                }
            }
            return null; // Không tìm thấy khóa học
        }
    }
}
