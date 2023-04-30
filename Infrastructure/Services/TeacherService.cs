using Domain.Models;

namespace Infrastructure.Services;

public class TeacherService
{
    private List<Teacher> _teachers;

    public TeacherService()
    {
        _teachers = new List<Teacher>();
    }

    public void AddTeacher(Teacher teach)
    {
         teach.Id = _teachers.Count + 1;
         _teachers.Add(teach);
    }

    public List<Teacher> GetTeacher()
    {
        return _teachers;
    }

    public Teacher GetTeacherById(int id)
    {
        foreach (var teach in _teachers)
        {
            if (teach.Id == id) return teach;
        }
        return null;
    }

    public Teacher Update(Teacher teach)
    {
        foreach (var s in _teachers)
        {
            if (s.Id == teach.Id)
            {
                s.Firstname = teach.Firstname;
                s.Lastname = teach.Lastname;
                s.Position = teach.Position;
                s.ExperienceAmount = teach.ExperienceAmount;
                return s;
            }
        }
        return teach;
    }

    public void DeleteTeacher(int id)
    {
        Teacher tea = new Teacher();
        foreach (var teach in _teachers)
        {
            if (teach.Id == id) tea = teach;
        }
        _teachers.Remove(tea);
    }

    public void Show()
    {
        Console.WriteLine("Id|        Firstname|         Lastname|         Position|           ExperienceAmount");
        foreach (var teach in _teachers)
        {
            Console.WriteLine($"{teach.Id}|        {teach.Firstname}|         {teach.Lastname}|         {teach.Position}           {teach.ExperienceAmount}");

        }
    }

    public int CountTeacher()
    {
        return _teachers.Count;
    }
}
