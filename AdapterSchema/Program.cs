using System;

namespace adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Adapter adapter = new Adapter();
            adapter.SomeMethod1(); //Calling the SomeMethod1 method

            Console.ReadKey();
        }
    }
}
