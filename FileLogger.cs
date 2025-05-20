using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Solid_Principle
{
    internal class FileLogger : ILogger
    {
        public void Log(string message)
        {
            File.WriteAllText("log.txt", message);
            Console.WriteLine($"[FileLogger] {message}");
        }
        

    }
}
