using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Brainy.Framework.Testtool.TestPage2
{
    public class OtherView : UserControl
    {
        public OtherView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}