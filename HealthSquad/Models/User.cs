using CustomExceptions;
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
            if(string.IsNullOrWhiteSpace(value))
            {
                throw new InputInvalidException("Username can't be empty");
            }
            else
            {
                this._username = value;
            }
        }
    }

    // public string? Password { get; set; }
    private string? _password;
    public string? Password
    {
        get => _password;
        set
        {
            if(string.IsNullOrWhiteSpace(value))
            {
                throw new InputInvalidException("Password can't be empty");
            }
            else
            {
                this._password = value;
            }
        }
    }

    public List<Prescription>? Prescriptions { get; set; }
    public List<Reminder>? Reminders { get; set; }
}