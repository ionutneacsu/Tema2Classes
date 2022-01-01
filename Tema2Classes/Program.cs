using System;

namespace Tema2Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please insert the name of the student: ");
            string nameInput = Console.ReadLine();
            Console.WriteLine("Please insert the age: ");
            int ageinput = Convert.ToInt32(Console.ReadLine());
            Student s = new Student( nameInput , ageinput);
        
            Console.WriteLine("Student name is: " + s.Name);
            Console.WriteLine("Student age is: " + s.ageField);
            Console.Read();

        }
    }
}
