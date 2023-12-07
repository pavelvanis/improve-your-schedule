using improve_your_schedule.lib;

namespace improve_your_schedule;

public class Subject
{
    private readonly string _name;
    private readonly string _type;
    private readonly string _weaklyHours;
    
    public Subject(string name, string type, string weaklyHours)
    {
        _name = Validator.CheckNullOrEmpty(name, "Name cannot be null or empty");
        _type = Validator.CheckNullOrEmpty(type, "Type cannot be null or empty");
        _weaklyHours = Validator.CheckNullOrEmpty(weaklyHours, "Weakly hours cannot be null or empty");
    }
    
    public string GetName() => _name;
    public string GetType() => _type;
    public string GetWeaklyHours() => _weaklyHours;

    public override string ToString()
    {
        return "Subject: " + _name + "\n" +
               "Type: " + _type + "\n" +
               "Weakly hours: " + _weaklyHours + "\n";
    }
    
}
