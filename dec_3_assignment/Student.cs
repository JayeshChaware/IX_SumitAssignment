using System;

namespace dec_3_assignment
{
    internal class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Sex { get; set; }
        static string course;
        public Student() { }//Default Constructor
        public Student(int age, string name, Gender sex)// parameterized constructor
        {
            if (name is null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            else
            {
                Name = name;
                Age = age;
                Sex = sex;

            }
        }
        public Student(Student Stud)//Copy Constructor
        {
            Name = Stud.Name;
            Age = Stud.Age;
            Sex = Stud.Sex;
            _ = Counter.IncrementCount();
        }
        static Student()
        {
            course = "MCA";
        }
    }
}

class Counter
{
    private Counter() { }

    public static int currentCount;

    public static int IncrementCount()
    {
        return ++currentCount;
    }

}