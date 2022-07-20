using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Interfaces
{
    public interface IBox
    {
        public int Width { get;}
        public int Height { get;}
        public int MinTemperature { get;}
        public int MaxTemperature { get;}
    }
}
