namespace Domain.Models;

public class Student
{
    public int Id { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public DateTime BirthDate { get; set; }
    public string Address { get; set; }

    public Student(string firstname, string lastname, string address, DateTime birthDate)
    {
        Firstname = firstname;
        Lastname = lastname;
        Address = address;
        BirthDate = birthDate;
    }

    public Student()
    {

    }
}
