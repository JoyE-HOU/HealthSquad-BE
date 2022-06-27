using CustomExceptions;
namespace Models;

public class Reminder {
    public int Id { get; set;}
    private User? _user;
    public User? User
    {
        get => _user;
        set
        {
            if(value == null)
            {
                throw new InputInvalidException("User can't be empty");
            }
            else
            {
                this._user = value;
            }
        }
    }
    private Prescription? _prescription;
    public Prescription? Prescription
    {
        get => _prescription;
        set
        {
            if(value == null)
            {
                throw new InputInvalidException("Prescription can't be empty");
            }
            else
            {
                this._prescription = value;
            }
        }
    }
    private TimeOnly _alert;
    public TimeOnly Alert
    {
        get => _alert;
        set
        {
            this._alert = value;
        }
    }
}