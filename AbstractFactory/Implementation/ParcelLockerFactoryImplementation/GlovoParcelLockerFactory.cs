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
    public class GlovoParcelLockerFactory : IParcelLockerFactory
    {
        public IBox CreateBox()
        {
            return new FridgeBox();
        }

        public IComputer CreateComputer()
        {
            return new RaspberyComputer();
        }

        public IScreen CreateScreen()
        {
            return new SmallScreen();
        }
    }
}
