namespace Models;

public class User {
    public int Id { get; set; }
    
    // public string? Username { get; set; }
    private string? _username;
    public string? Username
    {
        get => _username;
        set
        {
            this._username = value;
        }
    }

    // public string? Password { get; set; }
    private string? _password;
    public string? Password
    {
        get => _password;
        set
        {
            this._password = value;
        }
    }
}