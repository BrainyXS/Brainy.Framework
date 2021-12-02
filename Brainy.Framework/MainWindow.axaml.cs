using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Brainy.Framework
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Content = new UserControl();
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}