using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.ConsoleApplication.Command;
using HelloWorld.ConsoleApplication.Utils;

namespace HelloWorld.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Commands allow execution of different actions 
            HelloWorldCommand cmd = new HelloWorldCommand();
            cmd.Execute();
            
            // To pause and read the result
            Console.ReadKey();
        }
    }
}
