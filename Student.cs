using System;

namespace Prog_Assignment_Question_4
{
    public class Student : Person
    {
        public string Campus {get; set; }
        public int StudentID {get; set; }

        public Student (string firstName, string lastName, string campus) : base (firstName, lastName)
        {
            Campus = campus;
        }

        public int EnrollStudent()
        {
            Random rnd = new Random();
            StudentID = rnd.Next(1000, 9999);

            return StudentID;
        }

        public string DisplayStudent()
        {
            EnrollStudent();

            return $"{FirstName} {LastName} of {Campus} has a student ID of {StudentID}";
        }
    }
}
