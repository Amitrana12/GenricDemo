using System;
using System.Collections.Generic;
using System.Text;

namespace GenricDemo
{
    public class PrintArry<T>
    {
        private T[] input;
        public PrintArry(T[] arry)
        {
            this.input = arry;  
        }
        public void toPrint()
        {

            foreach (var item in input)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("===============================");
        }
       
    }
}
