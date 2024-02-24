using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Model
{
// Интерфейс для инструментов
    public abstract class Tool
    {
        public abstract decimal CalculateRentalCost(int days);
        public abstract void Rent();
        public abstract void Return();
    }

    // Интерфейс для фабрики создания набора инструментов

    // Реализация инструмента - Дрель
    public class Drill : Tool
    {
        public override decimal CalculateRentalCost(int days) => 5.0m * days;

        public override void Rent() => Console.WriteLine("Дрель взята в аренду");

        public override void Return() => Console.WriteLine("Дрель возвращена");
    }

    // Реализация инструмента - Молоток
    public class Hammer : Tool
    {
        public override decimal CalculateRentalCost(int days) => 3.0m * days;

        public override void Rent() => Console.WriteLine("Молоток взят в аренду");

        public override void Return() => Console.WriteLine("Молоток возвращен");
    }

    // Реализация инструмента - Пила
    public class Saw : Tool
    {
        public override decimal CalculateRentalCost(int days) => 6.0m * days;

        public override void Rent() => Console.WriteLine("Пила взята в аренду");

        public override void Return() => Console.WriteLine("Пила возвращена");
    }

    // Реализация инструмента - Отвёртка
    public class Screwdriver : Tool
    {
        public override decimal CalculateRentalCost(int days) => 2.0m * days;

        public override void Rent() => Console.WriteLine("Отвёртка взята в аренду");

        public override void Return() => Console.WriteLine("Отвёртка возвращена");
    }
    public abstract class ToolSetFactory
    {
        public abstract Tool CreateToolA();
        public abstract Tool CreateToolB();
    }

    // Фабрика для создания набора с дрелью и молотком
    public class DrillHammerToolSetFactory : ToolSetFactory
    {
        public override Tool CreateToolA() => new Drill();

        public override Tool CreateToolB() => new Hammer();
    }

    // Фабрика для создания набора с пилой и отвёрткой
    public class SawScrewdriverToolSetFactory : ToolSetFactory
    {
        public override Tool CreateToolA() => new Saw();

        public override Tool CreateToolB() => new Screwdriver();
    }

    public class Kit
    {
        private Tool toolOne;
        private Tool toolTwo;
        public Kit(ToolSetFactory factory)
        {
            toolOne = factory.CreateToolA();
            toolTwo = factory.CreateToolB();
        }
        public void Rent(int days)
        {
            toolOne.Rent();
            decimal costFirstTool = toolOne.CalculateRentalCost(days);
            toolTwo.Rent();
            decimal costSecondTool = toolTwo.CalculateRentalCost(days);

            decimal resultCost = (costFirstTool + costSecondTool) * 0.7m;
            Console.WriteLine("Стоимость набора: {0}", resultCost);   // Тут этого быть не должно, ну и рассчёт стоимости тоже должен уйти
        }
        public void Return()
        {
            toolOne.Return();
            toolTwo.Return();
        }
    }
}
