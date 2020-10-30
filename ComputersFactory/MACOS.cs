using System;
using System.Collections.Generic;
using System.Text;

namespace ComputersFactory
{
    class MACOS : IComputer
    {
        public void sell_computer(string name, int code, int price)
        {
            Console.WriteLine("MACOS sell to: " + name + " with code " + code.ToString() + " and price: " + price.ToString() + "$");
        }
    }
}
