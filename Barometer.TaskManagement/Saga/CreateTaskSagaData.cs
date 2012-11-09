using System;
using NServiceBus.Saga;

namespace Barometer.TaskManagement.Saga
{
    public class CreateTaskSagaData : IContainSagaData
    {
        public Guid Id { get; set; }
        public string Originator { get; set; }
        public string OriginalMessageId { get; set; }
    }
}