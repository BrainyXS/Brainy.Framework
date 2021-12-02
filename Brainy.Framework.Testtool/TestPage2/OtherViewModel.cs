using System.Threading.Tasks;
using System.Windows.Input;
using Brainy.Framework.Commands;
using Brainy.Framework.Contract;
using Brainy.Framework.Contract.Navigation;
using Brainy.Framework.Testtool.TestPage;
using ReactiveUI;

namespace Brainy.Framework.Testtool.TestPage2
{
    public class OtherViewModel : ViewModelBase, INotifyOnNavigate
    {
        private string _testText;
        public ICommand GoBackCommand { get; set; }

        public string TestText
        {
            get => _testText;
            set => this.RaiseAndSetIfChanged(ref _testText, value);
        }

        public OtherViewModel()
        {
            _testText = string.Empty;
            GoBackCommand = new RelayCommand(GoBack);
        }

        private void GoBack()
        {
            Navigation.NavigateToAsync<MainViewModel>();
        }

        public async Task OnNavigated(NavigationContext navigationContext)
        {
            TestText = "Asynchronus navigation! Watch this Text!";
            await Task.Delay(10000);
            TestText = "The Text changed!!";
        }
    }
}