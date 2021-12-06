using System;

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