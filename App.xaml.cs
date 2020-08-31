using Prism.Ioc;
using System.Windows;

namespace TouhouMonitor
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<Views.MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<Services.ICustomerStore, Services.DbCustomerStore>();
        }
    }
}
