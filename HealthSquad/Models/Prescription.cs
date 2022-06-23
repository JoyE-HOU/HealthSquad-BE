namespace Models;

public class Prescription {
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
}