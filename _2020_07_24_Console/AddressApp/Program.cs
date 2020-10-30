using System;

namespace AddressApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressView addrView = new AddressView();
            addrView.SetAddressManager(new AddressManager());
            addrView.MainLoop();
        }
    }
}
