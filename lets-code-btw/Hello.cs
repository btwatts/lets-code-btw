using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lets_code_btw
{
    public interface IHello
    {
        #region Public Methods
        string GetHello();
        #endregion Public Methods
    }
    public class Hello: IHello
    {
        private string Greeting { get; set; }

        public Hello(string greeting)
        {
            Greeting = greeting;
        }
        public string GetHello()
        {
            return Greeting;
        }
    }
}
