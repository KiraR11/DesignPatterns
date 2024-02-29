using DesignPatterns.Model;
using DesignPatterns.Model.ShawarmaDecorators;
using DesignPatterns.Model.ShawarmaFactorys;
using DesignPatterns.Model.ShawarmaStrategy;
using System.Reflection.Metadata.Ecma335;

namespace DesignPatterns.ConsoleView
{
    public class Flow
    {
        public static void StartProgram()
        {
            while (true)
            {

                //Shawarma classicShawarma = new(new ClassicShawarmaFactory());
                //Shawarma veganShawarma = new(new VeganShawarmaFactory());
                //Shawarma mexicanShawarma = new(new MexicanShawarmaFactory());
                //Shawarma cheeseShawarma = new(new CheeseShawarmaFactory());
                //classicShawarma = new CheeseDecorator(new CheeseDecorator(new CheeseDecorator(classicShawarma)));
                //classicShawarma = new JalapenoDecorator(new JalapenoDecorator(new CheeseDecorator(classicShawarma)));
                //classicShawarma = new FrenchFriesDecorator(new FrenchFriesDecorator(new CheeseDecorator(classicShawarma)));

                //classicShawarma.SetDiscount(new HomelessDiscount());

                //classicShawarma.SetDiscount(new BirthdayDiscount());
                //classicShawarma.SetDiscount(new StudentDiscount());
                //ConsoleMessage.OutputCompositionShawarma(classicShawarma);

                //ConsoleMessage.OutputCompositionShawarma(classicShawarma);
                //ConsoleMessage.OutputCompositionShawarma(veganShawarma);
                //ConsoleMessage.OutputCompositionShawarma(mexicanShawarma);
                //ConsoleMessage.OutputCompositionShawarma(cheeseShawarma);

                ConsoleMessage.OutputHello();

                Shawarma shawarma = ChooseShawarma();

                shawarma = ChooseAdditives(shawarma);

                shawarma = ChooseRoleDiscount(shawarma);

                ConsoleMessage.OutputCompositionShawarma(shawarma);

                Console.ReadKey();




            }
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
            do
            {
                Shawarma someShawarmaAdditives = shawarma;
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
                }
                else
                {
                    ConsoleMessage.OutputUnknownInput();
                    continue;
                }
                ConsoleMessage.OutputGoodChoise();
                return someShawarmaAdditives;
            } while (true);
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
                    someShawarmaDiscount.SetDiscount(new StudentDiscount());

                }
                else if (shawarmaNumber == 2)
                {
                    ConsoleMessage.OutputHomelessDiscount();
                    someShawarmaDiscount.SetDiscount(new HomelessDiscount());


                }
                else if (shawarmaNumber == 3)
                {
                    ConsoleMessage.OutputBirthdayDiscount();
                    someShawarmaDiscount.SetDiscount(new BirthdayDiscount());

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
