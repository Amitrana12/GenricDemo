using System;
using System.Collections.Generic;
using System.Text;

namespace GenricDemo
{
    public class PrintArry
    {
        public void FirstArry<T>(T[] first)
        {

            foreach (T item in first)
            {
                Console.WriteLine(item);

            }
        }
       
    }
}
