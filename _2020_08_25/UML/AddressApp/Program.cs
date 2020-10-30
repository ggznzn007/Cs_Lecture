using System;

namespace AddressApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressManager addrMgr = new AddressManager();
            AddressView addrView = new AddressView(addrMgr);
            addrView.MainLoop();
        }
    }
}
