using System;
using System.Threading;

namespace Lab.lab5
{
    public class lab5
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Set Min");
            int min = int.Parse(Console.ReadLine() ?? string.Empty);
            Console.WriteLine("Set Sec");
            int sec = int.Parse(Console.ReadLine() ?? string.Empty);
            while (min >= 0)
            {
                while (sec >= 0)
                {
                    Console.WriteLine(min + " : " + sec);
                    sec--;
                    try
                    {
                        Thread.Sleep(100);
                    }
                    catch (Exception e)
                    {

                    }
                }

                if (sec < 0) {
                    sec = 59;
                }

                min--;
            }

            Console.WriteLine("Bùm ..");
        }
    }
}
