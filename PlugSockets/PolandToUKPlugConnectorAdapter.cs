using System;
using System.Collections.Generic;
using System.Text;

namespace adapter2
{
    public class PolandToUKPlugConnectorAdapter : UKPlugConnector
    {
        private UKPlugConnector plug;

        public PolandToUKPlugConnectorAdapter(UKPlugConnector plug)
        {
            this.plug = plug;
        }

        public void giveElectricity()
        {
            plug.provideElectricity();
        }
    }
}
