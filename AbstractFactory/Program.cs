using AbstractFactory.Interfaces;
using AbstractFactory.Implementation.ParcelLockerFactoryImplementation;

namespace AbstractFactory
{
    class Program
    {
        public static void Main()
        {
            AbstractFactoryDemo demo = new AbstractFactoryDemo();
            demo.ShowAbstractFactoryAbility();
        }
    }
}
