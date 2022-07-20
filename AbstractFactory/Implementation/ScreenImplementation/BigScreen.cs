using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Implementation.ScreenImplementation
{
    public class BigScreen : IScreen
    {
        public int Width => 1080;

        public int Height => 1920;

        public int Diagonal => 15;
    }
}
