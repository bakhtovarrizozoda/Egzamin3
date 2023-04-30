using Domain.Models;

namespace Infrastructure.Services;

public class StudentService
{
    private List<Student> _student;

    public StudentService()
    {
        _student = new List<Student>();
    }

    public void AddStudent(Student studen)
    {
         studen.Id = _student.Count + 1;
         _student.Add(studen);
    }

    public List<Student> GetStudent()
    {
        return _student;
    }

    public Student GetStudentById(int id)
    {
        foreach (var studen in _student)
        {
            if (studen.Id == id) return studen;
        }
        return null;
    }

    public Student Update(Student studen)
    {
        foreach (var s in _student)
        {
            if (s.Id == studen.Id)
            {
                s.Firstname = studen.Firstname;
                s.Lastname = studen.Lastname;
                s.Address = studen.Address;
                s.BirthDate = studen.BirthDate;
                return s;
            }
        }
        return studen;
    }

    public void DeleteStudent(int id)
    {
        Student stu = new Student();
        foreach (var studen in _student)
        {
            if (studen.Id == id) stu = studen;
        }
        _student.Remove(stu);
    }

    public void Show()
    {
        Console.WriteLine("Id|        Firstname|         Lastname|         Address|           BirthDate");
        foreach (var studen in _student)
        {
            Console.WriteLine($"{studen.Id}|        {studen.Firstname}|         {studen.Lastname}|         {studen.Address}           {studen.BirthDate}");

        }
    }

    public int CountStudent()
    {
        return _student.Count;
    }
}
