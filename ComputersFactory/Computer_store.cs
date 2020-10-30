using System;
using System.Collections.Generic;
using System.Text;

namespace ComputersFactory
{
    public abstract class Computer_store
    {
        public abstract IComputer GetComputer(string computer);

    }
}
