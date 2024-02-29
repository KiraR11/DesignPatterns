using DesignPatterns.ConsoleView;
using static DesignPatterns.ConsoleView.ConsoleMessage;
namespace DesignPatterns.ConsoleView
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Flow.StartProgram();
            }
            catch (Exception ex)
            {
                Flow.ErrorHandling();
            }
        }
    }
}

