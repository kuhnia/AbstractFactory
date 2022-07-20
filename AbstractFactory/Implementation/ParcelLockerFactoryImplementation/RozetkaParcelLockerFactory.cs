using AbstractFactory.Implementation.BoxImplementation;
using AbstractFactory.Implementation.ComputerImplementation;
using AbstractFactory.Implementation.ScreenImplementation;
using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Implementation.ParcelLockerFactoryImplementation
{
    internal class RozetkaParcelLockerFactory : IParcelLockerFactory
    {
        public IBox CreateBox()
        {
            return new SimpleBox();
        }

        public IComputer CreateComputer()
        {
            return new IntelComputer();
        }

        public IScreen CreateScreen()
        {
            return new BigScreen();
        }
    }
}
