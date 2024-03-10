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
            do
            {
                ConsoleMessage.OutputHello();

                Shawarma shawarma = ChooseShawarma();

                shawarma = ChooseAdditives(shawarma);

                shawarma = ChooseRoleDiscount(shawarma);

                ConsoleMessage.OutputCompositionShawarma(shawarma);

            } while (ConsoleMessage.PoolYesOrNo("Купить ещё шаурму"));
        }

        public static Shawarma ChooseShawarma()
        {
            do
            {
                Shawarma someShawarma;
                int shawarmaNumber = ConsoleMessage.ChoiceShawarma();
                if (shawarmaNumber == 1)
                {
                    someShawarma = new(new ClassicShawarmaFactory());

                }
                else if (shawarmaNumber == 2)
                {
                    someShawarma = new(new CheeseShawarmaFactory());

                }
                else if (shawarmaNumber == 3)
                {
                    someShawarma = new(new MexicanShawarmaFactory());
                }
                else if (shawarmaNumber == 4)
                {
                    someShawarma = new(new VeganShawarmaFactory());
                }
                else
                {
                    ConsoleMessage.OutputUnknownInput();
                    continue;
                }
                ConsoleMessage.OutputGoodChoise();
                return someShawarma;
            } while (true);
        }

        public static Shawarma ChooseAdditives(Shawarma shawarma)
        {
            Shawarma someShawarmaAdditives = shawarma;
            do
            {
                int additivesNumber = ConsoleMessage.ChoiceAdditives();
                if (additivesNumber == 1)
                {
                    someShawarmaAdditives = new CheeseDecorator(someShawarmaAdditives);

                }
                else if (additivesNumber == 2)
                {
                    someShawarmaAdditives = new FrenchFriesDecorator(someShawarmaAdditives);

                }
                else if (additivesNumber == 3)
                {
                    someShawarmaAdditives = new JalapenoDecorator(someShawarmaAdditives);
                }
                else if (additivesNumber == 4)
                {
                    ConsoleMessage.OutputNoAdditives();
                    break;
                }
                else
                {
                    ConsoleMessage.OutputUnknownInput();
                    continue;
                }
                ConsoleMessage.OutputGoodChoise();
            } while (ConsoleMessage.PoolYesOrNo("Выбрать еще добавку?"));
            return someShawarmaAdditives;
        }

        public static Shawarma ChooseRoleDiscount(Shawarma shawarma)
        {
            Shawarma someShawarmaDiscount = shawarma;
            do
            {
                ConsoleMessage.OutputIntroduce();
                int shawarmaNumber = ConsoleMessage.ChoiceDiscount();
                if (shawarmaNumber == 1)
                {
                    ConsoleMessage.OutputStudentDiscount();
                    someShawarmaDiscount.Cost = new StudentDiscount();

                }
                else if (shawarmaNumber == 2)
                {
                    ConsoleMessage.OutputHomelessDiscount();
                    someShawarmaDiscount.Cost = new HomelessDiscount();


                }
                else if (shawarmaNumber == 3)
                {
                    ConsoleMessage.OutputBirthdayDiscount();
                    someShawarmaDiscount.Cost = new BirthdayDiscount();

                }
                else if (shawarmaNumber == 4)
                {
                    ConsoleMessage.OutputNoDiscount();
                }
                else
                {
                    ConsoleMessage.OutputUnknownInput();
                    continue;
                }
                return someShawarmaDiscount;
            } while (true);
        }

        public static void ErrorHandling()
        {
            throw new NotImplementedException();
        }
    }
}
