using System.Runtime.InteropServices.JavaScript;

namespace improve_your_schedule.lib;

public class Validator
{
    public static T CheckNullOrEmpty<T>(T value, string message)
    {
        if (EqualityComparer<T>.Default.Equals(value, default(T)) || string.IsNullOrEmpty(value?.ToString()))
        {
            throw new ArgumentException(message);
        }

        return value;
    }

    public static int IsInRange(int value, int min, int max, string message)
    {
        if (value < min || value > max)
        {
            throw new ArgumentException(message);
        }

        return value;
    }
}