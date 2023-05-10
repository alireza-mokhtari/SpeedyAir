using SpeedyAir.Abstractions;
using SpeedyAir.Abstractions.Repositories;
using SpeedyAir.Helpers;


namespace SpeedyAir.Commands
{
    public class GetAllLoadedFlightSchedulesCommand : ICommand
    {
        private IFlightRepository _flightRepository;
        public GetAllLoadedFlightSchedulesCommand(IFlightRepository flightRepository)
        {
            _flightRepository = flightRepository;
        }

        public string CommandKey => "B";

        public string CommandLine => "Display All Loaded Flight Schedules";

        public string Execute()
        {
            var schedules = _flightRepository.GetLoadedFlightSchedules();
            if (schedules != null && schedules.Any())
                return schedules.SerializeFlightScheduleCollection();
            else
                return Constants.NOT_FOUND;
        }
    }
    }
