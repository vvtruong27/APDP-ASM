using StudentInformationManagementSystem.Models;

namespace StudentInformationManagementSystem.Interfaces
{
    public interface IViewAcademicRecords
    {
        List<(Course course, double? grade)> GetAcademicRecords(string userId);
    }
}
