using System.Threading.Tasks;

namespace Brainy.Framework.Contract
{
    public interface INavigation
    {
        Task NavigateToAsync<TViewModel>() where TViewModel : ViewModelBase;
    }
}