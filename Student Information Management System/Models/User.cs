class User: IAuthenticate, IGetProfile
{
    public int userId;
    public string name;
    public string username;
    public string password;
    public string email;
    public string phone;
    public string role;

    public bool Authenticate(User user) {
        throw new System.NotImplementedException();
    }
    public string GetProfileDetails(User user) {
        throw new System.NotImplementedException();
    }
}