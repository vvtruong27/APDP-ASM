using System.Collections.Generic;

namespace StudentInformationManagementSystem.Services
{
    public class ManageStudentInCourse
    {
        private readonly CSVServices csvServices;

        public ManageStudentInCourse(CSVServices services)
        {
            csvServices = services;
        }

        public void AddStudentToCourse(string studentId, string courseId)
        {
            var courses = csvServices.ReadData();
            
            foreach (var course in courses)
            {
                if (course[0] == courseId) // CourseID ở cột 0
                {
                    course[6] += $"{studentId};"; // Thêm StudentID vào danh sách sinh viên của khóa học
                    break;
                }
            }

            csvServices.WriteData(courses);
        }

        public List<string> GetStudentsInCourse(string courseId)
        {
            var courses = csvServices.ReadData();

            foreach (var course in courses)
            {
                if (course[0] == courseId) // CourseID ở cột 0
                {
                    return new List<string>(course[6].Split(';')); // Tách danh sách StudentID bằng dấu ';'
                }
            }

            return null;
        }
    }
}
