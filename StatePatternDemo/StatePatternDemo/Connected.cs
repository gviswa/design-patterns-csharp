using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternDemo
{
    public class Connected : IModemState
    {
        public IModemState Connect()
        {
            Console.WriteLine("Already connected");
            return this;
        }

        public IModemState Disconnect()
        {
            Console.WriteLine("Disconnecting...");
            return new On();
        }

        public IModemState TurnOn()
        {
            Console.WriteLine("Already On");
            return this;
        }

        public IModemState TurnOff()
        {
            Console.WriteLine("Turning Off");
            return new Off();
        }
    }
}
