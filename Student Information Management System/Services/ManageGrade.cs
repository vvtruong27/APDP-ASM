using System.Collections.Generic;

namespace StudentInformationManagementSystem.Services
{
    public class ManageGrades
    {
        private readonly CSVServices csvServices;

        public ManageGrades(CSVServices services)
        {
            csvServices = services;
        }

        public void AddGrade(string gradeId, string studentId, string courseId, double gradeValue, string semester)
        {
            var grades = csvServices.ReadData();
            
            grades.Add(new string[] { gradeId, studentId, courseId, gradeValue.ToString(), semester });
            
            csvServices.WriteData(grades);
        }

        public double GetGrade(string studentId, string courseId)
        {
            var grades = csvServices.ReadData();

            foreach (var grade in grades)
            {
                if (grade[1] == studentId && grade[2] == courseId) // StudentID ở cột 1 và CourseID ở cột 2
                {
                    return double.Parse(grade[3]); // Điểm số ở cột 3
                }
            }

            return -1; // Trả về -1 nếu không tìm thấy điểm số
        }
    }
}
