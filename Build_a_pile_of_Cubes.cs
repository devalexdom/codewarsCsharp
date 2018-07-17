using System;

namespace exe1
{
    class MainClass
    {
        public static long findNb(long m) {
     		long endValue = m,currentValue = 0,n = 1;

            while (currentValue < endValue)
            {
                currentValue += (long)System.Math.Pow((n - 1), 3);
                if (currentValue == endValue)
                {
                    return n-1;
                }
                else
                {
                    n++;
                }

            }

            return -1;
  		}
    
        public static void Main(string[] args)
        {
            Console.WriteLine("Exe1 Codewars");
            Console.WriteLine("Test: "+MainClass.findNb(4183059834009));
           
        }
    }
}
