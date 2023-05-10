namespace SpeedyAir.Abstractions
{
    public interface IScreen
    {
        public void PrintLine(string message);
        public string? ReadLine();
        public void PauseToExit();
    }
}
