using System;

namespace dec_3_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Student1 = new Student()//adding value using default constructor
            {
                Name = "Raj Chopra",
                Age = 21,
                Sex = Gender.Male
            };

            Student Student2 = new Student(21, "lala rajpoth", Gender.Male);//adding value using parameterized constructor
            Student Student3 = new Student(20, "chickni chameli", Gender.Female);
            Counter Count = new Counter();

            Count.TotalSTudents();//printing count using boxing
            Count.ExapleOfUnboxing(); //example of unboxing

            Student1.ViewStudent();//printing students using extending class to change the first alphabet of name
            Student2.ViewStudent();
            Student3.ViewStudent();

        }
    }
}
