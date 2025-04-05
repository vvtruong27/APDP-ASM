using StudentInformationManagementSystem.Models;
using StudentInformationManagementSystem.Services;

public class Faculty : User
{
    public void AddGrade(string gradeId, string studentId, string courseId, double gradeValue, string semester, ManageGrades gradeService)
    {
        gradeService.AddGrade( studentId, courseId, gradeValue, semester);
    }

    public List<Grade> ViewAllGrades(ManageGrades gradeService)
    {
        return gradeService.GetAllGrades();
    }

    public void EditGrade(string gradeId, string studentId, string courseId, double gradeValue, string semester, ManageGrades gradeService)
    {
        gradeService.UpdateGrade(gradeId, studentId, courseId, gradeValue, semester);
    }

    public void RemoveGrade(string gradeId, ManageGrades gradeService)
    {
        gradeService.DeleteGrade(gradeId);
    }
    public List<(Course course, double? grade)> GetAcademicRecords(string id , ViewAcademicRecords viewAcademicRecords)
    {

        return viewAcademicRecords.GetAcademicRecords(id);
    }
    public User GetProfileDetails(string userId, ProfileService profile)
    {
       

        return profile.GetProfileDetails(userId);
    }
    public bool Authenticate(string username, string password , AuthManage authManage)
    {
        
        return authManage.Authenticate(username, password);
    }
    public void AssignFacultyToCourse(string facultyId, string courseId, ManageCourse assignFacultyService)
    {
        assignFacultyService.AddFacultyToCourse(facultyId, courseId);
    }
}
