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
            try// to append the log in file
            {
                ostrm = new FileStream("D:/study/cSharp/sumit  assignments/10_Dec_Assigment/Redirect.txt", FileMode.Append, FileAccess.Write);
                writer = new StreamWriter(ostrm); 
            }
            catch (FileNotFoundException) // if no file exist then to create new file and add log 
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

            Console.WriteLine("Output Without thread");//print even and palindrome number using functions
            executeThread.GetEven();
            executeThread.GetPalindrome();

            Thread getEvenNumbersSingle = new Thread(new ThreadStart(executeThread.GetEven));
            Console.WriteLine("\n Output with single thread");//print even and palindrome number using 1 thread and 1 functions
            getEvenNumbersSingle.Start();
            executeThread.GetPalindrome();

            Console.WriteLine("\n Output with double thread");//print even and palindrome number using double thread
            Thread getEvenNumbers = new Thread(new ThreadStart(executeThread.GetEven));
            Thread getPalindromeNumbers = new Thread(new ThreadStart(executeThread.GetPalindrome));
            getEvenNumbers.Start();
            getPalindromeNumbers.Start();
            getEvenNumbersSingle.Abort();
            getEvenNumbers.Abort();
            getPalindromeNumbers.Abort();
            Console.SetOut(oldOut);
            writer.Close();
            ostrm.Close();
            Console.WriteLine("Done");
        }
        
    }
}