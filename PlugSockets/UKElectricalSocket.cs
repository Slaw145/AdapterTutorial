using System;
using System.Collections.Generic;
using System.Text;

namespace adapter2
{
    public interface UKPlugConnector
    {
        void provideElectricity();
    }

    public class UKElectricalSocket : UKPlugConnector
    {
        public void provideElectricity()
        {
            Console.WriteLine("Use electricity systems from USA");
        }
    }
}
