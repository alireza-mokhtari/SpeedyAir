namespace SpeedyAir.Abstractions
{
    public interface IScreen
    {
        public void PrintLine(string message);
        public string? ReadCommand();
        public void PauseToExit();
        public void DisplayMenu();
    }
}
