using System;
using System.Collections.Generic;
using System.Text;

namespace ComputersFactory
{
    class Concret_computer_store : Computer_store
    {
        public override IComputer GetComputer(string computer)
        {

            switch (computer)
            {
                case "Lenovo":
                    return new Lenovo();

                case "MACOS":
                    return new MACOS();

                case "Dell":
                    return new Dell();

                default:
                    throw new Exception(string.Format("Computer '{0}' cannot be created", computer));


            }
        }
    }
}
