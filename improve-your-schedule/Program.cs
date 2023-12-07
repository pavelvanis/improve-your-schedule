namespace improve_your_schedule;

class Program
{
    static void Main(string[] args)
    {
        Subject subject = new ("M", "Lecture", "2");
        Console.WriteLine("Subject\n" + subject);
        
        Teacher teacher = new ("Jan Molic");
        Console.WriteLine("Teacher\n" + teacher);
        
        ClassRoom classRoom = new ("A-1", 1);
        Console.WriteLine("ClassRoom\n" + classRoom);
        
        Lesson lesson = new (subject, teacher, classRoom);
        Console.WriteLine("Lesson\n" + lesson);
        
    }
}