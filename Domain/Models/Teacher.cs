namespace Domain.Models;

public class Teacher
{
    public int Id { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Position { get; set; }
    public int ExperienceAmount { get; set; }    

    public Teacher(string firstname, string lastname, string position, int experienceAmount)
    {
        Firstname = firstname;
        Lastname = lastname;
        Position = position;
        ExperienceAmount = experienceAmount;
    }

    public Teacher()
    {

    }
}
