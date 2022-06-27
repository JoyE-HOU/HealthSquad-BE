using CustomExceptions;
namespace Models;

public class Prescription {
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
    private Medication? _medication;
    public Medication? Medication
    {
        get => _medication;
        set
        {
            if(value == null)
            {
                throw new InputInvalidException("Medication can't be empty");
            }
            else
            {
                this._medication = value;
            }
        }
    }
}