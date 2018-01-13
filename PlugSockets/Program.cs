using System;

namespace adapter2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Switch on poland socket");

            PolandElectricalSocket PolandPlugConnector = new PolandElectricalSocket();
            PolandPlugConnector.giveElectricity();

            Console.WriteLine("\nSwitch on USA socket");

            PolandToUKPlugConnectorAdapter USAPlugConnector = new PolandToUKPlugConnectorAdapter(new UKElectricalSocket());
            USAPlugConnector.giveElectricity();

            Console.ReadKey();
        }
    }
}
