using StudentInformationManagementSystem.Interfaces;
using StudentInformationManagementSystem.Models;
using StudentInformationManagementSystem.Services;

public class ViewAcademicRecords : IViewAcademicRecords
{
    private readonly ManageStudentInCourse _studentCourseService;
    private readonly ManageCourse _manageCourse;
    private readonly ManageGrades _manageGrades;

    public ViewAcademicRecords()
    {
        _studentCourseService = new ManageStudentInCourse(new CSVServices("Data/courses.csv"));
        _manageCourse = new ManageCourse(new CSVServices("Data/courses.csv"));
        _manageGrades = new ManageGrades(new CSVServices("Data/grades.csv"));
    }

    public List<(Course course, double? grade)> GetAcademicRecords(string id)
    {
        var courseIds = _studentCourseService.GetCoursesOfStudent(id); // bạn cần hàm này
        var courses = new List<(Course course, double? grade)>();

        foreach (var courseId in courseIds)
        {
            var course = _manageCourse.GetCourse(courseId);
            var grade = _manageGrades.GetGrade(id, courseId);

            if (course != null)
            {
                courses.Add((course, grade >= 0 ? grade : null));
            }
        }
        Console.WriteLine("Found courses: " + string.Join(", ", courseIds));


        return courses;
    }
}
