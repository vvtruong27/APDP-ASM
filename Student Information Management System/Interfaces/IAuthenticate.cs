namespace StudentInformationManagementSystem.Interfaces
{
    public interface IAuthenticate
    {
        bool Authenticate(string username, string password);
    }
}
