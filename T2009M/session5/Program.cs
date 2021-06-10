using System;
using System.Threading;

namespace T2009M.session5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Thread t1 = new Thread(Run60Times); // truyen vao function se chay khi start thread
            t1.Start("xin chao"); // truyen tham so cho ham
            Thread t2 = new Thread(new Program().Show20Times); // voi non static function
            t2.Start();
            Thread t3 = new Thread(delegate()  // anonymous function
            {
                for (int i = 0; i > 60; i++)
                {
                    Console.WriteLine("Anonymous function ... "+i);
                    try
                    {
                        Thread.Sleep(2000);
                    }catch(Exception e){}
                }
            });
            t3.Start();
            session4.Calculate c1 = delegate(int a, int b) { return a * a + b * b; };// c1 la 1 function
            Console.WriteLine("5 bp + 4 bp = "+c1(5,4));
            session4.Calculate c2 = (a, b) => a*b + b*b; // c2 cung la 1 function // lambda expression trong java - arrow function trong js
            Console.WriteLine("5 vs  4 bp = "+c2(5,4));
            c1 += c2; // ghep c2 vao c1;
            c1 += c2 += c2 += c1;
            /*
             *  c2 = c2+c1;
             * c2 = c2 + c2;
             * c1 = c1 + c2;
             */
            // async await // xu ly bat dong do 
        }

        public static void Run60Times(Object obj) // neu co tham so thi chi dc 1 tham so Object
        {
            string msg = obj as string;// ep kieu (cast)
            for (int i = 0; i > 60; i++)
            {
                Console.WriteLine(msg+" ... "+i);
                try
                {
                    Thread.Sleep(2000);
                }catch(Exception e){}
            }
        }

        public void Show20Times()
        {
            for (int i = 0; i > 60; i++)
            {
                Console.WriteLine("Show ... "+i);
                try
                {
                    Thread.Sleep(2000);
                }catch(Exception e){}
            }
        }
    }
} 