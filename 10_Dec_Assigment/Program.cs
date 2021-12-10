using System.IO;
using System.Threading;
using System;

namespace _10_Dec_Assigment
{
    class Program
    {
        
        static void Main(string[] args)
        {

            

            FileStream ostrm;
            StreamWriter writer;
            TextWriter oldOut = Console.Out;
            try
            {
                ostrm = new FileStream("D:/study/cSharp/sumit  assignments/10_Dec_Assigment/Redirect.txt", FileMode.Append, FileAccess.Write);
                writer = new StreamWriter(ostrm);
            }
            catch (FileNotFoundException)
            {
                ostrm = new FileStream("D:/study/cSharp/sumit  assignments/10_Dec_Assigment/Redirect.txt", FileMode.Create, FileAccess.Write);
                writer = new StreamWriter(ostrm);
            }
            catch (Exception e)
            {
                Console.WriteLine("Cannot open Redirect.txt for writing");
                Console.WriteLine(e.Message);
                return;
            }
            Console.SetOut(writer);
            ThreadsCollection executeThread = new ThreadsCollection();

            Console.WriteLine("Output Without thread");
            executeThread.GetEven();
            executeThread.GetPalindrome();

            Thread getEvenNumbersSingle = new Thread(new ThreadStart(executeThread.GetEven));
            Console.WriteLine("\n Output with single thread");
            getEvenNumbersSingle.Start();
            executeThread.GetPalindrome();

            Console.WriteLine("\n Output with double thread");
            Thread getEvenNumbers = new Thread(new ThreadStart(executeThread.GetEven));
            Thread getPalindromeNumbers = new Thread(new ThreadStart(executeThread.GetPalindrome));
            getEvenNumbers.Start();
            getPalindromeNumbers.Start();

            Console.SetOut(oldOut);
            writer.Close();
            ostrm.Close();
            Console.WriteLine("Done");
        }
        
    }
}