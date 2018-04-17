using System;

namespace Prog_Assignment_Question_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start the program with Clear();
            Console.Clear();
            
            Console.WriteLine("ENTER NAME OF NEW STUDENT BELOW");
            Console.WriteLine("");

            //fname captures the input of user for their first name
            Console.Write(">> First Name: ");
            var fname = Console.ReadLine();

            //lname caputures the input of users lastname
            Console.Write(">> Enter Last Name: ");
            var lname = Console.ReadLine();

            //campus captures the input of the users campus
            Console.Write(">> Enter Campus: ");
            var campus = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("Creating new person record ...");

            //Student Instance is created for the Student class
            var student = new Student(fname, lname, campus);
            Console.WriteLine("");

            //Displays the users Firstname and Lastname with space inbetween
            Console.WriteLine(student.GetFullName());

            //Displays the user 
            Console.WriteLine($"Adding new student record to {campus} campus ...");
            Console.WriteLine("");
           
            //Displays the students personal info to the screen with their new student ID
            Console.WriteLine(student.PersonInfo());

            //End the program with blank line and instructions
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Press <Enter> to quit the program");
            Console.ReadKey();
        }
    }
}
