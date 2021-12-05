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

        static readonly string course;
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
    }
}

class Counter
{
    
    public Counter() { }

    public static int currentCount; //static member

    public static int IncrementCount()
    {

        return ++currentCount;
    }
    object CounterObject = currentCount;//boxing
    public void TotalSTudents()
    {
        Console.WriteLine("total students are :{0}", CounterObject);
    }
    public void ExapleOfUnboxing()
    {
        int objToInt = (int)CounterObject;//unboxing
        Console.WriteLine("object to int conversion demo:{0}", objToInt);
    }
}