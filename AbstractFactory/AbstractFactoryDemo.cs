using AbstractFactory.Implementation.ParcelLockerFactoryImplementation;
using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class AbstractFactoryDemo
    {
        IParcelLockerFactory Factory { get; set; }
        ParcelLocker MiasnyiDarParcelLocker { get; set; }
        ParcelLocker GlovoParcelLocker { get; set; }
        ParcelLocker RozetkaParcelLocker { get; set; }

        public void ShowAbstractFactoryAbility()
        {
            Factory = new MiasnyiDarParcelLockerFactory();
            MiasnyiDarParcelLocker = new ParcelLocker("Miasnyi Dar", Factory);
            MiasnyiDarParcelLocker.PrintInfo();

            Factory = new GlovoParcelLockerFactory();
            GlovoParcelLocker = new ParcelLocker("Glovo", Factory);
            GlovoParcelLocker.PrintInfo();

            Factory = new RozetkaParcelLockerFactory();
            RozetkaParcelLocker = new ParcelLocker("Rozetka", Factory);
            RozetkaParcelLocker.PrintInfo();
        }
    }
}
