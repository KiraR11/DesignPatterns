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
        public static void OutputCompositionShawarma(Shawarma shawarma)
        {
            Console.WriteLine("____________________________________________");
            Console.WriteLine($"\nСостав {shawarma.Name}:\n");
            Console.WriteLine($"Мясо: {shawarma.Meat.GetName()}\n");
            Console.WriteLine($"Соус: {shawarma.Sauce.GetName()}\n");
            Console.WriteLine($"Лаваш: {shawarma.Lavash.GetName()}\n");
            OutputAdditivesShawarma(shawarma.Additives);
            OutputCookingTimeShawarma(shawarma);
            Console.WriteLine($"Цена: {shawarma.ResultCost()}");
            Console.WriteLine("____________________________________________");
        }

        private static void OutputCookingTimeShawarma(Shawarma shawarma)
        {
            Console.WriteLine($"\nВаша шаурма будет готова через: {shawarma.GetCookingTime().ToString("mm:ss")} минут");
        }

        public static bool PoolYesOrNo(string question)
        {
            string yes = "y";
            string no = "n";
            Console.WriteLine("\n{0}? ({1}/{2})\n", question, yes, no);
            while (true)
            {
                string answer = Console.ReadLine()!;
                if (answer!.ToLower() == yes)
                    return true;
                else if (answer.ToLower() == no)
                    return false;
                else
                    MessageIncorrectInput();
            }
        }
        public static void MessageIncorrectInput()
        {
            Console.WriteLine("\nНекорректный ввод поробуйте ещё раз\n");
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

        public static void OutputHello()
        {
            Console.WriteLine("Здравствуй, дорогой покупатель!");
        }

        public static void OutputIntroduce()
        {
            Console.WriteLine("О боже... не может быть. Ваше... имя Сэр?");
        }
        public static void OutputGetDiscount()
        {
            Console.WriteLine("Так это вы!");
        }
        public static int ChoiceDiscount()
        {
            Console.WriteLine("1 - Студент\n2 - Бездомный\n3 - Именинник\n4 - Обычный человек");
            int roleNumber = int.Parse(Console.ReadLine());
            return roleNumber;
        }
        public static void OutputHomelessDiscount()
        {
            OutputGetDiscount();
            Console.WriteLine("Вам положена скидка Бездомного!");
        }
        public static void OutputStudentDiscount()
        {
            OutputGetDiscount();
            Console.WriteLine("Вам положена скидка Студента!");
        }
        public static void OutputBirthdayDiscount()
        {
            OutputGetDiscount();
            Console.WriteLine("Вам положена скидка Именинника!");
        }
        public static void OutputNoDiscount()
        {
            OutputGetDiscount();
            Console.WriteLine("Вы обычный человек, вам не положено скидок!");
        }
        public static void OutputUnknownInput()
        {
            Console.WriteLine("Я кажется не расслышал...");
        }
        public static int ChoiceShawarma()
        {
            Console.WriteLine("Какую шаурму хотите?\n1 - Классическая\n2 - Сырная\n3 - Мексиканская\n4 - Вегетарианская");
            int shawarmaNumber = int.Parse(Console.ReadLine());
            return shawarmaNumber;
        }
        public static void OutputGoodChoise()
        {
            Console.WriteLine("Отличный выбор!");
        }
        public static int ChoiceAdditives()
        {
            Console.WriteLine("Какие добавки хотите?\n1 - Сыр\n2 - Картошка фри\n3 - Халапеньо\n4 - Без добавок");
            int shawarmaNumber = int.Parse(Console.ReadLine());
            return shawarmaNumber;
        }
        public static void OutputNoAdditives()
        {
            Console.WriteLine("Хорошо, никаких добавок!");
        }
    }
}
