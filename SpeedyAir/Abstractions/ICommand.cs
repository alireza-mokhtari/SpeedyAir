namespace SpeedyAir.Abstractions
{
    public interface ICommand
    {
        public string CommandKey { get; }
        public string CommandLine { get; }
        public string Execute();        
    }
}
