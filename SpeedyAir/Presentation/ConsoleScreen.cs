using SpeedyAir.Abstractions;

namespace SpeedyAir.Presentation
{
    public class ConsoleScreen : IScreen
    {
        public void PrintLine(string message)
        {
            Console.WriteLine(message);
        }

        public string? ReadLine()
        {
            return Console.ReadLine();
        }

        public void PauseToExit()
        {
            PrintLine("Press Any Key to Exit!");
            Console.ReadKey();
        }
    }
}
