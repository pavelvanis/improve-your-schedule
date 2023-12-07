using improve_your_schedule.lib;

namespace improve_your_schedule;

public class ClassRoom
{
    public const int Floors = 4;
    private readonly string _name;
    private readonly int _floor;

    public ClassRoom(string name, int floor)
    {
        _name = Validator.CheckNullOrEmpty(name, "Name cannot be null or empty");
        Validator.CheckNullOrEmpty(floor, "Floor cannot be null or empty");
        _floor = Validator.IsInRange(floor, 0, Floors, "Floor must be between 0 and " + Floors);
    }

    public string GetName() => _name;
    public int GetFloor() => _floor;

    public override string ToString()
    {
        return "Classroom: " + _name + "\n" +
               "Floor: " + _floor + "\n";
    }
}