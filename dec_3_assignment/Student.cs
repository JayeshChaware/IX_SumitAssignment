using System;
using System.Collections.Generic;

namespace dec_3_assignment
{
    internal class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Sex { get; set; }

        public static string Course => course;

        static readonly string course; // ask this...

        public Student() {}//Default Constructor

        public Student(int age, string name, Gender sex)// parameterized constructor + call by value
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
                Counter.IncrementCount();
            }
        }

        public Student(Student Stud)//Copy Constructor + call by reference
        {
            Name = Stud.Name;
            Age = Stud.Age;
            Sex = Stud.Sex;  
        }

        static Student()
        {
            course = "MCA";
        }

        public void ViewStudent()
        {
            Console.WriteLine("Student Name:{0} \nClass:{1}\nAge:{2}\nGender:{3}",Name.ChangeFirstChase(),Course,Age,Sex);//extending String class execution
        }
    }
}
