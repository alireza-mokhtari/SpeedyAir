using SpeedyAir.Abstractions;
using System.Text;

namespace SpeedyAir.Commands
{
    public class GetAllFlightSchedulesCommand : ICommand
    {
        private IFlightRepository _flightRepository;
        public GetAllFlightSchedulesCommand(IFlightRepository flightRepository)
        {
            _flightRepository = flightRepository;
        }

        public string CommandKey => "A";

        public string CommandLine => "Display All Flight Schedules";

        public string Execute()
        {
            var schedules = _flightRepository.GetFlightSchedules();
            StringBuilder responseBuilder = new();

            for (int i = 0; i < schedules.Count; i++)           
                responseBuilder.AppendLine($"Flight {i + 1}, {schedules[i].ToString()}");            

            return responseBuilder.ToString();
        }
    }
}
