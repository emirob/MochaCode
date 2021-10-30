using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        private static string LOGGER_PATH =     "c:"+Path.DirectorySeparatorChar+"emi"
                                                + Path.DirectorySeparatorChar +"emilogger.txt";
        static void Main(string[] args)
        {
            EmiLogger emi = new EmiLogger(LOGGER_PATH);
            emi.Write(DateTime.Now + " system started");
            string[] lines = emi.Read;
            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine(lines[i]);
            }
        }
    }
}
