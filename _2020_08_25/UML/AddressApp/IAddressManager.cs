using System;
using System.Collections.Generic;
using System.Text;

namespace AddressApp
{
    interface IAddressManager
    {
        public void InsertAddress();
        public void DeleteAddress();
        public void UpdateAddress();
        public void SearchAddress();
        public void PrintAllAddress();
        public void Exit();
    }
}
