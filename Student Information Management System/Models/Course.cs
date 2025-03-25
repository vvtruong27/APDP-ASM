namespace StudentInformationManagementSystem.Models
{
    public class Course
    {
        public string CourseID { get; set; }
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public string Department { get; set; }
        public int CreditHours { get; set; }
        public string Semester { get; set; }
        
        // Danh sách sinh viên đăng ký khóa học
        public List<Student> Students { get; set; } = new List<Student>();
        
        // Giảng viên phụ trách khóa học
        public Faculty Faculty { get; set; }
    }
}
