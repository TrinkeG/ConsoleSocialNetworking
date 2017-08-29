using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSocialNetworking
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                string command = Console.ReadLine();
                if (command != null && command.Equals("exit"))
                {
                    running = false;
                }
            }
        }
    }
}
