namespace StudentInformationManagementSystem.Models
{
    public class RegisterModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } // Chỉ cho phép "Administrator"
    }
}
