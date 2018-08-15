using System;

namespace Training1
{
    class MainClass
    {
        public static string CreatePhoneNumber(int[] numbers)
        {
            String output = string.Concat(numbers);
            output = long.Parse(output).ToString("(000) 000-0000");

            return output;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Output: "+CreatePhoneNumber(new int[]{ 1,2,3,4,5,6,7,8,9,0}));
        }
    }
}
