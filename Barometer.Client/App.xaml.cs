using NServiceBus;

namespace Barometer.Client
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        public static IBus Bus { get; private set; }

        public App()
        {
            Bus = Configure.With()
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
