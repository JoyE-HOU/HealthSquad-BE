namespace Models;

public class Reminder {
    public int Id { get; set;}
    private User? _user;
    public User? User
    {
        get => _user;
        set
        {
            this._user = value;
        }
    }
    private Prescription? _prescription;
    public Prescription? Prescription
    {
        get => _prescription;
        set
        {
            this._prescription = value;
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