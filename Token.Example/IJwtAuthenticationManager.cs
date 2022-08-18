namespace Token.Example
{
    public interface IJwtAuthenticationManager
    {
        string Authentication(string username, string password);
    }
}
