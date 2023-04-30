using Domain.Models;

namespace Infrastructure.Services;

public class CourseService
{
    private List<Course> _courses;
    public CourseService()
    {
        _courses = new List<Course>();
    }

    public void AddCourse(Course cours)
    {
         cours.Id = _courses.Count + 1;
         _courses.Add(cours);
    }

    public List<Course> GetCourse()
    {
        return _courses;
    }

    public Coursemk GetCourseById(int id)
    {
        foreach (var cours in _courses)
        {
            if (cours.Id == id) return cours;
        }
        return null;
    }

    public Course Update(Course cours)
    {
        foreach (var s in _courses)
        {
            if (s.Id == cours.Id)
            {
                s.Title = cours.Title;
                s.Description = cours.Description;
                s.Fee = cours.Fee;
                s.HasDiscount = cours.HasDiscount;
                return s;
            }
        }
        return cours;
    }

    public void DeleteCourse(int id)
    {
        Course cou = new Course();
        foreach (var cours in _courses)
        {
            if (cours.Id == id) cou = cours;
        }
        _courses.Remove(cou);
    }

    public void Show()
    {
        Console.WriteLine("Id|        Title|         Description|         Fee|           HasDiscount");
        foreach (var cours in _courses)
        {
            Console.WriteLine($"{cours.Id}|        {cours.Title}|         {cours.Description}|         {cours.Fee}           {cours.HasDiscount}");

        }
    }

    public int CountCourse()
    {
        return _courses.Count;
    }
}
