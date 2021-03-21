using System;

namespace GenricDemo
{
    class Program
    {
        static int[] first = { 10, 20, 30 };
        static double[] second = { 10.2, 2.3, 30.5, 6.5 };
        static char[] third = { 'A','B','C' };
        static void Main(string[] args)
        {
            Console.WriteLine("Wlecome to genric console app by amit rana");
            PrintArry obj = new PrintArry();
            obj.FirstArry(first);
            obj.FirstArry(second);
            obj.FirstArry(third);
        }
       
    }
}
