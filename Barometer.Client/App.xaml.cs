using NServiceBus;

namespace Barometer.Client
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        public App()
        {
            Configure.With()
                .DefaultBuilder()
                .Log4Net()  
                .XmlSerializer()
                .MsmqTransport()
                .UnicastBus()
                .CreateBus()
                .Start(() => Configure.Instance.ForInstallationOn<NServiceBus.Installation.Environments.Windows>().Install());
        }
    }
}
