using Avalonia.Controls;
using Brainy.Framework.Contract.Navigation;

namespace Brainy.Framework.Contract
{
    public class StartInformation
    {
        public StartInformation(Window mainWindow, INavigation navigationService)
        {
            MainWindow = mainWindow;
            NavigationService = navigationService;
        }

        public Window MainWindow { get; }
        public INavigation NavigationService { get; }
    }
}