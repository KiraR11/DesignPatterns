using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Model;
using DesignPatterns.Model.Products;
using DesignPatterns.Model.Products.Additives;

namespace DesignPatterns.ConsoleView
{
    public static class ConsoleMessage
    {
        public static void  OutputCompositionShawarma(Shawarma shawarma)
        {
            Console.WriteLine("____________________________________________");
            Console.WriteLine($"\nСостав {shawarma.Name}:\n");
            Console.WriteLine($"Мясо: {shawarma.Meat.GetName()}\n");
            Console.WriteLine($"Соус: {shawarma.Sauce.GetName()}\n");
            Console.WriteLine($"Лаваш: {shawarma.Lavash.GetName()}\n");
            OutputAdditivesShawarma(shawarma.Additives);

            Console.WriteLine($"Цена: {shawarma.Discount()}");
            Console.WriteLine("____________________________________________");
        }

        public static void OutputAdditivesShawarma(Additives additives)
        {
            if (additives.AdditivesProduct.Count != 0)
            {
                Console.WriteLine($"Добавки: \n");
                foreach (Product added in additives.AdditivesProduct)
                {
                    Console.WriteLine($"    {added.GetName()}\n");
                }
            }
        }
    }
}
