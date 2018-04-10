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
            Console.Write(">> First Name: ");
            var fname = Console.ReadLine();
            Console.Write(">> Enter Last Name: ");
            var lname = Console.ReadLine();
            Console.Write(">> Enter Campus: ");
            var campus = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Creating new person record ...");
            Console.WriteLine("");
            Console.WriteLine($"Adding new student record to {campus} campus ...");
            Console.WriteLine("");
            var student = new Student(fname, lname, campus);

            Console.WriteLine(student.DisplayStudent());

            //End the program with blank line and instructions
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Press <Enter> to quit the program");
            Console.ReadKey();
        }
    }
}
