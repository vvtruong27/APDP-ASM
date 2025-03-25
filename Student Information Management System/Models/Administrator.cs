namespace StudentInformationManagementSystem.Models
{
    public class Administrator : User
    {
        public override bool Authenticate(string username, string password)
        {
            // Logic xác thực quản trị viên (nếu cần tùy chỉnh)
            return base.Authenticate(username, password);
        }

        public override string GetProfileDetails()
        {
            return $"[Admin] {base.GetProfileDetails()}";
        }
    }
}
