using System;

namespace GenricDemo
{
    class Program
    {
         
        static void Main(string[] args)
        {
            Console.WriteLine("Wlecome to genric console app by amit rana");
            int[] first = { 10, 20, 30 };
            double[] second = { 10.2, 2.3, 30.5, 6.5 };
            char[] third = { 'A', 'B', 'C' };
            new PrintArry<int>(first).toPrint();
            new PrintArry<double>(second).toPrint();
            new PrintArry<char>(third).toPrint();

        }
       
    }
}
