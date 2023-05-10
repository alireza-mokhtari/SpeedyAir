using SpeedyAir.Abstractions;
using SpeedyAir.Abstractions.Repositories;
using SpeedyAir.Helpers;

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
            
            return schedules.SerializeFlightScheduleCollection();
        }
    }

}
