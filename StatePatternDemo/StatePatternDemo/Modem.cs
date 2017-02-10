using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternDemo
{
    public class Modem
    {
        //private string _state;
        private IModemState _modemState;

        public Modem()
        {
            _modemState = new Off();
        }

        public void Connect()
        {
            _modemState = _modemState.Connect();
        }

        public void Disconnect()
        {
            _modemState = _modemState.Disconnect();
        }

        public void TurnOn()
        {
            _modemState = _modemState.TurnOn();
        }

        public void Turnoff()
        {
            _modemState =_modemState.TurnOff();
        }
    }
}
