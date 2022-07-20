using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Interfaces
{
    public interface IComputer
    {
        public int RAM { get;}
        public int Storage { get;}
        public int TFlops { get;}
    }
}
