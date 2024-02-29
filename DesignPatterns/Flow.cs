using DesignPatterns.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Model;
using DesignPatterns.Model.ShawarmaFactorys;

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
