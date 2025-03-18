class User: IAuthenticate, IGetProfile
{
    private int userId;
    private string name;
    private string username;
    private string password;
    private string email;
    private string phone;
    private string role;

    public bool Authenticate(User user) {
        throw new System.NotImplementedException();
    }
    public string GetProfileDetails(User user) {
        throw new System.NotImplementedException();
    }
}