using SpeedyAir.Abstractions;

namespace SpeedyAir.Presentation
{
    public class ConsoleScreen : IScreen
    {
        private readonly IMenu _menu;
        public ConsoleScreen(IMenu menu)
        {
            _menu = menu;
        }

        public void PrintLine(string message)
        {
            Console.WriteLine(message);
        }

        public void Print(string message)
        {
            Console.Write(message);
        }

        public string? ReadCommand()
        {
            return Console.ReadLine();
        }

        public void PauseToExit()
        {
            PrintLine("Press Any Key to Exit!");
            Console.ReadKey();
        }

        public void DisplayMenu()
        {
            _menu.Prompt(this);
        }
    }
}
