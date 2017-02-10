namespace StatePatternDemo
{
    public interface IModemState
    {
        IModemState Connect();
        IModemState Disconnect();
        IModemState TurnOn();
        IModemState TurnOff();
    }
}