using System;
using Barometer.Contracts.Manager.Data;
using NServiceBus.Saga;

namespace Barometer.TaskManagement.Saga
{
    public class CreateTaskSaga : Saga<CreateTaskSagaData>, IAmStartedByMessages<CreateTaskCommand>
    {
        public void Handle(CreateTaskCommand message)
        {
            Console.WriteLine("Got it!");
        }
    }
}
