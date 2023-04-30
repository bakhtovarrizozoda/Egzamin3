using Domain.Models;
using Infrastructure.Services;

var studentService = new StudentService();

var stud1 = new Student("Bakhtovar", "Rizozoda", "Hamadoni", new DateTime(2002,02,02));

studentService.AddStudent(stud1);

Console.ReadLine();
studentService.Show();