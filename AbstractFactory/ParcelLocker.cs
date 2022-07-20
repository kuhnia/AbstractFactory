using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ParcelLocker
    {
        public string CompanyName { get; set; }
        public IComputer Computer { get; set; }
        public IBox Box { get; set; }
        public IScreen Screen { get; set; }

        public ParcelLocker(string companyName, IParcelLockerFactory parcelLockerFactory)
        {
            CompanyName = companyName;
            Computer = parcelLockerFactory.CreateComputer();
            Box = parcelLockerFactory.CreateBox();
            Screen = parcelLockerFactory.CreateScreen();
        }

        public void PrintInfo()
        {
            Console.WriteLine($"\n{CompanyName}`s parcel locker:\n");

                Console.WriteLine($"\tComputer:");
                    Console.WriteLine($"\t\tTFlops: {Computer.TFlops}");
                    Console.WriteLine($"\t\tStorage: {Computer.Storage}");
                    Console.WriteLine($"\t\tRAM: {Computer.RAM}");

                Console.WriteLine($"\tBox:");
                    Console.WriteLine($"\t\tWidth: {Box.Width}");
                    Console.WriteLine($"\t\tHeight: {Box.Height}");
                    Console.WriteLine($"\t\tMinimal temperature: {Box.MinTemperature}");
                    Console.WriteLine($"\t\tMaximal temperature: {Box.MaxTemperature}");

                Console.WriteLine($"\tScreen:");
                    Console.WriteLine($"\t\tWidth: {Screen.Width}");
                    Console.WriteLine($"\t\tHeight: {Screen.Height}");
                    Console.WriteLine($"\t\tDiagonal: {Screen.Diagonal}\n");
        }
    }
}
