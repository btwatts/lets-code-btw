using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lets_code_btw
{
    public class GreetingGenerator
    {
        private IHello Hello { get; set; }
        private IWorld World { get; set; }

        public GreetingGenerator(IHello hello, IWorld world)
        {
            Hello = hello;
            World = world;
        }
        public string GetGreeting()
        {
            return Hello.GetHello() + " " + World.GetWorld();
        }
    }
}
