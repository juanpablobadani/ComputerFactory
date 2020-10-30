using System;
using System.Collections.Generic;
using System.Text;

namespace ComputersFactory
{
    class Lenovo : IComputer
    {
        public void sell_computer(string name, int code, int price)
        {
            Console.WriteLine("Lenovo sell to: " + name + " with code " + code.ToString() + " and price: " + price.ToString() + "$");
        }
    }
}
