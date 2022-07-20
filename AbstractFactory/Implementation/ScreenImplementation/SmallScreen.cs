using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Implementation.ScreenImplementation
{
    public class SmallScreen : IScreen
    {
        public int Width => 768;

        public int Height => 1366;

        public int Diagonal => 10;
    }
}
