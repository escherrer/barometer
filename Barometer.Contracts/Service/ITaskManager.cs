using System.ServiceModel;

namespace Barometer.Contracts.Service
{
    [ServiceContract]
    public interface ITaskManager
    {
        [OperationContract]
        CreateTaskResponse CreateTask(CreateTaskRequest createTaskRequest);
    }
}
