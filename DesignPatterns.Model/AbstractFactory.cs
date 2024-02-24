using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Model
{
    internal class AbstractFactory
    {
    }

// Интерфейс для инструментов
    public interface ITool
    {
        decimal CalculateRentalCost(int days);
        void Rent();
        void Return();
    }

    // Интерфейс для фабрики создания набора инструментов
    public interface IToolSetFactory
    {
        ITool CreateToolA();
        ITool CreateToolB();
    }

    // Реализация инструмента - Дрель
    public class Drill : ITool
    {
        public decimal CalculateRentalCost(int days) => 5.0m * days;

        public void Rent() => Console.WriteLine("Дрель взята в аренду");

        public void Return() => Console.WriteLine("Дрель возвращена");
    }

    // Реализация инструмента - Молоток
    public class Hammer : ITool
    {
        public decimal CalculateRentalCost(int days) => 3.0m * days;

        public void Rent() => Console.WriteLine("Молоток взят в аренду");

        public void Return() => Console.WriteLine("Молоток возвращен");
    }

    // Реализация инструмента - Пила
    public class Saw : ITool
    {
        public decimal CalculateRentalCost(int days) => 6.0m * days;

        public void Rent() => Console.WriteLine("Пила взята в аренду");

        public void Return() => Console.WriteLine("Пила возвращена");
    }

    // Реализация инструмента - Отвёртка
    public class Screwdriver : ITool
    {
        public decimal CalculateRentalCost(int days) => 2.0m * days;

        public void Rent() => Console.WriteLine("Отвёртка взята в аренду");

        public void Return() => Console.WriteLine("Отвёртка возвращена");
    }

    // Фабрика для создания набора с дрелью и молотком
    public class DrillHammerToolSetFactory : IToolSetFactory
    {
        public ITool CreateToolA() => new Drill();

        public ITool CreateToolB() => new Hammer();
    }

    // Фабрика для создания набора с пилой и отвёрткой
    public class SawScrewdriverToolSetFactory : IToolSetFactory
    {
        public ITool CreateToolA() => new Saw();

        public ITool CreateToolB() => new Screwdriver();
    }

    public class Kit
    {
        private ITool toolOne;
        private ITool toolTwo;
        public Kit(IToolSetFactory factory)
        {
            toolOne = factory.CreateToolA();
            toolTwo = factory.CreateToolB();
        }
        public void Rent()
        {
            toolOne.Rent();
            toolTwo.Rent();
        }
        public void Return()
        {
            toolOne.Return();
            toolTwo.Return();
        }
    }
}
