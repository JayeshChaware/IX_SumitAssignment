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
            Student Student2 = new Student(21, "lala rajpoth", Gender.Male);
            Student Student3 = new Student(20, "chickni chameli", Gender.Female);
            Counter Count = new Counter();
            Count.TotalSTudents();
            Count.ExapleOfUnboxing();

        }
    }
}
