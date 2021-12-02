using System.Threading.Tasks;

namespace Brainy.Framework.Contract.Navigation
{
    public interface INotifyOnNavigate
    {
        Task OnNavigated(NavigationContext navigationContext);
    }
}