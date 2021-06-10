using System;

namespace Thi.Bai2
{
    public delegate void PrimeNumberFinder(int primeNumber);
    public static class Program
    {
        public static event PrimeNumberFinder OnPrimeNumber;
        
        public static PrimeNumberFinder pnf = new PrimeNumberFinder(NoticePrimeNumber);
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Số nguyên tố trong khoảng từ 1 đến 10 là: ");
            for (int i = 2; i <= 10 ; i++)
            {
                if (CheckPrimeNumber(i))
                {
                    OnPrimeNumber = pnf;
                    OnPrimeNumber(i);
                }
            }
            
            
        }
        
        public static void NoticePrimeNumber(int pn)
        {
            Console.WriteLine("Prime Number: " + pn);
        } 
        
        public static Boolean CheckPrimeNumber(int n)
        {
            int result = 0;
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0) result++;
            }

            if (result == 0) return true;
            return false;
        } 
            
        

    }
    
    
    

}