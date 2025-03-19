public class Administrator : User {
    public override bool Authenticate() => true;
}