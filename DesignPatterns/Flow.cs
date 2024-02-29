using DesignPatterns.Model;
using DesignPatterns.Model.ShawarmaDecorators;
using DesignPatterns.Model.ShawarmaFactorys;
using DesignPatterns.Model.ShawarmaStrategy;

namespace DesignPatterns.ConsoleView
{
    public class Flow
    {
        public static void StartProgram()
        {
            Shawarma classicShawarma = new(new ClassicShawarmaFactory());
            Shawarma veganShawarma = new(new VeganShawarmaFactory());
            Shawarma mexicanShawarma = new(new MexicanShawarmaFactory());
            Shawarma cheeseShawarma = new(new CheeseShawarmaFactory());
            classicShawarma = new CheeseDecorator(new CheeseDecorator(new CheeseDecorator(classicShawarma)));
            classicShawarma = new JalapenoDecorator(new JalapenoDecorator(new CheeseDecorator(classicShawarma)));
            classicShawarma = new FrenchFriesDecorator(new FrenchFriesDecorator(new CheeseDecorator(classicShawarma)));
            classicShawarma.SetDiscount(new HomelessDiscount());
            veganShawarma.SetDiscount(new BirthdayDiscount());
            mexicanShawarma.SetDiscount(new HolidayDiscount());
            cheeseShawarma.SetDiscount(new StudentDiscount());
            ConsoleMessage.OutputCompositionShawarma(classicShawarma);
            ConsoleMessage.OutputCompositionShawarma(veganShawarma);
            ConsoleMessage.OutputCompositionShawarma(mexicanShawarma);
            ConsoleMessage.OutputCompositionShawarma(cheeseShawarma);

            

        }

        public static void ErrorHandling()
        {
            throw new NotImplementedException();
        }
    }
}
