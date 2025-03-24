public class Administrator : User {
    public override bool Authenticate(User user) => true;
}