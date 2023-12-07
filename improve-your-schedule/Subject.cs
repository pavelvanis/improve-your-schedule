namespace improve_your_schedule;

public class Subject
{
    private readonly string _name;
    private readonly string _type;
    private readonly string _weaklyHours;
    
    public Subject(string name, string type, string weaklyHours) 
    {
        _name = name;
        _type = type;
        _weaklyHours = weaklyHours;
    }

}