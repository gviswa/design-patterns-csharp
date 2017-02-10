using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternDemo
{
    public class On : IModemState
    {
        public IModemState Connect()
        {
            Console.WriteLine("Connecting..");
            return new Connected();
        }

        public IModemState Disconnect()
        {
            Console.WriteLine("Modem not connected already");
            return this;
        }

        public IModemState TurnOn()
        {
            return this;
        }

        public IModemState TurnOff()
        {
            Console.WriteLine("Turning Off");
            return new Off();
        }
    }
}
