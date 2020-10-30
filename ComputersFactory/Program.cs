using System;

namespace ComputersFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer_store store = new Concret_computer_store();

            IComputer macos = store.GetComputer("MACOS");
            macos.sell_computer("alberto", 02341, 2200);

            IComputer lenovo = store.GetComputer("Lenovo");
            lenovo.sell_computer("roberto", 02342, 1600);

            IComputer dell = store.GetComputer("Dell");
            dell.sell_computer("francisco", 02343, 1300);

            IComputer huawei = store.GetComputer("Huawei");
            huawei.sell_computer("sebastian", 02344, 1450);

            Console.ReadKey();
        }
    }
}
