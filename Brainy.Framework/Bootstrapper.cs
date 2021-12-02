using Autofac;
using Brainy.Framework.Contract;
using Brainy.Framework.MainWindow;
using Brainy.Framework.Navigation;

namespace Brainy.Framework
{
    public class Bootstrapper
    {
        public static StartInformation Boot(Module m, string assembly)
        {
            var window = new MainWindow.MainWindow();
            var mainWindowViewModel = new MainWindowViewModel();
            window.DataContext = mainWindowViewModel;
            var nav = new NavigationService();
            var builder = new ContainerBuilder();
            builder.RegisterModule(m);
            nav.Setup(mainWindowViewModel.Frame, builder, assembly);
            var ourput = new StartInformation(window, nav);
            return ourput;
        }
    }
}