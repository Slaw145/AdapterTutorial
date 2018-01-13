using System;
using System.Collections.Generic;
using System.Text;

namespace adapter
{
    class Adapter : IClientInterface
    {
        public void SomeMethod1()
        {
            var oldclass = new NewClass();
            oldclass.SomeMethod2(); //Calling the SomeMethod2 method
        }
    }

    public interface IClientInterface
    {
        void SomeMethod1();
    }

    class NewClass
    {
        public void SomeMethod2()
        {
            Console.WriteLine("Calling the SomeMethod2 method");
        }
    }
}
