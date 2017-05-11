using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lets_code_btw
{
    class Program
    {
        static void Main(string[] args)
        {
            IHello hello = new Hello("Hi");
            IWorld world = new World("Q-C Coders");
            GreetingGenerator greet = new GreetingGenerator(hello, world);
            Console.WriteLine(greet.GetGreeting());
           // Console.ReadKey();
        }
    }
}
