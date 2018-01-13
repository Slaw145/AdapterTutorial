using System;
using System.Collections.Generic;
using System.Text;

namespace adapter2
{
    public interface PolandPlugConnector
    {
        void giveElectricity();
    }

    public class PolandElectricalSocket : PolandPlugConnector
    {
        public void giveElectricity()
        {
            Console.WriteLine("Use electricity systems from Poland");
        }
    }
}
