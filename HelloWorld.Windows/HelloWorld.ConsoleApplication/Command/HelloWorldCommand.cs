using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.ConsoleApplication.Processor;

namespace HelloWorld.ConsoleApplication.Command
{
    public class HelloWorldCommand : ICommand
    {
        public void Execute()
        {
            // Process the request and get the results 
            HelloWorldProcessor processor = new HelloWorldProcessor();
            var result = processor.Process();
            Console.WriteLine("Below is the API Response from /api/home");
            Console.WriteLine(result);
        }
    }
}
