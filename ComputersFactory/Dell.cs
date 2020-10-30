using System;
using System.Collections.Generic;
using System.Text;

namespace ComputersFactory
{
    class Dell : IComputer
    {
        public void sell_computer(string name, int code, int price)
        {
            Console.WriteLine("Dell sell to: " + name + " with code " + code.ToString() + " and price: " + price.ToString() + "$");

        }
    }
}
