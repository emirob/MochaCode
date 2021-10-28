using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Util> myList = new List<Util>();
            bool hasMoreThen3 = false;
            for (int i = 0; i < 10; i++)
            {
                hasMoreThen3 = myList != null && myList.Count > 3;
                Util u = new Util(new Param() { height = 1.76f, width = 77.3f });
                myList.Add(u);

                if (hasMoreThen3)
                    Console.WriteLine(i);
               
                
            }
            
        }
    }
}
