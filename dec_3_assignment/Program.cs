using System;

namespace dec_3_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Student Student1 = new Student()
            {
                Name = "Raj Chopra",
                Age = 21,
                Sex = Gender.Male
            };
        }
    }
}
