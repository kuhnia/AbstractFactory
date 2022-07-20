using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Implementation.ComputerImplementation
{
    public class IntelComputer : IComputer
    {
        public int RAM => 8;

        public int Storage => 64;

        public int TFlops => 8;
    }
}
