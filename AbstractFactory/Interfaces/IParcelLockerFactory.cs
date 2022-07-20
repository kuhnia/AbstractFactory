using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Interfaces
{
    public interface IParcelLockerFactory
    {
        public IComputer CreateComputer();
        public IBox CreateBox();
        public IScreen CreateScreen();
    }
}
