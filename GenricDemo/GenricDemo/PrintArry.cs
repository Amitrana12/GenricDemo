using System;
using System.Collections.Generic;
using System.Text;

namespace GenricDemo
{
    public class PrintArry
    {
        public void FirstArry(int[] first)
        {
            Array.ForEach(first, Console.WriteLine);
            /*foreach (int item in first)
            {
                Console.WriteLine(item);

            }*/
        }
        public void SecondArry(double[] second)
        {
            Array.ForEach(second, Console.WriteLine);
        }
        public void ThirdArry(char [] third)
        {
            Array.ForEach(third, Console.WriteLine);
        }
    }
}
