using NServiceBus;

namespace Barometer.Contracts.Manager.Data
{
    public class CreateTaskCommand : ICommand
    {
        public string TaskName { get; set; }
    }
}
