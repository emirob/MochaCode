using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class EmiLogger
    {
        private readonly string path;
       
        public EmiLogger() { }
        public EmiLogger(string path) 
        {
            this.path = path;
        }
        public bool Write(string msg)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(this.path, true))
                {
                    sw.WriteLine(msg);
                    sw.Flush();
                    sw.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

            return true;
        }

        public string[] Read
        {
            get
            {
                List<string> lines = new List<string>();

                try
                {
                    using (StreamReader sr = new StreamReader(this.path))
                    {
                        while (sr.EndOfStream != true)
                        {
                            lines.Add(sr.ReadLine());
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return null;
                }

                return lines.ToArray();
            }
        }

    }
}
