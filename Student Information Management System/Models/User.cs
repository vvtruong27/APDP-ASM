namespace StudentInformationManagementSystem.Models
{
    public class User
    {
        public string UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Role { get; set; }

        public virtual bool Authenticate(string username, string password)
        {
            // Logic xác thực người dùng
            return this.Username == username && this.Password == password;
        }

        public virtual string GetProfileDetails()
        {
            return $"Name: {Name}, Email: {Email}, Phone: {Phone}, Role: {Role}";
        }
    }
}
