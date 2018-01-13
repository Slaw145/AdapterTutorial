using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter1
{
    class IphoneAdapter : Iiphone6
    {
        Iiphone7 iphone7 = new Iphone7();
        public void ProtectedFromWater(bool ifprotected)
        {
            iphone7.PhoneIsProtectedFromWater(ifprotected);
        }

        public void SizeOfScreen(int inch)
        {
            iphone7.PhoneSizeScreen(inch);
        }

        public void SpeedWorking(string speed)
        {
            iphone7.SpeedPhoneWorking(speed);
        }
    }
}
