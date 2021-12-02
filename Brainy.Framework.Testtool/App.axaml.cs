using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Brainy.Framework.Testtool.TestPage;

namespace Brainy.Framework.Testtool
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            var startInformation = Bootstrapper.Boot(new MainModule(), "Brainy.Framework.Testtool");
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = startInformation.MainWindow;
            }

            base.OnFrameworkInitializationCompleted();
            startInformation.NavigationService.NavigateToAsync<MainViewModel>();
        }
    }
}