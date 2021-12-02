using System.Threading.Tasks;

namespace Brainy.Framework.Contract.Navigation
{
    public interface INavigation
    {
        Task NavigateToAsync<TViewModel>(params object[] parameter) where TViewModel : ViewModelBase;
    }
}