using improve_your_schedule.lib;

namespace improve_your_schedule;

public class Lesson
{
    private readonly Subject _subject;
    private readonly Teacher _teacher;
    private readonly ClassRoom _classroom;

    public Lesson(Subject subject, Teacher teacher, ClassRoom classroom)
    {
        _subject = Validator.CheckNullOrEmpty(subject, "Subject cannot be null");
        _teacher = Validator.CheckNullOrEmpty(teacher, "Teacher cannot be null");
        _classroom = Validator.CheckNullOrEmpty(classroom, "Classroom cannot be null or empty");
    }

    public Subject GetSubject() => _subject;
    public Teacher GetTeacher() => _teacher;
    public ClassRoom GetClassroom() => _classroom;

    public override string ToString()
    {
        return "Subject: " + _subject.GetName() + "\n" +
               "Teacher: " + _teacher.GetName() + "\n" +
               "Classroom: " + _classroom + "\n";
    }
}