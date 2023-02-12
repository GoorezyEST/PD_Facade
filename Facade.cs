using Facade_PD.SubSystems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_PD
{
    internal class Facade
    {
        // Instance variables for SubSystemA, SubSystemB, and SubSystemC
        private SubSystemA subSystemA = new SubSystemA();
        private SubSystemB subSystemB = new SubSystemB();
        private SubSystemC subSystemC = new SubSystemC();

        // Operation 1 which calls MethodA of SubSystemA and MethodB of SubSystemB
        public void Operation1()
        {
            Console.WriteLine("Operation 1 starts");
            subSystemA.MethodA();
            subSystemB.MethodB();
            Console.WriteLine("Operation 1 ends");
        }
        // Operation 2 which calls MethodB of SubSystemB and MethodC of SubSystemC
        public void Operation2()
        {
            Console.WriteLine("Operation 2 starts");
            subSystemB.MethodB();
            subSystemC.MethodC();
            Console.WriteLine("Operation 2 ends");
        }
    }
}
