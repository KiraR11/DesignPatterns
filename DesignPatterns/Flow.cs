using DesignPatterns.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ConsoleView
{
    internal class Flow
    {
        public static void GetFlow()
        {
            Console.WriteLine("Start\n");

            Kit drillHammerKit = new Kit(new DrillHammerToolSetFactory());
            Console.WriteLine("Аренда набора с дрелью и молотком\n");
            drillHammerKit.Rent();
            Console.WriteLine("\nВозвращение набора с дрелью и молотком\n");
            drillHammerKit.Return();
            Console.WriteLine();

            Kit SawScrewdriverKit = new Kit(new SawScrewdriverToolSetFactory());
            Console.WriteLine("Аренда набора с пилой и отвёрткой\n");
            SawScrewdriverKit.Rent();
            Console.WriteLine("\nВозвращение набора с пилой и отвёрткой\n");
            SawScrewdriverKit.Return();

            Console.ReadLine();

        }
    }
}
