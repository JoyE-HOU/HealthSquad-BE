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
            this._name = value;
        }
    }
    private string? _description;
    public string? Description
    {
        get => _description;
        set
        {
            this._description = value;
        }
    }
    private string? _dosage;
    public string? Dosage
    {
        get => _dosage;
        set
        {
            this._dosage = value;
        }
    }
    private string? _directions;
    public string? Directions
    {
        get => _directions;
        set
        {
            this._description = value;
        }
    }
    private int _count;
    public int Count
    {
        get => _count;
        set
        {
            this._count = value;
        }
    }
}
