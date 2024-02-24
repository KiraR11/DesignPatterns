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
            Console.WriteLine("Start");

            Kit drillHammerKit = new Kit(new DrillHammerToolSetFactory());
            drillHammerKit.Rent();
            drillHammerKit.Return();

            Kit SawScrewdriverKit = new Kit(new SawScrewdriverToolSetFactory());
            SawScrewdriverKit.Rent();
            SawScrewdriverKit.Return();

            Console.ReadLine();

        }
    }
}
