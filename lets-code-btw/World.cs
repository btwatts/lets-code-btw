using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lets_code_btw
{
    public interface IWorld
    {
        string GetWorld();
    }
    public class World: IWorld
    {
        private string Greeting { get; set; }
        public World(string greeting)
        {
            Greeting = greeting;
        }
        public string GetWorld() {
            return Greeting;
        }
    }
}
