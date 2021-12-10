using System;
using System.Threading;
namespace _10_Dec_Assigment
{
    public class ThreadsCollection
    {
        public void GetEven()
        {
            for (int number = 1; number < 1000; number++)
            {
                if (number % 2 == 0)
                { 
                    Console.Write("e:{0}\t", number);
                    Thread.Sleep(10);
                }
            }

            
        }
        public void GetPalindrome()
        {
            for (int number = 1; number < 1000; number++)
            {
                int reverse = 0, temp = number, remainder;
                while (temp != 0)
                {
                    remainder = temp % 10;
                    temp /= 10;
                    reverse = (reverse * 10) + remainder;
                }
                if (reverse == number)
                {
                    Console.Write("p:{0}\t",number);
                    Thread.Sleep(10);

                }
            }
        }
    }
}