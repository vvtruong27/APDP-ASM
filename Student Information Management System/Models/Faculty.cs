namespace StudentInformationManagementSystem.Models
{
    public class Faculty : User
    {
        public override bool Authenticate(string username, string password)
        {
            // Logic xác thực giảng viên (nếu cần tùy chỉnh)
            return base.Authenticate(username, password);
        }

        public void ViewAcademicRecords()
        {
            // Logic xem hồ sơ học tập của sinh viên
            Console.WriteLine("Viewing academic records...");
        }

        public void DownloadTranscript(string format)
        {
            // Logic tải bảng điểm theo định dạng (PDF hoặc PNG)
            Console.WriteLine($"Downloading transcript in {format} format...");
        }
    }
}
