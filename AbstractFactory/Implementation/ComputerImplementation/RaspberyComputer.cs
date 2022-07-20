using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Implementation.ComputerImplementation
{
    public class RaspberyComputer : IComputer
    {
        public int RAM => 4;

        public int Storage => 32;

        public int TFlops => 5;
    }
}
