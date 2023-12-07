using improve_your_schedule.lib;

namespace improve_your_schedule;

public class Teacher
{
    private readonly string _name;
    
    public Teacher(string name)
    {
        _name = Validator.CheckNullOrEmpty(name, "Name cannot be null or empty");
    }
    
    public string GetName() => _name;
    
    public override string ToString()
    {
        return "Teacher: " + _name + "\n";
    }
}