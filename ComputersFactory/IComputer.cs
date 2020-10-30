using System;
using System.Collections.Generic;
using System.Text;

namespace ComputersFactory
{
    public interface IComputer
    {
        void sell_computer(string name, int code, int price);
    }
}
