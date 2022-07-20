using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Implementation.BoxImplementation
{
    public class SimpleBox : IBox
    {
        public int Width => 4;

        public int Height => 2;

        public int MinTemperature => 1;

        public int MaxTemperature => 40;
    }
}
