public class User : IAuthenticate, IGetProfile {
    public int UserID { get; set; }
    public string Username { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Role { get; set; }

    public virtual bool Authenticate() => true;
    public virtual string GetProfileDetails() => $"{Name} ({Role}) - {Email}";
}