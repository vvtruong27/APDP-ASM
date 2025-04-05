using System.Diagnostics;
using StudentInformationManagementSystem.Models;
using StudentInformationManagementSystem.Services;

namespace Student_Information_Management_System.Interfaces
{
    public interface IMangeGrade
    {
        public void AddGrade(string studentId, string courseId, double gradeValue, string semester);
        public double GetGrade(string studentId, string courseId);
        public List<Grade> GetAllGrades();
        public Grade GetGradeById(string gradeId);
        public void UpdateGrade(string gradeId, string studentId, string courseId, double gradeValue, string semester);
        public void DeleteGrade(string gradeId);
    }
}
