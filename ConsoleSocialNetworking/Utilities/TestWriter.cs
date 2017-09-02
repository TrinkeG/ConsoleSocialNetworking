using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSocialNetworking.Utilities
{
    public class TestWriter : IOutputWriter
    {
        public  List<string> WrittenLines = new List<string>();
        public void WriteLine(string line)
        {
            Console.WriteLine(line);
            WrittenLines.Add(line);
        }
    }
}
