using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternDemo
{
    public class Off : IModemState
    {
        public IModemState Connect()
        {
            Console.WriteLine("Please turn on the modem");
            return this;
        }

        public IModemState Disconnect()
        {
            Console.WriteLine("Please turn on the modem");
            return this;
        }

        public IModemState TurnOn()
        {
            Console.WriteLine("Turning On");
            return new On();
        }

        public IModemState TurnOff()
        {
            return this;
        }
    }
}
