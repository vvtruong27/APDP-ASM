namespace StudentInformationManagementSystem.Models
{
    public class Grade
    {
        public string GradeID { get; set; }
        public string StudentID { get; set; }
        public string CourseID { get; set; }
        public double GradeValue { get; set; } // Điểm số (0-100)
        public string Semester { get; set; }

        // Liên kết với sinh viên và khóa học (nếu cần)
    }
}
