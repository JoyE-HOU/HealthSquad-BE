using CustomExceptions;
namespace Models;
public class Medication
{
    public int Id { get; set; }
    private string? _name;
    public string? Name
    {
        get => _name;
        set
        {
            if(string.IsNullOrWhiteSpace(value))
            {
                throw new InputInvalidException("Name can't be empty");
            }
            else
            {
                this._name = value;
            }
        }
    }
    private string? _description;
    public string? Description
    {
        get => _description;
        set
        {
            if(string.IsNullOrWhiteSpace(value))
            {
                throw new InputInvalidException("Description can't be empty");
            }
            else
            {
                this._description = value;
            }
        }
    }
    private string? _dosage;
    public string? Dosage
    {
        get => _dosage;
        set
        {
            if(string.IsNullOrWhiteSpace(value))
            {
                throw new InputInvalidException("Dosage can't be empty");
            }
            else
            {
                this._dosage = value;
            }
        }
    }
    private string? _directions;
    public string? Directions
    {
        get => _directions;
        set
        {
            if(string.IsNullOrWhiteSpace(value))
            {
                throw new InputInvalidException("Directions can't be empty");
            }
            else
            {
                this._directions = value;
            }
        }
    }
    private int _count;
    public int Count
    {
        get => _count;
        set
        {
            if(value == 0)
            {
                throw new InputInvalidException("Count can't be less than 1");
            }
            else
            {
                this._count = value;
            }
        }
    }
}
