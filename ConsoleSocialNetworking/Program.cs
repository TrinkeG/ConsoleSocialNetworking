using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleSocialNetworking.Commands;

namespace ConsoleSocialNetworking
{
    class Program
    {
        private const string Prompt = "> ";

        static void Main(string[] args)
        {
            CommandRunner runner = new CommandRunner();
            while (true)
            {
                Console.Write(Prompt);
                string command = Console.ReadLine();
                runner.ExecuteCommand(command);
            }
        }
    }
}
