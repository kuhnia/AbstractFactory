using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Implementation.BoxImplementation
{
    public class FreezerBox : IBox
    {
        public int Width => 4;

        public int Height => 4;

        public int MinTemperature => -5;

        public int MaxTemperature => -1;
    }
}
