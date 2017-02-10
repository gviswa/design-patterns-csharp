using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var modem = new Modem();
            modem.Connect();
            modem.TurnOn();
            modem.Connect();
            modem.Disconnect();
            modem.Turnoff();
            modem.Disconnect();
            Console.Read();
        }
    }
}
